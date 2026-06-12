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

        private void btn_partido_Click(object sender, EventArgs e)
        {
            Consulta_Partidos VentaConsultaPartido = new Consulta_Partidos();
            VentaConsultaPartido.ShowDialog();
            this.Dispose();
        }

        private void btn_vendedor_Click(object sender, EventArgs e)
        {
            Consulta_Vendedores ventan_ConsultaVendedores = new Consulta_Vendedores();
            ventan_ConsultaVendedores.ShowDialog();
            this.Dispose();

        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Consulta_Clientes ventan_ConsultaClientes = new Consulta_Clientes();
            ventan_ConsultaClientes.ShowDialog();
            this.Dispose();
        }

        private void btn_localidadXpartido_Click(object sender, EventArgs e)
        {
            Consulta_LocalidadXPartido ventan_ConsultaLocalidadXPartido = new Consulta_LocalidadXPartido();
            ventan_ConsultaLocalidadXPartido.ShowDialog();
            this.Dispose();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Consulta_Ventas ventan_ConsultaVentas = new Consulta_Ventas();
            ventan_ConsultaVentas.ShowDialog();
            this.Dispose();

        }
    }

}
