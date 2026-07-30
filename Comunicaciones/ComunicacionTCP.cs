using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Comunicaciones
{
    public class ComunicacionTCP
    {
        private TcpListener tcpListener; //escucha conexiones 
        private bool servidorIniciado;

        //Delegado genérico predefinido que se utiliza comúnmente para manejar eventos
        public event EventHandler<(string mensaje, StreamWriter streamWriter)> MensajeRecibido;

        public ComunicacionTCP()
        {
            // Configurar la comunicación TCP (asi se permite la conexion desde otras compus
            tcpListener = new TcpListener(System.Net.IPAddress.Any, 14500);
        }
        public void Iniciar()
        {
            servidorIniciado = true;
            tcpListener.Start();

            // Iniciar un hilo para escuchar clientes
            var subprocesoEscuchaClientes = new Thread(EscucharClientes);
            subprocesoEscuchaClientes.IsBackground = true;
            subprocesoEscuchaClientes.Start();
        }

        public void Detener()
        {
            servidorIniciado = false;
            tcpListener.Stop();
        }

        private void EscucharClientes()
        {
            while (servidorIniciado)
            {
                try
                {
                    var client = tcpListener.AcceptTcpClient();
                    var clientThread = new Thread(ComunicacionCliente);
                    clientThread.Start(client);
                }
                catch (SocketException)
                {
                    // SocketException se lanza cuando se detiene el servidor, no es necesario manejarlo
                }
            }
        }
        // Método para manejar la comunicación con un cliente
        private void ComunicacionCliente(object cliente)
        {
            var tcpClient = (TcpClient)cliente; // Convertir el objeto a TcpClient
            var reader = new StreamReader(tcpClient.GetStream()); //leer datos del cliente
            var writer = new StreamWriter(tcpClient.GetStream()) { AutoFlush = true }; //escribir datos al cliente


            while (servidorIniciado)
            {
                try
                {
                    var mensaje = reader.ReadLine();

                    if (mensaje == null)
                    {
                        break;
                    }
                    //
                    MensajeRecibido?.Invoke(this, (mensaje, writer));
                }
                catch (IOException)
                {
                    // IOException se lanza cuando se desconecta el cliente, no es necesario manejarlo
                    break;
                }
            }

            try
            {
                tcpClient.Close();
            }
            catch // se deja vacio porque
            {

            }
        }
    }
}


      

