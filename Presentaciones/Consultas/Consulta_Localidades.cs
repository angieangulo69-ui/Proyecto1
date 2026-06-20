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
            data_localidades.Columns["precio"].DefaultCellStyle.Format = "C2"; // Formato de moneda para la columna de precio]
            data_localidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void cargar_localidades()
        {
            // Cargar localidades desde la lógica y mostrarlas en el DataGridView
            Logica_localidades logica_Localidades = new Logica_localidades();

            //Evitar duplicados al cargar localidades
            data_localidades.Rows.Clear();

            if (logica_Localidades.TieneLocalidades()) //Tiene localidades
            {
                var listaLocalidades = logica_Localidades.Listar(); // Obtener la lista de localidades
                for (int i = 0; i < listaLocalidades.Length; i++)
                {
                    if (listaLocalidades[i] != null) // Verificar que la localidad no sea nula
                    {    // Verificar si el nombre de la localidad coincide con el seleccionado en el ComboBox
                        if (comboBox_nombrelocalidad.SelectedItem != null &&
                            listaLocalidades[i].NombreLocalidad == comboBox_nombrelocalidad.SelectedItem.ToString())
                        {
                            Localidades localidad = listaLocalidades[i]; // Obtener la localidad actual
                            data_localidades.Rows.Add(
                                localidad.IdLocalidad,
                                localidad.NombreLocalidad,
                                localidad.Precio
                            );
                        }
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
                    if (localidad != null)
                    {
                        comboBox_nombrelocalidad.Items.Add(localidad.NombreLocalidad);
                    }
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
    }
}
