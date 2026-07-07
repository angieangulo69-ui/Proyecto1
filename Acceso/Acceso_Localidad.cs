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
Descripción: Esta clase permite el acceso a las localidades registradas en la base de datos de Localidad en este caso
la identidad, tambien permite validar si hay registros 
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/

namespace Acceso
{
    public class Acceso_Localidad
    {
        private Conexion conexion = new Conexion();

        //metodo para registrar una nueva localidad
        public bool ingresar(Localidades localidades) //clase y objeto
        {
            using (var conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Localidad (IdLocalidad, NombreLocalidad, Precio) " +
                               "VALUES (@IdLocalidad, @NombreLocalidad, @Precio)";
                // Se utiliza un comando SQL parametrizado para evitar inyecciones SQL y asegurar la integridad de los datos.
                using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@IdLocalidad", localidades.IdLocalidad);
                    comando.Parameters.AddWithValue("@NombreLocalidad", localidades.NombreLocalidad);
                    comando.Parameters.AddWithValue("@Precio", localidades.Precio);

                    //Verifica si se guardo correctamente la localidad en la base de datos
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas == 1)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception("No se pudo insertar la localidad a registrar.");
                       
                    }
                }

            }
        }    
        public List <Localidades> ObtenerLocalidades()
        {
            List<Localidades> localidades = new List<Localidades>();
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT IdLocalidad, NombreLocalidad, Precio FROM Localidad";
                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Localidades localidad = new Localidades
                                {
                                    IdLocalidad = reader.GetInt32(0),
                                    NombreLocalidad = reader.GetString(1),
                                    Precio = reader.GetDecimal(2)
                                };
                                localidades.Add(localidad);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener localidades: " + ex.Message, ex);
            }
            return localidades;
        }

        public bool encontrar_registros()
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Localidad";
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
