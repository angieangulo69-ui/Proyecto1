using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciones
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            Menu_Registros menu_Registros = new Menu_Registros();
            menu_Registros.Show();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Menu_Consulta menu_Consultas = new Menu_Consulta();
            menu_Consultas.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
