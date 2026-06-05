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
    public partial class Menu_Registros : Form
    {
        public Menu_Registros()
        {
            InitializeComponent();
        }

        private void btn_Localidad_Click(object sender, EventArgs e)
        {
            Registro_Localidad ventana_registrolocalidad = new Registro_Localidad();
            ventana_registrolocalidad.Show();
            Dispose(); // Cierra la ventana actual

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicación
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu menu_principal = new Menu();
            menu_principal.Show();
            Dispose(); // Cierra la ventana actual
        }
    }
}
