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

namespace Presentaciones
{
    public partial class Menu_Consulta : Form
    {
        public Menu_Consulta()
        {
            InitializeComponent();
        }

        private void btn_Localidad_Click(object sender, EventArgs e)
        {
            Consulta_Localidades ventana_consultalocalidades = new Consulta_Localidades();
            ventana_consultalocalidades.ShowDialog();
            this.Dispose();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicación
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu menu_princiaal = new Menu();
            menu_princiaal.ShowDialog();
            this.Dispose();
        }
    }
}
