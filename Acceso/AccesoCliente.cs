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
Descripción: Esta clase permite acceder al registro de clientes , permite verificar si hay registros. 
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Acceso
{
    public class AccesoCliente
    {
        //Mi arreglo para almacenamiento
        private Conexion conexion = new Conexion();

        //Booleano para controlar el ingreso de datos
        public bool ingresar(Clientes cliente)
        {
            using (var conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Cliente (IdCliente,Identificacion, Nombre, Apellido, FechaNacimiento, FechaRegistro,Activo) " +
                    "   VALUES (@IdCliente, @Identificacion, @Nombre, @Apellido, @FechaNacimiento, @FechaRegistro, @Activo)";
                using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                    comando.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                    comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                    comando.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                    comando.Parameters.AddWithValue("@FechaRegistro", cliente.FechaRegistro);
                    comando.Parameters.AddWithValue("@Activo", cliente.Activo);

                    //Validamos que se haya insertado correctamente
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas == 1)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception("No se pudo insertar el cliente.");
                    }
                }
            }
        }
        //lista de clientes
        public List<Clientes> ObtenerClientes()
        {
            List<Clientes> lista_Clientes = new List<Clientes>();
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT IdCliente, Identificacion, Nombre, Apellido, FechaNacimiento, FechaRegistro, Activo FROM Cliente";

                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Clientes cliente = new Clientes
                                {
                                    IdCliente = reader.GetInt32(0),
                                    Identificacion = reader.GetString(1),
                                    Nombre = reader.GetString(2),
                                    Apellido = reader.GetString(3),
                                    FechaNacimiento = reader.GetDateTime(4),
                                    FechaRegistro = reader.GetDateTime(5),
                                    Activo = reader.GetBoolean(6)
                                };
                                lista_Clientes.Add(cliente);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clientes: " + ex.Message, ex);
            }
            return lista_Clientes;
        }

        public bool encontrar_registro()
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Cliente";
                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        int cantidadRegistros = (int)comando.ExecuteScalar();
                        return cantidadRegistros > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar registros: " + ex.Message, ex);
            }
        }
    }    
}

