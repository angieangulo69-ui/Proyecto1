using Comunicaciones;
using Entidades;
using Newtonsoft.Json;
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
    public partial class LoginCliente : Form
    {
        private ClienteTCP clienteTCP = new ClienteTCP();
        public LoginCliente()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string identificacion = txt_identificacion.Text.Trim();

                if (string.IsNullOrEmpty(identificacion))
                {
                    MessageBox.Show(
                        "Ingrese la identificación");
                    return;
                }
                if (identificacion.Length < 5)
                {
                    MessageBox.Show("La identificación no es válida.");
                    txt_identificacion.Focus();
                    return;
                }
                // 
                MensajeSocket<string> solicitud = new MensajeSocket<string>();
                solicitud.Metodo = "ValidarCliente";
                solicitud.Entidad = identificacion;

                // enviar la solicitud al servidor
                string respuestaJSON = clienteTCP.Enviar(solicitud);

                //Convertir la respuesta recibida
                MensajeSocket<object> respuesta = JsonConvert.DeserializeObject<MensajeSocket<object>>(respuestaJSON);

                if (respuesta.Metodo == "OK")
                {
                    Cliente cliente =JsonConvert.DeserializeObject<Cliente>(JsonConvert.SerializeObject(respuesta.Entidad));

                    MessageBox.Show( "Bienvenido " + cliente.Nombre);

                    // Abrir pantalla de clientes
                    FormCliente formulario =  new FormCliente(cliente, clienteTCP);
                    formulario.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show(respuesta.Entidad.ToString(),"Validación incorrecta",MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginCliente_Load(object sender, EventArgs e)
        {
            try
            {
                clienteTCP.Conectar("127.0.0.1", 14500);

                lbl_Mensaje.Text = "Conectado al servidor";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
