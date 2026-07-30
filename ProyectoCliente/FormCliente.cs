using Aspose.Pdf.Operators;
using Comunicaciones;
using Entidades;
using Presentaciones.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCliente
{
    public partial class FormCliente : Form
    {
        private Cliente clienteActual;
        private ClienteTCP comunicacion;

        public FormCliente(Cliente cliente, ClienteTCP tcp)
        {
            InitializeComponent();
            clienteActual = cliente;
            comunicacion = tcp;

            lbl_Mensaje.Text = "Bienvenido: " + clienteActual.Nombre + " " + clienteActual.Apellido;
        }

        private void btnCompraboletos_Click(object sender, EventArgs e)
        {
            Boleteria Boleteriaventas = new Boleteria(clienteActual, comunicacion);
            Boleteriaventas.Show();
            this.Hide();

        }

        private void btn_consultaboletos_Click(object sender, EventArgs e)
        {
            Consulta_Ventas consulta = new Consulta_Ventas();
            consulta.Show();
            this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                MensajeSocket<string> mensaje = new MensajeSocket<string>(); ;

                mensaje.Metodo = "Desconectar";
                mensaje.Entidad = clienteActual.Identificacion;

            }
            catch (Exception ex)
            {
                MessageBox.Show( "Error al desconectarse.\n" + ex.Message);
            }

            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
