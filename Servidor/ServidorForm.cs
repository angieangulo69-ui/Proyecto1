
using Cliente;
using Comunicacion.TCP;
using Presentaciones;

namespace Servidor
{
    public partial class ServidorForm : Form
    {
        private ServidorTCP servidor = new ServidorTCP();
        public ServidorForm()
        {
            InitializeComponent();
           
            servidor.EventoBitacora += AgregarBitacora;
        }

        private void MostrarBitacora(string mensaje)
        {

        }

        private void ServidorForm_Load(object sender, EventArgs e)
        {

        }

        private void AgregarBitacora(string mensaje)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AgregarBitacora), mensaje);
                return;
            }

            listBoxBitacora.Items.Add($"{DateTime.Now:HH:mm:ss} - {mensaje}");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                servidor.IniciarServidor();

                btnIniciar.Enabled = false;

                MessageBox.Show(
                    "Servidor iniciado correctamente.",
                    "Servidor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Menu_Registros menu_Registros = new Menu_Registros();
                menu_Registros.Show();

                ClienteForm cliente = new ClienteForm();
                cliente.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al iniciar servidor: " + ex.Message);
            }
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
