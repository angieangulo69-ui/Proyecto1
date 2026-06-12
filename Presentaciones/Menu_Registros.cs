using Presentaciones.Registros;
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

        private void btn_partido_Click(object sender, EventArgs e)
        {
            Registro_partido ventana_registroPedido = new Registro_partido();
            ventana_registroPedido.Show();
            Dispose(); // Cierra la ventana actual
        }

        private void btn_vendedor_Click(object sender, EventArgs e)
        {
            Registro_Vendedores ventana_registroVendedores = new Registro_Vendedores();
            ventana_registroVendedores.Show();
            Dispose(); // Cierra la ventana actual
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Registro_Clientes ventana_registroClientes = new Registro_Clientes();
            ventana_registroClientes.Show();
            Dispose(); // Cierra la ventana actual
        }

        private void btn_localidadXpartido_Click(object sender, EventArgs e)
        {
            Registro_LocalidadXPartido ventana_Registro_LocalidadXPartido = new Registro_LocalidadXPartido();
            ventana_Registro_LocalidadXPartido.Show();
            Dispose(); // Cierra la ventana actual
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Registro_Ventas ventana_registroVentas = new Registro_Ventas();
            ventana_registroVentas.Show();
            Dispose(); // Cierra la ventana actual
        }
    }

}
