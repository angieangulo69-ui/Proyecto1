using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_Clientes
    {
        
        public bool Agregar(Clientes pclientes)
        {
            string mensaje = validacionesCliente(pclientes);

            if (!string.IsNullOrEmpty(mensaje))
            {
                return false;
            }

            return Acceso.AccesoCliente.ingresar(pclientes);
        }

        //Obtenemos la lista de clientes desde la capa acceso
        public Clientes[] Listar()
        {
            return Acceso.AccesoCliente.Listar();

        }
        //Buscar clciente por id
        public Clientes obtenerClientes(int codigo)
        {
            var listaClientes = Acceso.AccesoCliente.Listar();

            //Recorremos la lista de clientes para buscar el codigo indicado
            for (int i = 0; i < listaClientes.Length; i++)
            {
                if (listaClientes[i] != null && listaClientes[i].IdCliente.Equals(codigo))
                {
                    return listaClientes[i];
                }
            }
            return null;
        }

        //Metodo de validaciones 
        public string validacionesCliente(Clientes clientes) {
            if (clientes == null)
            {
                return "El cliente no puede estar vacio.";
            }

            //validacion heredada de Persona
            if (String.IsNullOrWhiteSpace(clientes.Nombre))
            {
                return "Debe ingresar el nombre";
            }

            if (String.IsNullOrWhiteSpace(clientes.Apellido))
            {
                return "Debe ingresar el apellido";
            }
            if (String.IsNullOrWhiteSpace(clientes.Identificacion))
            {
                return "Debe ingresar la identificacion";
            }

            if (clientes.FechaNacimiento >=  DateTime.Now)
            {
                return "La fecha de nacimiento no puede ser futura";
            }

            //Validaciones de cliente 
            //Valida que el id del cliente sea mayor a cero
            if (clientes.IdCliente <= 0)
            {
                return "El ID del cliente debe de ser mayor que cero";
            }

            //Valia que le fecha de registro mo se mayor a la actual
            if(clientes.FechaRegistro > DateTime.Now)
            {
                return "La fecha de registro no puede ser mayor a la actual";
                    
            }
            //Si el cliente no esta activo

            if (!clientes.Activo)
            {
                return "Debe indicar si el cliente se encuentra activo.";
            }


            //Valida identificacion repetida
            //Validar que no existe el mismo IDVendedor

            Clientes[] lista_Clientes = Acceso.AccesoCliente.Listar();

            for (int i = 0; i < lista_Clientes.Length; i++)
            {

                if (lista_Clientes[i] != null) //Si la lista no esta nula entra
                {
                    if (lista_Clientes[i].IdCliente == clientes.IdCliente) // si la lista el id en la posicion i es igual, esta repetido               
                    {
                        return "El id del cliente ya existe"; //Id repetido
                    }

                    // si la lista la identificacion en la posicion i es igual, esta repetido               
                    if (lista_Clientes[i].Identificacion.Trim() == clientes.Identificacion.Trim())
                    {
                        return "La identificación del cliente ya existe";  //Identificacion repetida

                    }
                    //Valida que el cliente sea mayor de edad
                    int edad = DateTime.Now.Year - clientes.FechaNacimiento.Year;

                    if (clientes.FechaNacimiento > DateTime.Now.AddYears(-edad))
                    {
                        edad--;
                    }

                    if (edad < 18)
                    {
                        return "El cliente debe ser mayor de edad";
                    }
                }
            }
            return string.Empty; //nos retorna una cena vacia

        }
        public bool ClienteHabilitado(int idCliente)
        {
            Clientes cliente = obtenerClientes(idCliente);

            if (cliente == null)
            {
                return false;
            }

            return cliente.Activo;
        }


         /*if (!logicaCliente.ClienteHabilitado(idCliente))
{
            MessageBox.Show("El cliente se encuentra inactivo y no puede realizar compras.","Cliente no habilitado",MessageBoxButtons.OK, MessageBoxIcon.Warning);

    return;
}*/

        public bool TieneClientes()
        {
            //retorna true si hay registros, false si no hay registros
            return Acceso.AccesoCliente.encontrar_registro();
        }
    }

}
    

