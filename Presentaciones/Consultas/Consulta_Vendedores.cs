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
Descripción:formulario de consultas de clientes registrados 
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Presentaciones.Consultas
{
    public partial class Consulta_Vendedores : Form
    {
        Logica_Vendedores logicaVendedor = new Logica_Vendedores();
        public Consulta_Vendedores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar_vendedores();
            configurar_data_vendedores();
        }

        private void Consulta_Vendedores_Load(object sender, EventArgs e)
        {

        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            cargar_dataconsulta_vendedores();
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

        public void cargar_vendedores()
        {
            comboBox_vendedores.Items.Clear();

            if (logicaVendedor.TieneVendedores())
            {
                List<Vendedores> lista_vendedor = logicaVendedor.Listar();

                foreach (Vendedores vendedor in lista_vendedor)
                {
                    if (vendedor != null)
                    {
                        comboBox_vendedores.Items.Add(vendedor);
                    }
                }
            }
        }

        public void cargar_dataconsulta_vendedores()
        {
            if (comboBox_vendedores.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un vendedor.");
                return;
            }
            //
            Vendedores vendedor = (Vendedores)comboBox_vendedores.SelectedItem;
            data_vendedores.Rows.Clear();
              data_vendedores.Rows.Add(
               vendedor.IdVendedor,
               vendedor.Identificacion,
               vendedor.Nombre,
               vendedor.Apellido,
               vendedor.FechaNacimiento.ToShortDateString(),
               vendedor.FechaIngreso.ToShortDateString());
        }

        public void configurar_data_vendedores()
        {
            //  configurar las columnas
            data_vendedores.Columns.Add("IdVendedor", "ID Vendedor");
            data_vendedores.Columns.Add("Identificacion", "Identificación");
            data_vendedores.Columns.Add("Nombre", "Nombre");
            data_vendedores.Columns.Add("Apellido", "Apellido");
            data_vendedores.Columns.Add("FechaNacimiento", "Fecha Nacimiento");
            data_vendedores.Columns.Add("FechaIngreso", "Fecha Ingreso");
            

            //Cconfiguracion adicional
            data_vendedores.AutoGenerateColumns = false;
            data_vendedores.ReadOnly = true;
            data_vendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_vendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
