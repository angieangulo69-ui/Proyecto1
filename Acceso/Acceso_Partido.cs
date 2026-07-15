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
Descripción: Esta clase permite acceder a los partidos registrados y verificar si hay registros en la clase
de partido
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Acceso
{
    public class Acceso_Partido
    {

        private Conexion conexion = new Conexion(); // 
        public bool ingresar(Partidos partido)
        {
            using (var conn = new Conexion().ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Partido(IdPartido, Rival, Fecha, Hora,Activo) " +
                               "VALUES(@IdPartido, @Rival, @Fecha, @Hora, @Activo)";
                using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@IdPartido", partido.IdPartido);
                    comando.Parameters.AddWithValue("@Rival", partido.Rival);
                    comando.Parameters.AddWithValue("@Fecha", partido.Fecha);
                    comando.Parameters.AddWithValue("@Hora", partido.Hora);
                    comando.Parameters.AddWithValue("@Activo", partido.Activo);

                    //Verificar si se guarda correctamente el partido en la base de datos
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas == 1)
                    {
                        return true; // Se guardó correctamente
                    }
                    else
                    {
                        throw new Exception("No se pudo insertar el partido.");
                    }
                }

            }
        }
        public List<Partidos> ObtenerPartidos() // Método para listar los partidos
        {
            List<Partidos> Partidos = new List<Partidos>();
            try
            {
                using(var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT IdPartido, Rival, Fecha, Hora, Activo FROM Partido";
                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Partidos partido = new Partidos
                                {
                                    IdPartido = reader.GetInt32(0),
                                    Rival = reader.GetString(1),
                                    Fecha = reader.GetDateTime(2),
                                    Hora = reader.GetString(3),
                                    Activo = reader.GetBoolean(4)
                                };
                                Partidos.Add(partido);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los partidos: " + ex.Message);
            }
            return Partidos;
        }
        //Metodo que permite validar por medio del bool si hay  registros 
        public  bool encontrar_registros()
        {
            try
            {
                using(var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Partido";
                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        int count = (int)comando.ExecuteScalar();
                        return count > 0; // Retorna true si hay registros, false si no hay registros
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar registros de partidos: " + ex.Message);

            }
            
        }

    }
}
