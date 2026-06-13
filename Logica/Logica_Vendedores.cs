using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_Vendedores
    {

        Vendedores[] lista_Vendedores = Acceso.Acceso_Vendedor.Listar(); //listamos para obtener los vendedores guardados y poder validar 
        
        //Este metodo se encarga de agregar un nuevo vendendedor 
        public bool Agregar(Vendedores pvendedor)
        {
            //Validar si es nulo
            if (pvendedor == null)
            {
                return false; 
            }
            return Acceso.Acceso_Vendedor.ingresar(pvendedor);  //Envia el vendedor a la capa de acceso para guardarlo
        }
        // Obtiene la lista de vendedores desde la capa de acceso
        public Vendedores[] Listar() 
        {
            return Acceso.Acceso_Vendedor.Listar();
        }

        //Obtenemos el vendedor por medio del codigo
        public Vendedores obtenerVendedores(String codigo) {

            //Obtenemos la lista de vendedores desde la capa de acceso
            var listaVendedores = Acceso.Acceso_Vendedor.Listar();

            // Recorre la lista de vendedores para buscar el código indicado
            for (int i = 0; i < listaVendedores.Length; i++)
            {
                if (listaVendedores[i] != null && listaVendedores[i].GetIdVendedor().Equals(codigo))
                {
                    return listaVendedores[i];
                }
            }
            return null;
        }
        // Metodo de validaciones solicitadas
        public string validacionVendedor(Vendedores vendedor) {
            //validamos que no sea nulo
            if (vendedor == null)
                return "El vendedor es nulo.";
            //Validamos que no este vacio el nombre
            if (string.IsNullOrWhiteSpace(vendedor.GetNombre()))
                return "El nombre es obligatorio.";
            //Validamos que no este vacio el apellido
            if (string.IsNullOrWhiteSpace(vendedor.GetApellido()))
                return "El apellido es obligatorio.";

            //Obtenemos los datos ingresados de entidad vendedor
            DateTime fechaNacimiento = vendedor.GetFechaNacimiento();
            DateTime fechaIngreso = vendedor.GetFechaIngreso();
            DateTime hoy = DateTime.Today; //Toma la fecha del sistema

            // Validamos que la identificacion no este vacia
            if (string.IsNullOrWhiteSpace(vendedor.Identificacion))
            {
                return "La identificación es obligatoria.";
            }
        
            //Validar que no existe el mismo IDVendedor
            for (int i = 0; i < lista_Vendedores.Length; i++)
            {

                if (lista_Vendedores[i] != null) //Si la lista no esta nula entra
                {
                    if (lista_Vendedores[i].IdVendedor == vendedor.IdVendedor) // si la lista el id en la posicion i es igual, esta repetido               
                    {
                        return "El id del vendedor ya existe"; //Id repetido
                    }
                    // si la lista la identificacion en la posicion i es igual, esta repetido               
                    if (lista_Vendedores[i].Identificacion == vendedor.Identificacion)
                    {
                        return "La identificación del vendedor ya existe";  //Identificacion repetida

                    }
                }
            }


            // validadcion de Fecha de nacimiento (no debe de ser mayor o igual a la fecha actual
            if (fechaNacimiento >= hoy)
                return "La fecha de nacimiento no puede ser igual o mayor a la fecha actual.";

            // validacion de la edad mínima 18 años
            int edad = hoy.Year - fechaNacimiento.Year; //se realiza un resta para obtener la edad en base a la fecha de nacimiento y la actual
            //si la fecha de nacimiento es mayor a la actual se le resta
            if (fechaNacimiento > hoy.AddYears(-edad)) {
                edad--; }

            if (edad < 18)
            {
                return "El vendedor debe tener al menos 18 años.";
            }

            //si la fecha de ingreso es menor a la fecha de nacimiento 
            if (fechaIngreso < fechaNacimiento) { 
            return "La fecha de ingreso no puede ser menor que la fecha de nacimiento.";
             }
            //si la fecha de ingreso es mayor a hoy 
            if (fechaIngreso > hoy)
            {
                return "La fecha de ingreso no puede ser mayor a la fecha actual.";
            }
            return ""; // Todo correcto
        }
        
      
        public bool TieneVendedores()
        {
            //retorna true si hay registros, false si no hay registros
            return Acceso.Acceso_Vendedor.encontrar_registros();
        }
    }
}
