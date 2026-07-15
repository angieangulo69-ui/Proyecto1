using Acceso;
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
Descripción: Esta clase permite agregar los registros, y realizar validaciones, segun lo solicitado.
obtener cliente y permite una conexion con mi clase de acceso a mi almacenamiento. 
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Logica
{
    public class Logica_Vendedores
    {
       private Acceso_Vendedor Acceso_Vendedor = new Acceso_Vendedor(); //Instancia de la clase Acceso_Vendedor para acceder a los métodos de la capa de acceso

        //Este metodo se encarga de agregar un nuevo vendendedor 
        public bool Agregar(Vendedores pvendedor)
        {
            string mensaje = validacionVendedor(pvendedor);

            if (!string.IsNullOrEmpty(mensaje))
            {           
                return false;
            }
            
            return Acceso_Vendedor.ingresar(pvendedor);  //guardamos en la base de datos
        }


        // Obtiene la lista de vendedores desde la capa de acceso
        public List<Vendedores> Listar() 
        { 
           return Acceso_Vendedor.ObtenerVendedores();
        }
        
        // Metodo de validaciones solicitadas
        public string validacionVendedor(Vendedores vendedor) {

            //validamos que no sea nulo
            if (vendedor == null)
                return "El vendedor es nulo.";

            //Obtenemos la lista de vendedores registrados en la capa de acceso
            List<Vendedores> lista_Vendedores = Acceso_Vendedor.ObtenerVendedores();

            //validamos que el id del vendedor sea mayor a cero
            if (vendedor.IdVendedor <= 0)
            {
                return "El ID del vendedor debe ser mayor que cero.";
            }
            
            //Validamos que no este vacio el nombre
            if (string.IsNullOrWhiteSpace(vendedor.Nombre))
                return "El nombre es obligatorio.";
            //Validamos que no este vacio el apellido
            if (string.IsNullOrWhiteSpace(vendedor.Apellido))
                return "El apellido es obligatorio.";

            //Obtenemos los datos ingresados de entidad vendedor
            DateTime fechaNacimiento = vendedor.FechaNacimiento;
            DateTime fechaIngreso = vendedor.FechaIngreso;
            DateTime hoy = DateTime.Today; //Toma la fecha del sistema


            // Validamos que la identificacion no este vacia
            if (string.IsNullOrWhiteSpace(vendedor.Identificacion))
            {
                return "La identificación es obligatoria.";
            }

            foreach (Vendedores item in lista_Vendedores)
            {
                if (item.IdVendedor == vendedor.IdVendedor)
                {
                    return "El id del vendedor ya existe";
                }

                if (item.Identificacion.Trim() == vendedor.Identificacion.Trim())
                {
                    return "La identificación del vendedor ya existe";
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
            return string.Empty; // Todo correcto
        }

        public Vendedores ObtenerVendedor(int id)
        {
            List<Vendedores> lista = Acceso_Vendedor.ObtenerVendedores();

            foreach (Vendedores vendedor in lista)
            {
                if (vendedor.IdVendedor == id)
                {
                    return vendedor;
                }
            }

            return null;
        }
        public bool TieneVendedores()
        {
            //retorna true si hay registros, false si no hay registros
            return Acceso_Vendedor.encontrar_registros();
        }
    }
}
