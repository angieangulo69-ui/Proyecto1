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
Descripción:formulario de consultas de localidades registrados 
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Presentaciones.Consultas
{
    public partial class Consulta_Localidades : Form
    {
        public Consulta_Localidades()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            configurar_data_localidades();
            cargar_nombrelocalidad();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            cargar_localidades();
        }

        //Metodos

        // Configura el DataGridView para mostrar las localidades
        private void configurar_data_localidades()
        {
            data_localidades.Columns.Add("IDLocalidad", "ID Localidad");
            data_localidades.Columns.Add("NombreLocalidad", "Nombre Localidad");
            data_localidades.Columns.Add("Precio", "Precio");

            //Configuración adicional para el DataGridView
            data_localidades.AutoGenerateColumns = false;
            data_localidades.ReadOnly = true;
            data_localidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_localidades.Columns["Precio"].DefaultCellStyle.Format = "C2"; // Formato de moneda para la columna de precio]
            data_localidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void cargar_localidades()
        {
            if (comboBox_nombrelocalidad.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una localidad.");
                return;
            }

            // Cargar localidades desde la lógica y mostrarlas en el DataGridView
            Logica_localidades logica_Localidades = new Logica_localidades();

            //Evitar duplicados al cargar localidades
            data_localidades.Rows.Clear();

            if (logica_Localidades.TieneLocalidades()) //Tiene localidades
            {
                var listaLocalidades = logica_Localidades.Listar(); // Obtener la lista de localidades
                foreach (Localidades localidad in listaLocalidades)
                {
                    if (localidad != null &&
                        comboBox_nombrelocalidad.SelectedItem != null &&
                        localidad.NombreLocalidad == comboBox_nombrelocalidad.SelectedItem.ToString())
                    {
                        data_localidades.Rows.Add(
                            localidad.IdLocalidad,
                            localidad.NombreLocalidad,
                            localidad.Precio
                        );
                    }
                }

            }
        }

        private void cargar_nombrelocalidad()
        {
            Logica_localidades logica_Localidades = new Logica_localidades();

            var listaLocalidades = logica_Localidades.Listar(); // Obtener la lista de localidades
            // Limpiar el ComboBox antes de cargar los nombres
            comboBox_nombrelocalidad.Items.Clear();

            if (listaLocalidades != null)
            {
                foreach (var localidad in listaLocalidades)
                {                    
                  comboBox_nombrelocalidad.Items.Add(localidad.NombreLocalidad);                    
                }
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu_Consulta menu_Consulta = new Menu_Consulta();
            menu_Consulta.Show();
            this.Dispose();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Consulta_Localidades_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
