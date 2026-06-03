using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            MenuRegistrar ventana_registar = new MenuRegistrar();
            ventana_registar.Show();

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            MenuConsulta ventana_consulta = new MenuConsulta();
            ventana_consulta.Show();
        }
    }
}
