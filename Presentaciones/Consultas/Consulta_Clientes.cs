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

namespace Presentaciones.Consultas
{
    public partial class Consulta_Clientes : Form
    {
        Logica_Clientes logicaCliente = new Logica_Clientes();
        public Consulta_Clientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar_clientes();
            configurar_data_clientes();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void cargar_clientes()
        {
            comboBox_cliente.Items.Clear(); //limpiamos 

            if (logicaCliente.TieneClientes())
            {
                var lista_cliente = logicaCliente.Listar(); //Obtenemos las lista de partidos
                for (int i = 0; i < lista_cliente.Length; i++)
                {
                    if (lista_cliente[i] != null)
                    {
                        comboBox_cliente.Items.Add(lista_cliente[i]);
                    }
                }
            }
        }

        public void cargar_dataconsulta_clientes()
        {
            if (comboBox_cliente.SelectedItem == null)
            {
                return;
            }
            //
            Clientes cliente = (Clientes)comboBox_cliente.SelectedItem;

            data_cliente.Rows.Clear();

            data_cliente.Rows.Add(
               cliente.IdCliente,
               cliente.Identificacion,
               cliente.Nombre,
               cliente.Apellido,
               cliente.FechaNacimiento.ToShortDateString(),
               cliente.FechaRegistro.ToShortDateString());
        }

        public void configurar_data_clientes()
        {
            //  configurar las columnas
            data_cliente.Columns.Add("IdCliente", "Id Cliente");
            data_cliente.Columns.Add("Identificacion", "Identificación");
            data_cliente.Columns.Add("Nombre", "Nombre");
            data_cliente.Columns.Add("Apellido", "Apellido");
            data_cliente.Columns.Add("FechaNacimiento", "Fecha Nacimiento");
            data_cliente.Columns.Add("FechaRegistro", "Fecha Registro");
            data_cliente.Columns.Add("Activo", "Activo");

            //Cconfiguracion adicional
            data_cliente.AutoGenerateColumns = false;
            data_cliente.ReadOnly = true;
            data_cliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu_Consulta venta_consultas = new Menu_Consulta();
            venta_consultas.Show();
            this.Dispose();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            cargar_dataconsulta_clientes();
        }

        private void Consulta_Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
