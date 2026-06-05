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

namespace Presentaciones
{
    public partial class Registro_Localidad : Form
    {
        public Registro_Localidad()
        {
            InitializeComponent();

            configurar_data_localidades();
            cargar_localidades();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Validamos que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txt_idlocalidad.Text) ||
                string.IsNullOrWhiteSpace(txt_nombrelocalidad.Text) ||
                string.IsNullOrWhiteSpace(txt_precio.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            //Referencia a la clase Localidad
            Localidades localidad = new Localidades();

            //asignamos los datos ingresados a la clase Localidad
            localidad.IdLocalidad = int.Parse(txt_idlocalidad.Text); // Convertir el texto a entero
            localidad.NombreLocalidad = txt_nombrelocalidad.Text;
            localidad.Precio = decimal.Parse(txt_precio.Text);

            Logica_localidades logica = new Logica_localidades(); //Instancia de la clase Logica_localidades

            // Llamamos al método Agregar de la clase Logica_localidades para agregar la localidad
            if (logica.Agregar(localidad))
            {
                cargar_localidades(); // Recargar el DataGridView para mostrar la nueva localidad
                limpiar();
            }
            else
            {
                MessageBox.Show("Error No se permiten ID repetidos, al registrar localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiar();
            }         
        }
        private void data_localidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Métodos
        public void limpiar()
        {
            txt_idlocalidad.Text = " ";
            txt_nombrelocalidad.Text = " ";
            txt_precio.Text = " ";

        }
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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu_Registros ventana_registros = new Menu_Registros();
            ventana_registros.Show();
            this.Dispose();
        }
    }
}
