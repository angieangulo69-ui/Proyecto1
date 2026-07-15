using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
/*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción: Esta clase permite acceder al registro de vendedores , permite verificar si hay registros. 
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Acceso
{
    public class Acceso_Vendedor
    {
        //Mi arreglo para almacenamiento
        private Conexion conexion = new Conexion();

        //Booleado pára controlar el ingreso de vendedores registrados
        public bool ingresar(Vendedores vendedores) //Clase objeto
        {
            using (var conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Vendedor (IdVendedor,Identificacion, Nombre, Apellido, FechaNacimiento, FechaIngreso) " +
                    "   VALUES (@IdVendedor, @Identificacion, @Nombre, @Apellido, @FechaNacimiento, @FechaIngreso)";
                using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@IdVendedor", vendedores.IdVendedor);
                    comando.Parameters.AddWithValue("@Identificacion", vendedores.Identificacion);
                    comando.Parameters.AddWithValue("@Nombre", vendedores.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", vendedores.Apellido);
                    comando.Parameters.AddWithValue("@FechaNacimiento", vendedores.FechaNacimiento);
                    comando.Parameters.AddWithValue("@FechaIngreso", vendedores.FechaIngreso);
                   
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas == 1)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception("No se pudo insertar el vendedor.");
                    }
                }
            }
        }

        public List<Vendedores> ObtenerVendedores()
        {
            List<Vendedores> lista_Vendedores = new List<Vendedores>();
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT IdVendedor, Identificacion, Nombre, Apellido, FechaNacimiento, FechaIngreso FROM Vendedor";
                    
                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Vendedores vendedor = new Vendedores
                                {
                                    IdVendedor = reader.GetInt32(0),
                                    Identificacion = reader.GetString(1),
                                    Nombre = reader.GetString(2),
                                    Apellido = reader.GetString(3),
                                    FechaNacimiento = reader.GetDateTime(4),
                                    FechaIngreso = reader.GetDateTime(5)
                                };
                                lista_Vendedores.Add(vendedor);
                            }
                        }
                    }
                }              
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener vendedores: " + ex.Message, ex);
            }
            return lista_Vendedores;
        }

        public bool encontrar_registros()
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Vendedor";
                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        int count = (int)comando.ExecuteScalar();
                        return count > 0; // Retorna true si hay registros, false si no hay
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
