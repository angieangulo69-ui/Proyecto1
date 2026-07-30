using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
/*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción: permite el acceso a los datos registrados
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Acceso
{
    public class Acceso_Ventas
    {
        //Mi arreglo para almacenamiento
        private Conexion conexion = new Conexion();

        //Booleano para controlar el ingreso de datos
        public bool Ingresar(Ventas venta)
        {
            using (var conn = conexion.ObtenerConexion())
            {
                conn.Open();
                String query = "INSERT INTO Venta ( IdCliente, IdPartido, IdLocalidad, Cantidad, IdVendedor, FechaVenta, MontoTotal, TipoVenta) VALUES " +
                    "( @IdCliente, @IdPartido, @IdLocalidad, @Cantidad, @IdVendedor, @FechaVenta, @MontoTotal, @TipoVenta)";
                using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@IdCliente", venta.Cliente.IdCliente);
                    comando.Parameters.AddWithValue("@IdPartido", venta.Partidos.IdPartido);
                    comando.Parameters.AddWithValue("@IdLocalidad", venta.Localidades.IdLocalidad);
                    comando.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
                    // 
                    if (venta.Vendedores == null)
                        comando.Parameters.AddWithValue("@IdVendedor", DBNull.Value);
                    else
                        comando.Parameters.AddWithValue("@IdVendedor", venta.Vendedores.IdVendedor);

                    comando.Parameters.AddWithValue("@FechaVenta", venta.FechaVenta);
                    comando.Parameters.AddWithValue("@MontoTotal", venta.MontoTotal);
                    comando.Parameters.AddWithValue("@TipoVenta", venta.TipoVenta);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas == 1)
                    {
                    
                        return filasAfectadas==1;
                    }
                    else
                    {
                        throw new Exception("No se pudo insertar la venta.");
                    }
                }

            }
        }
        //lista de ventas
        public List<Ventas> ObtenerVentas()
        {
            List<Ventas> ventas = new List<Ventas>();
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = @"SELECT 
                               V.IdVenta,
                              C.IdCliente,C.Nombre,
                              P.IdPartido,P.Rival, P.Fecha, P.Hora, P.Activo,
                              L.IdLocalidad,L.NombreLocalidad,L.Precio,
                              V.Cantidad,
                              VE.IdVendedor,VE.Nombre,
                              V.FechaVenta,V.MontoTotal,V.TipoVenta

                            FROM Venta V
                            INNER JOIN Cliente C ON V.IdCliente = C.IdCliente
                            INNER JOIN Partido P ON V.IdPartido = P.IdPartido
                            INNER JOIN Localidad L ON V.IdLocalidad = L.IdLocalidad
                            INNER JOIN Vendedor VE ON V.IdVendedor = VE.IdVendedor";

                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Ventas venta = new Ventas();

                                venta.IdVenta = reader.GetInt32(0);

                               venta.Cliente = new Cliente
                                {
                                        IdCliente = reader.GetInt32(1),
                                        Nombre = reader.GetString(2),
                                        Apellido = reader.GetString(3)
                                };

                                venta.Partidos = new Partidos
                                {
                                    IdPartido = reader.GetInt32(4),
                                    Rival = reader.GetString(5),
                                    Fecha = reader.GetDateTime(6),
                                    Hora = reader.GetString(7),
                                    Activo = reader.GetBoolean(8)
                                };
                                venta.Localidades = new Localidades
                                {
                                    IdLocalidad = reader.GetInt32(9),
                                    NombreLocalidad = reader.GetString(10),
                                    Precio = reader.GetDecimal(11)
                                };

                                venta.Cantidad = reader.GetInt32(12);
                                //
                                if (reader.IsDBNull(13))
                                {
                                    venta.Vendedores = null;
                                }
                                else
                                {
                                    venta.Vendedores = new Vendedores
                                    {
                                        IdVendedor = reader.GetInt32(13),
                                        Nombre = reader.GetString(14)
                                    };
                                }

                                venta.FechaVenta = reader.GetDateTime(15);
                                venta.MontoTotal = reader.GetDecimal(16);
                                venta.TipoVenta = reader.GetString(17);
                               
                                ventas.Add(venta);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las ventas: " + ex.Message);
            }
            return ventas;
        }
        //Metodo permite encontrar si hay registros
        public static bool encontrar_registros()
        {
            try
            {
                using (var conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    SqlCommand comando =new SqlCommand("SELECT COUNT(*) FROM Venta", conn);

                    return (int)comando.ExecuteScalar() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar registros de ventas: " + ex.Message);
            }
        }
    }
    
}
