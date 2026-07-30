/*
Universidad: UNED
II Cuatrimestre
Proyecto I
Descripción: Esta clase permite agregar los registros, y realizar validaciones,
según lo solicitado. Obtener cliente y permite una conexión con la clase de
acceso a datos.
Estudiante: Angie Angulo Chacón
Fecha: 21/06/2026
*/
using Acceso;
using Entidades;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class Logica_Clientes
    {
        // Permite agregar clientes a la clase correspondiente
        private AccesoCliente Acceso = new AccesoCliente();

        // Agrega un cliente luego de validarlo por completo.
        // Retorna string.Empty si todo salió bien, o un mensaje de error específico.
        public string Agregar(Cliente pCliente)
        {
            try
            {
                // Ejecuta TODAS las validaciones (formato, negocio y duplicados)
                string error = ValidacionesCliente(pCliente);
                if (!string.IsNullOrEmpty(error))
                {
                    return error;
                }

                bool registrado = Acceso.ingresar(pCliente);
                return registrado ? string.Empty : "No se pudo registrar el cliente.";
            }
            catch (Exception ex)
            {
                return "Error al agregar cliente: " + ex.Message;
            }
        }

        // Obtiene la lista de clientes desde la capa de acceso
        public List<Cliente> Listar()
        {
            try
            {
                return Acceso.ObtenerClientes();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar clientes: " + ex.Message);
            }
        }

        // Busca un cliente por su Id
        public Cliente ObtenerClientePorId(int codigo)
        {
            try
            {
                List<Cliente> listaClientes = Acceso.ObtenerClientes();

                foreach (Cliente cliente in listaClientes)
                {
                    if (cliente.IdCliente.Equals(codigo))
                    {
                        return cliente;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cliente por Id: " + ex.Message);
            }
        }

        // Permite obtener un cliente por su identificación
        public Cliente ObtenerPorIdentificacion(string identificacion)
        {
            try
            {
                List<Cliente> lista = Acceso.ObtenerClientes();

                foreach (Cliente cliente in lista)
                {
                    if (cliente.Identificacion.Trim() == identificacion.Trim())
                    {
                        return cliente;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cliente por identificación: " + ex.Message);
            }
        }

        // Permite controlar si hay clientes registrados
        public bool TieneClientes()
        {
            try
            {
                // Retorna true si hay registros, false si no hay registros
                return Acceso.EncontrarRegistro();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar clientes existentes: " + ex.Message);
            }
        }

        // Método único de validaciones: formato + reglas de negocio + duplicados
        public string ValidacionesCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                return "El cliente no puede estar vacío.";
            }

            // Validación heredada de Persona
            if (String.IsNullOrWhiteSpace(cliente.Nombre))
            {
                return "Debe ingresar el nombre.";
            }

            // Valida que no quede en blanco el apellido
            if (String.IsNullOrWhiteSpace(cliente.Apellido))
            {
                return "Debe ingresar el apellido.";
            }

            // Valida que no quede en blanco la identificación
            if (String.IsNullOrWhiteSpace(cliente.Identificacion))
            {
                return "Debe ingresar la identificación.";
            }

            // La fecha de nacimiento no puede ser futura
            if (cliente.FechaNacimiento >= DateTime.Now)
            {
                return "La fecha de nacimiento no puede ser futura.";
            }

            // El Id del cliente debe ser mayor a cero
            if (cliente.IdCliente <= 0)
            {
                return "El ID del cliente debe ser mayor que cero.";
            }

            // La fecha de registro no puede ser mayor a la actual
            if (cliente.FechaRegistro > DateTime.Now)
            {
                return "La fecha de registro no puede ser mayor a la actual.";
            }

            // Valida que el cliente sea mayor de edad
            int edad = DateTime.Now.Year - cliente.FechaNacimiento.Year;
            if (cliente.FechaNacimiento > DateTime.Now.AddYears(-edad))
            {
                edad--;
            }
            if (edad < 18)
            {
                return "El cliente debe ser mayor de edad.";
            }

            try
            {
                // Valida que no exista el mismo Id o la misma identificación
                List<Cliente> listaCliente = Acceso.ObtenerClientes();

                foreach (Cliente item in listaCliente)
                {
                    // Evita comparar el cliente consigo mismo en un futuro escenario de edición
                    if (item.IdCliente == cliente.IdCliente)
                    {
                        return "El ID del cliente ya existe.";
                    }

                    if (item.Identificacion.Trim() == cliente.Identificacion.Trim())
                    {
                        return "La identificación del cliente ya existe.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error al validar duplicados: " + ex.Message;
            }

            // Si todas las validaciones pasan
            return string.Empty;
        }
    }
}