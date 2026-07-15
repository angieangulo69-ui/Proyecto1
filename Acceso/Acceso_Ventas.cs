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
        public bool ingresar(Ventas venta)
        {
            using (var conn = conexion.ObtenerConexion())
            {
                conn.Open();
                String query = "INSERT INTO Venta ( IdCliente, IdPartido, IdLocalidad, Cantidad, IdVendedor, FechaVenta, MontoTotal, TipoVenta) VALUES " +
                    "( @IdCliente, @IdPartido, @IdLocalidad, @Cantidad, @IdVendedor, @FechaVenta, @MontoTotal, @TipoVenta)";
                using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@IdCliente", venta.Clientes.IdCliente);
                    comando.Parameters.AddWithValue("@IdPartido", venta.Partidos.IdPartido);
                    comando.Parameters.AddWithValue("@IdLocalidad", venta.Localidades.IdLocalidad);
                    comando.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
                    comando.Parameters.AddWithValue("@IdVendedor", venta.Vendedores.IdVendedor);
                    comando.Parameters.AddWithValue("@FechaVenta", venta.FechaVenta);
                    comando.Parameters.AddWithValue("@MontoTotal", venta.MontoTotal);
                    comando.Parameters.AddWithValue("@TipoVenta", venta.TipoVenta);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas == 1)
                    {
                        // ACTUALIZAR LA DISPONIBILIDAD
                        SqlCommand actualizar = new SqlCommand(
                        @"UPDATE LocalidadPorPartido
                  SET CantidadDisponible = CantidadDisponible - @Cantidad
                  WHERE IdPartido = @IdPartido
                  AND IdLocalidad = @IdLocalidad", conn);

                        actualizar.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
                        actualizar.Parameters.AddWithValue("@IdPartido", venta.Partidos.IdPartido);
                        actualizar.Parameters.AddWithValue("@IdLocalidad", venta.Localidades.IdLocalidad);

                        actualizar.ExecuteNonQuery();

                        return true;
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
                    string query = @"SELECT V.IdVenta,C.IdCliente,C.Nombre,
                             P.IdPartido,P.Rival,L.IdLocalidad,L.NombreLocalidad,L.Precio,
                             V.Cantidad,VE.IdVendedor,VE.Nombre,V.FechaVenta,V.MontoTotal,V.TipoVenta
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
                                Ventas venta = new Ventas
                                {
                                    IdVenta = reader.GetInt32(0),
                                    Clientes = new Clientes
                                    {
                                        IdCliente = reader.GetInt32(1),
                                        Nombre = reader.GetString(2)
                                    },
                                    Partidos = new Partidos
                                    {
                                        IdPartido = reader.GetInt32(3),
                                        Rival = reader.GetString(4)
                                    },
                                    Localidades = new Localidades
                                    {
                                        IdLocalidad = reader.GetInt32(5),
                                        NombreLocalidad = reader.GetString(6),
                                        Precio = reader.GetDecimal(7)
                                    },
                                    Cantidad = reader.GetInt32(8),
                                    Vendedores = new Vendedores
                                    {
                                        IdVendedor = reader.GetInt32(9),
                                        Nombre = reader.GetString(10)
                                    },
                                    FechaVenta = reader.GetDateTime(11),
                                    MontoTotal = reader.GetDecimal(12),
                                    TipoVenta = reader.GetString(13)
                                };
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
