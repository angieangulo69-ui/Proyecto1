using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciones.Registros
{
    public partial class Registro_Vendedores : Form
    {
        public Registro_Vendedores()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            //Obtenemos datos
            String nombre = txt_nombre.Text.Trim();
            String apellido = txt_apellido.Text.Trim();
            String identificacion = mask_identificacion.Text.Trim();

            DateTime fechaingreso = date_fechaingreso.Value.Date;
            DateTime fechanacimiento = date_fechanacimiento.Value.Date;


            Registro_Vendedores vendedor = new Registro_Vendedores(); //Creamos un objeto

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu_Registros ventana_registros = new Menu_Registros();
            ventana_registros.Show();
            Dispose();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void limpiar()
        {
            txt_apellido.Text = "";
            txt_idvendedor.Text = "";
            txt_nombre.Text = "";

        }
    }
}
