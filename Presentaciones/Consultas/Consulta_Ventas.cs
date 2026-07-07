using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción:formulario de consultas de localiades por partido
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Presentaciones.Consultas
{
    public partial class Consulta_Ventas : Form
    {

        Logica_Ventas logicaVenta = new Logica_Ventas();
        public Consulta_Ventas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar_venta();
            configurar_data_ventas();
        }

        private void Consulta_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cargar_dataconsulta_ventas();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu_Consulta venta_consultas = new Menu_Consulta();
            venta_consultas.Show();
            this.Dispose();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void configurar_data_ventas()
        {
            data_venta.Columns.Add("IdVenta", "ID Venta");
            data_venta.Columns.Add("Cliente", "Cliente");
            data_venta.Columns.Add("Partido", "Partido");
            data_venta.Columns.Add("Localidad", "Localidad");
            data_venta.Columns.Add("Cantidad", "Cantidad");
            data_venta.Columns.Add("Vendedor", "Vendedor");
            data_venta.Columns.Add("FechaVenta", "Fecha Venta");
            data_venta.Columns.Add("MontoTotal", "Monto Total");
            data_venta.Columns.Add("TipoVenta", "Tipo Venta");

            data_venta.AutoGenerateColumns = false;
            data_venta.ReadOnly = true;
            data_venta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_venta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //Encargada de cargar la data
        public void cargar_dataconsulta_ventas()
        {
            if (comboBox_venta.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una venta.");
                return;
            }

            Ventas venta = (Ventas)comboBox_venta.SelectedItem;

            data_venta.Rows.Clear();

            data_venta.Rows.Add(
                venta.IdVenta,
                venta.Clientes.Nombre,
                venta.Partidos.Rival,
                venta.Localidades.NombreLocalidad,
                venta.Cantidad,
                venta.Vendedores.Nombre,
                venta.FechaVenta.ToShortDateString(),
                venta.MontoTotal,
                venta.TipoVenta
            );
        }
        //CArgar las ventas en el combox

        public void cargar_venta()
        {
            comboBox_venta.Items.Clear(); //limpiamos 

            if (logicaVenta.TieneVentas())
            {
                var lista_cliente = logicaVenta.Listar(); //Obtenemos las lista de partidos
                for (int i = 0; i < lista_cliente.Length; i++)
                {
                    if (lista_cliente[i] != null)
                    {
                        comboBox_venta.Items.Add(lista_cliente[i]);
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
