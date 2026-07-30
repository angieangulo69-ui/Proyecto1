using Aspose.Pdf.Operators;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Comunicaciones 
{ 
    public class ClienteTCP
    {
        private TcpClient cliente;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;

        //Conecta con el servidor TCP en la dirección IP y puerto especificados
        public void Conectar(string ip, int puerto)
        {
            try
            {
                cliente = new TcpClient();
                cliente.Connect(ip,puerto);
                stream = cliente.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream){AutoFlush = true} ;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo conectar al servidor: " + ex.Message);
            }
        }
        //Envía un mensaje al servidor y recibe la respuesta
        public string Enviar<T>(MensajeSocket<T> mensaje)
        {
            try
            {
                if(cliente == null || !cliente.Connected)
{
                    throw new Exception("No existe conexión con el servidor.");
                }
                string json = JsonConvert.SerializeObject(mensaje);
                writer.WriteLine(json);
                
                string respuesta = reader.ReadLine();
                if (respuesta == null)
                {
                    throw new Exception("El servidor cerró la conexión.");
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error de comunicación con el servidor: " + ex.Message);
            }
        }
        //Cierra la conexión con el servidor
        public void Desconectar()
        {
            reader?.Close();
            writer?.Close();
            stream?.Close();
            cliente?.Close();

            cliente = null;
            stream = null;
            reader = null;
            writer = null;
        }

        public bool EstaConectado()
        {
            return cliente != null && cliente.Connected;
        }
    }

}
