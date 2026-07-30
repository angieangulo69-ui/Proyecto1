using Comunicacion.Modelos;
using Comunicacion.TCP;

namespace Cliente
{
    public partial class ClienteForm : Form
    {
        private ClienteTCP cliente = new ClienteTCP();
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cliente.Conectar("127.0.0.1", 5000))
            {
                Solicitud solicitud = new Solicitud
                {
                    Operacion = Operacion.Login,
                    Datos = null
                };

                Respuesta respuesta = cliente.EnviarYRecibir(solicitud);

                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                MessageBox.Show("No fue posible conectar con el servidor.");
            }
        }
    }
}
