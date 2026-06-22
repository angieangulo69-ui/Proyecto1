using Entidades;
using System;
using System.Collections.Generic;
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
        //Metodo que permite agregar las ventas registradas en acceso de datos, simpre y cuando 
        // se cumplan las validaciones 
        public bool Agregar(Ventas venta)
        {           
            string mensaje = ValidarVenta(venta);
       
            if (!string.IsNullOrEmpty(mensaje))
                return false;

            return Acceso.Acceso_Ventas.ingresar(venta);
        }
        //Metodo permite solicitar la lista de ventas y devolverla
        public Ventas[] Listar() //Alistamos las ventas
        {
            return Acceso.Acceso_Ventas.Listar();
        }

        //Metodo de validaciones para la venta
        public string ValidarVenta(Ventas venta)
        {
            //Valida que la venta no este vacia
            if (venta == null)
                return "La venta no puede estar vacía.";
            
            Ventas[] lista = Acceso.Acceso_Ventas.Listar(); // guardar todas las datos segun lo permitido
            
            // Valida que el id de venta sea única
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] != null && lista[i].IdVenta == venta.IdVenta)
                {
                    if (lista[i].IdVenta == venta.IdVenta)
                        return "El ID de la venta ya existe.";
                }
            }

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
            var listaLocPartido = Acceso.Acceso_LocalidadesXPartido.Listar();

            if (listaLocPartido == null)
                return "No hay localidades disponibles.";

            //se encarga de recorrer la lista
            for (int i = 0; i < listaLocPartido.Length; i++)
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
            //Llamamos a la capa de acceso para verificar si hay registros de partidos
            return Acceso.Acceso_Ventas.encontrar_registros();
        }


    }
}
