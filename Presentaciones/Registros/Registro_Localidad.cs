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
    /*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción:formulario de regsitros de localidades
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
    public partial class Registro_Localidad : Form
    {
        public Registro_Localidad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
          
            if (!decimal.TryParse(txt_precio.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            Logica_localidades logica = new Logica_localidades(); //Instancia de la clase Logica_localidades

            // Llamamos al método Agregar de la clase Logica_localidades para agregar la localidad
            if (logica.Agregar(localidad))
            {
                cargar_localidades(); // Recargar el DataGridView para mostrar la nueva localidad
                limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la localidad. Verifique que el ID no exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiar();
            }
        }
        private void data_localidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Método para limpiar los campos
        public void limpiar()
        {
            txt_idlocalidad.Clear();
            txt_nombrelocalidad.Clear();
            txt_precio.Clear();

            txt_idlocalidad.Focus(); // Colocar el cursor en el primer campo

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
                foreach (Localidades localidad in logica_Localidades.Listar())
                {
                    data_localidades.Rows.Add(
                        localidad.IdLocalidad,
                        localidad.NombreLocalidad,
                        localidad.Precio
                    );
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

        private void Registro_Localidad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txt_idlocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
                MessageBox.Show("Solo se permiten números en el campo ID Localidad.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_nombrelocalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombrelocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que solo se ingresen letras y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
                MessageBox.Show("Solo se permiten letras y espacios en el campo Nombre Localidad.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_precio_KeyUp(object sender, KeyEventArgs e)
        {
            //Validar que solo se ingresen números y un punto decimal
            if (!decimal.TryParse(txt_precio.Text, out _))
            {
                MessageBox.Show("Solo se permiten números y un punto decimal en el campo Precio.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_precio.Clear(); // Limpiar el campo si la entrada es inválida
            }
        }
    }
}
