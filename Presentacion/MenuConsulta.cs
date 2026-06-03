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
    public partial class MenuConsulta : Form
    {
        public MenuConsulta()
        {
            InitializeComponent();
        }

        private void MenuConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu VentanaMenu = new Menu();
            VentanaMenu.Show();
            this.Hide();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
