/*
Universidad: UNED
II Cuatrimestre
Proyecto I
Descripción: Lógica de negocio para el registro de ventas. El candado
(lock) garantiza que, aunque lleguen varias ventas al mismo tiempo desde
distintos clientes, la verificación de disponibilidad y el descuento de
entradas se ejecuten de forma atómica, evitando la sobreventa.
Estudiante: Angie Angulo Chacón
Fecha: 21/06/2026
*/
using Acceso;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Logica
{
    public class Logica_Ventas
    {
        private Conexion conexion = new Conexion();
        private Acceso_Ventas accesoVenta = new Acceso_Ventas();
        private Acceso_LocalidadesXPartido accesoLocalidadPartido = new Acceso_LocalidadesXPartido();

        // MISMO candado para TODAS las ventas, sin importar qué cliente la registre.
        // Debe ser static porque Logica_Ventas se puede instanciar varias veces
        // (una por cada hilo de cliente atendido), pero el candado tiene que ser uno solo
        // compartido por todas esas instancias.
        private static readonly object candadoVentas = new object();

        // Retorna string.Empty si la venta se registró correctamente,
        // o un mensaje de error específico si falló alguna validación.
        public string Agregar(Ventas venta)
        {
            try
            {
                // Validaciones que NO dependen de la disponibilidad (no necesitan el lock):
                if (venta == null)
                {
                    return "La venta no puede estar vacía.";
                }
                if (venta.Cantidad <= 0)
                {
                    return "La cantidad debe ser mayor a cero.";
                }
                if (venta.Cliente == null || !venta.Cliente.Activo)
                {
                    return "El cliente debe estar activo.";
                }
                if (venta.Partidos == null || !venta.Partidos.Activo)
                {
                    return "No se pueden vender entradas para partidos inactivos.";
                }
                if (venta.Partidos.Fecha.Date < DateTime.Now.Date)
                {
                    return "No se pueden vender boletos para partidos con fecha anterior a hoy.";
                }
                if(string.IsNullOrWhiteSpace(venta.TipoVenta))
{
                    venta.TipoVenta = "En línea";
                }
                if (venta.Localidades == null)
                {
                    return "Debe seleccionar una localidad.";
                }
                if (venta.Partidos == null)
                {
                    return "Debe seleccionar un partido.";
                }

                // A partir de aquí se toca la disponibilidad de la localidad: zona crítica.
                lock (candadoVentas)
                {
                    LocalidadesXpartido localidadPartido =
                        accesoLocalidadPartido.ObtenerLocalidadXPartido(venta.Partidos.IdPartido, venta.Localidades.IdLocalidad);

                    if (localidadPartido == null)
                    {
                        return "La localidad no está asociada a este partido.";
                    }

                    if (venta.Cantidad > localidadPartido.CantidadDisponible)
                    {
                        return "No hay suficientes entradas disponibles para esta localidad.";
                    }

                    // Calcular el monto total (no editable por el usuario)
                    venta.MontoTotal = venta.Cantidad * localidadPartido.Localidades.Precio;
                    venta.FechaVenta = DateTime.Now;

                    // Descontar disponibilidad y guardar todo dentro del mismo candado,
                    // para que ningún otro hilo pueda vender sobre estos mismos boletos
                    // mientras esta operación no haya terminado.
                    int nuevaCantidadDisponible = localidadPartido.CantidadDisponible - venta.Cantidad;
                    accesoLocalidadPartido.ActualizarCantidadDisponible(localidadPartido.IdLocalidadPartido, nuevaCantidadDisponible);

                    bool guardado = accesoVenta.Ingresar(venta);
                    if (!guardado)
                    {
                        return "No se pudo registrar la venta.";
                    }
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Error al registrar la venta: " + ex.Message;
            }
        }

        public List<Ventas> Listar()
        {
            try
            {
                return accesoVenta.ObtenerVentas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar ventas: " + ex.Message);
            }
        }

        public List<Ventas> ListarPorCliente(int idCliente)
        {
            try
            {
                List<Ventas> todas = accesoVenta.ObtenerVentas();
                List<Ventas> propias = new List<Ventas>();

                foreach (Ventas venta in todas)
                {
                    if (venta.Cliente.IdCliente == idCliente)
                    {
                        propias.Add(venta);
                    }
                }
                return propias;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar compras del cliente: " + ex.Message);
            }
        }

        //permite verificar si hay registros 
        public bool TieneVentas()
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Venta";

                    using (var comando = new SqlCommand(query, conn))
                    {
                        int count = (int)comando.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar registros de ventas: " + ex.Message);
            }
        }

    }
}