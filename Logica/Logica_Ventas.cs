using Acceso;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción: Esta clase representa la logica de ventas , en cual encontramos las validaciones para ingreso de
registros. 
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Logica
{
    public class Logica_Ventas
    {
        private Conexion conexion = new Conexion();
        private Acceso_Ventas AccesoVentas = new Acceso_Ventas();
        private Acceso_LocalidadesXPartido accesoLocalidadPartido = new Acceso_LocalidadesXPartido();

        //Metodo que permite agregar las ventas registradas en acceso de datos, simpre y cuando 
        // se cumplan las validaciones 
        public bool Agregar(Ventas venta)
        {           
            string mensaje = ValidarVenta(venta);
       
            if (!string.IsNullOrEmpty(mensaje))
                return false;

            return AccesoVentas.ingresar(venta);
        }
        //Metodo permite solicitar la lista de ventas y devolverla
        public List<Ventas> Listar() //Alistamos las ventas
        {
            return AccesoVentas.ObtenerVentas();
        }

        //Metodo de validaciones para la venta
        public string ValidarVenta(Ventas venta)
        {
            //Valida que la venta no este vacia
            if (venta == null)
                return "La venta no puede estar vacía.";
            
            List<Ventas> lista = AccesoVentas.ObtenerVentas(); // guardar todas las datos segun lo permitido
           
            //  Valida que cliente no este vacio
            if (venta.Clientes == null)
                return "Debe seleccionar un cliente.";
            
            //Valida que cliente este activo
            if (!venta.Clientes.Activo)
                return "El cliente está inactivo.";

            // Valida que el vendedor no este vacio
            if (venta.Vendedores == null)
                return "Debe seleccionar un vendedor.";

            // Valida que el partido no este vacio
            if (venta.Partidos == null)
                return "Debe seleccionar un partido.";

            //Valida que el partido este activo
            if (!venta.Partidos.Activo)
                return "El partido no está activo.";

            //Valida que la fecha de partido sea mayor al dia actual
            if (venta.Partidos.Fecha.Date < DateTime.Now.Date)
                return "No se pueden vender entradas de partidos pasados.";

            // valida que la localidad no este vacia
            if (venta.Localidades == null)
                return "Debe seleccionar una localidad.";

            // valida que la cantidad sea mayor a 0
            if (venta.Cantidad <= 0)
                return "La cantidad debe ser mayor a 0.";

            // valida que haya disponibilidad
            List<LocalidadesXpartido> listaLocPartido = accesoLocalidadPartido.ObtenerLocalidadXPartido();

            if (listaLocPartido == null)
                return "No hay localidades disponibles.";

            //se encarga de recorrer la lista
            for (int i = 0; i < listaLocPartido.Count; i++)
            {
                if (listaLocPartido[i] != null)
                { // verifica si hay entrdas disponibles 
                    if (listaLocPartido[i].Partido.IdPartido == venta.Partidos.IdPartido &&
                        listaLocPartido[i].Localidades.IdLocalidad == venta.Localidades.IdLocalidad)
                    {
                        //valida que haya disponiblidad
                        if (venta.Cantidad > listaLocPartido[i].CantidadDisponible)
                        {
                            return "No hay entradas disponibles.";
                        }
                        
                        listaLocPartido[i].CantidadDisponible -= venta.Cantidad; //restamos cada vez  que se compra
                        //Calculamos el monto total
                        venta.MontoTotal = venta.Cantidad * listaLocPartido[i].Localidades.Precio;
                            
                    }
                }
            }

            return string.Empty;
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
