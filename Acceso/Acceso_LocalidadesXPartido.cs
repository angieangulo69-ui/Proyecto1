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
Descripción: Esta clase administra el almacenamiento y acceso de los registros
de Localidades por Partido. Permite agregar, listar y verificar la existencia
de registros utilizando un arreglo de objetos como  almacenamiento.
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/

namespace Acceso
{
    public class Acceso_LocalidadesXPartido
    {
        private Conexion conexion = new Conexion();

        //Booleano para controlar el ingreso de registros
        public bool ingresar(LocalidadesXpartido localidadesXpartido) //clase y objeto
        {
            using (var conn = new Conexion().ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO LocalidadPorPartido (IdLocalidadPartido,IdPartido, IdLocalidad, CantidadDisponible) " +
                               "VALUES (@IdLocalidadPartido, @IdPartido, @IdLocalidad, @CantidadDisponible)";
                // Se utiliza un comando SQL parametrizado para evitar inyecciones SQL y asegurar la integridad de los datos.
                using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@IdLocalidadPartido", localidadesXpartido.IdLocalidadPartido);
                    comando.Parameters.AddWithValue("@IdPartido", localidadesXpartido.Partido.IdPartido); //
                    comando.Parameters.AddWithValue("@IdLocalidad", localidadesXpartido.Localidades.IdLocalidad);
                    comando.Parameters.AddWithValue("@CantidadDisponible", localidadesXpartido.CantidadDisponible);

                    //Verifica si se guardo correctamente la localidad en la base de datos
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas == 1)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception("No se pudo insertar la localidad por partido.");

                    }
                }

            }
        }


        public List<LocalidadesXpartido> ObtenerLocalidadXPartido()
        {
            List<LocalidadesXpartido> localidadesXpartido = new List<LocalidadesXpartido>();
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = @"SELECT
                      LP.IdLocalidadPartido,
                      P.IdPartido,P.Rival, P.Fecha,P.Hora, P.Activo,
                      L.IdLocalidad,L.NombreLocalidad,L.Precio,
                      LP.CantidadDisponible
                     FROM LocalidadPorPartido LP
                     INNER JOIN Partido P
                     ON LP.IdPartido = P.IdPartido
                     INNER JOIN Localidad L
                    ON LP.IdLocalidad = L.IdLocalidad"; ;

                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LocalidadesXpartido localidadPorpartido = new LocalidadesXpartido
                                {
                                    IdLocalidadPartido = reader.GetInt32(0),
                                    // Se crean instancias de las clases Partidos y
                                    // Localidades para almacenar los datos obtenidos de la base de datos.
                                    Partido = new Partidos
                                    {
                                        IdPartido = reader.GetInt32(1),
                                        Rival = reader.GetString(2),
                                        Fecha = reader.GetDateTime(3),
                                        Hora = reader.GetString(4),
                                        Activo = reader.GetBoolean(5)
                                    },

                                    // Se crean instancias de las clases Partidos y
                                    // Localidades para almacenar los datos obtenidos de la base de datos.
                                    Localidades = new Localidades
                                    {
                                        IdLocalidad = reader.GetInt32(6),
                                        NombreLocalidad = reader.GetString(7),
                                        Precio = reader.GetDecimal(8)
                                    },

                                    CantidadDisponible = reader.GetInt32(9)
                                };
                                localidadesXpartido.Add(localidadPorpartido);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener localidades: " + ex.Message, ex);
            }
            return localidadesXpartido;
        }

        public bool ActualizarCantidadDisponible(int idLocalidadPartido, int cantidadDisponible)
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"UPDATE LocalidadPorPartido
                             SET CantidadDisponible = @CantidadDisponible
                             WHERE IdLocalidadPartido = @IdLocalidadPartido";

                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@CantidadDisponible", cantidadDisponible);
                        comando.Parameters.AddWithValue("@IdLocalidadPartido", idLocalidadPartido);

                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la cantidad disponible: " + ex.Message);
            }
        }

        public bool encontrar_registros()
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM LocalidadPorPartido";

                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        int cantidad = (int)comando.ExecuteScalar();
                        return cantidad > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar registros.", ex);
            }
        }

        public LocalidadesXpartido ObtenerLocalidadXPartido(int idPartido, int idLocalidad)
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"SELECT
                    LP.IdLocalidadPartido,
                    P.IdPartido,P.Rival,P.Fecha,P.Hora,P.Activo,
                    L.IdLocalidad,L.NombreLocalidad,L.Precio,
                    LP.CantidadDisponible
                FROM LocalidadPorPartido LP
                INNER JOIN Partido P
                    ON LP.IdPartido = P.IdPartido
                INNER JOIN Localidad L
                    ON LP.IdLocalidad = L.IdLocalidad
                WHERE LP.IdPartido = @IdPartido
                  AND LP.IdLocalidad = @IdLocalidad";

                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@IdPartido", idPartido);
                        comando.Parameters.AddWithValue("@IdLocalidad", idLocalidad);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new LocalidadesXpartido
                                {
                                    IdLocalidadPartido = reader.GetInt32(0),

                                    Partido = new Partidos
                                    {
                                        IdPartido = reader.GetInt32(1),
                                        Rival = reader.GetString(2),
                                        Fecha = reader.GetDateTime(3),
                                        Hora = reader.GetString(4),
                                        Activo = reader.GetBoolean(5)
                                    },

                                    Localidades = new Localidades
                                    {
                                        IdLocalidad = reader.GetInt32(6),
                                        NombreLocalidad = reader.GetString(7),
                                        Precio = reader.GetDecimal(8)
                                    },

                                    CantidadDisponible = reader.GetInt32(9)
                                };
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la localidad del partido: " + ex.Message);
            }
        }

    }
}
