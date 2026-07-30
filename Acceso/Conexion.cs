 using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso
{
    public class Conexion
    {
        // Variable para almacenar la cadena de conexión
        private string cadenaConexion;

        // Constructor que obtiene la cadena de conexión desde el archivo App.config
        public Conexion()
        {
            var conn = ConfigurationManager.ConnectionStrings["conexion"];

            if (conn == null)
                throw new Exception("No se encontró la cadena de conexión en App.config");

            cadenaConexion = conn.ConnectionString;
        }

        //Permite obtener la conexión a la base de datos
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}

