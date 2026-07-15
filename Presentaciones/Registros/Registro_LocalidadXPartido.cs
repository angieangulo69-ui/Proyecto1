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
Descripción: Formulario encargado del registro de localidades por partido.
Permite seleccionar un partido y una localidad previamente registrados,
asignar la cantidad disponible de entradas y almacenar la información,
aplicando las validaciones establecidas por las reglas de negocio.
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/


namespace Presentaciones.Registros
{
    public partial class Registro_LocalidadXPartido : Form
    {
        public Registro_LocalidadXPartido()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            configurar_data_localidades();
            cargar_Partidos();
            cargar_Localidades();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //Salimos del sistema
            Application.Exit();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            //Volvemos a la ventana de menu de registros
            Menu_Registros menu_Registro = new Menu_Registros();
            menu_Registro.Show();
            this.Dispose();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entró al botón Guardar");
            //Validamos que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txt_idlocalidadPartido.Text) ||
                string.IsNullOrWhiteSpace(comboBox_partido.Text) ||
                string.IsNullOrWhiteSpace(comboBox_localidad.Text) ||
                string.IsNullOrWhiteSpace(txt_disponibilidad.Text))

            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            //Referencia a la clase Localidad
            LocalidadesXpartido localidadXpartido = new LocalidadesXpartido();

            //asignamos los datos ingresados a la clase Localidad
            localidadXpartido.IdLocalidadPartido = int.Parse(txt_idlocalidadPartido.Text); // Convertir el texto a entero
            localidadXpartido.Partido = (Partidos)comboBox_partido.SelectedItem;
            localidadXpartido.Localidades = (Localidades)comboBox_localidad.SelectedItem;
            localidadXpartido.CantidadDisponible = int.Parse(txt_disponibilidad.Text);

            //validamos que el partido este activo
            if (!Logica_LocalidadXPartido.PartidoActivo(localidadXpartido))
            {
                MessageBox.Show("No se pueden registrar localidades para partidos inactivos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Logica_LocalidadXPartido logicaXPartido = new Logica_LocalidadXPartido(); //Instancia de la clase Logica_localidades
            //Validamos que no se repita la localidad

            if (logicaXPartido.ExisteLocalidadPartido(localidadXpartido))
            {
                MessageBox.Show("Esta localidad ya fue asignada a este partido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!logicaXPartido.CantidadValida(localidadXpartido))
            {
                MessageBox.Show("La cantidad disponible debe ser mayor que cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llamamos al método Agregar de la clase Logica_localidades para agregar la localidad
            if (logicaXPartido.Agregar(localidadXpartido))
            {
                cargar_localidadesXPartido(); // Recargar el DataGridView para mostrar la nueva localidad
                limpiar();
            }
            else
            {
                MessageBox.Show("Error No se permiten ID repetidos o a llegado al limite de 10 registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiar();
            }

        }
        //Metodo que me permite cargar los registros realizados 
        public void cargar_localidadesXPartido()
        {
            data_localidadXpartido.Rows.Clear();

            Logica_LocalidadXPartido logica = new Logica_LocalidadXPartido();

            if (logica.TieneLocalidadesXPartido())
            {
                foreach (LocalidadesXpartido localidadXpartido in logica.Listar())
                {
                    data_localidadXpartido.Rows.Add(
                        localidadXpartido.IdLocalidadPartido,
                        localidadXpartido.Partido.Rival,
                        localidadXpartido.Localidades.NombreLocalidad,
                        localidadXpartido.CantidadDisponible
                    );
                }
            }
        }

        public void cargar_Partidos()
        {
            // Cargar partidos desde la lógica y mostrarlas en el DataGridView
            Logica_Partidos logica_Partidos = new Logica_Partidos();

            if (logica_Partidos.TienePartidos()) //Tiene partidos
            {
                // Obtener la lista de partidos
                foreach (Partidos partido in logica_Partidos.Listar())
                {
                    comboBox_partido.Items.Add(partido); //cargamos datos 
                }

            }
        }
        //Cargar las localidades en el combox de localidades 
        public void cargar_Localidades()
        {
            // Cargar localidades desde la lógica y mostrarlas en el DataGridView
            Logica_localidades logica_Localidades = new Logica_localidades();

            if (logica_Localidades.TieneLocalidades()) //Tiene localidades
            {
                foreach (Localidades localidad in logica_Localidades.Listar())
                {
                    comboBox_localidad.Items.Add(localidad);
                }
            }
        }


        //Metodo para configurar la data de las localidades registradas
        private void configurar_data_localidades()
        {
            data_localidadXpartido.Columns.Add("IDLocalidadPartido", "ID Localidad por Partido");
            data_localidadXpartido.Columns.Add("Partido", "Partido");
            data_localidadXpartido.Columns.Add("Localidad", "Localidad");
            data_localidadXpartido.Columns.Add("CantidadDisponible", "Cantidad Disponible");

            //Configuración adicional para el DataGridView
            data_localidadXpartido.AutoGenerateColumns = false;
            data_localidadXpartido.ReadOnly = true;
            data_localidadXpartido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_localidadXpartido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //Metodo para limpiar los espacios
        public void limpiar()
        {
            txt_idlocalidadPartido.Clear();
            txt_disponibilidad.Clear();
            comboBox_partido.SelectedIndex = -1;
            comboBox_localidad.SelectedIndex = -1;
            txt_idlocalidadPartido.Focus();
        }

        private void Registro_LocalidadXPartido_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txt_idlocalidadPartido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen números en el campo de ID Localidad por Partido
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
                MessageBox.Show("Solo se permiten números en el campo de ID Localidad por Partido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_disponibilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen números en el campo de Cantidad Disponible
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
                MessageBox.Show("Solo se permiten números en el campo de Cantidad Disponible.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entró al botón Guardar");
            //Validamos que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txt_idlocalidadPartido.Text) ||
                string.IsNullOrWhiteSpace(comboBox_partido.Text) ||
                string.IsNullOrWhiteSpace(comboBox_localidad.Text) ||
                string.IsNullOrWhiteSpace(txt_disponibilidad.Text))

            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            //Referencia a la clase Localidad
            LocalidadesXpartido localidadXpartido = new LocalidadesXpartido();

            //asignamos los datos ingresados a la clase Localidad
            localidadXpartido.IdLocalidadPartido = int.Parse(txt_idlocalidadPartido.Text); // Convertir el texto a entero
            localidadXpartido.Partido = (Partidos)comboBox_partido.SelectedItem;
            localidadXpartido.Localidades = (Localidades)comboBox_localidad.SelectedItem;
            localidadXpartido.CantidadDisponible = int.Parse(txt_disponibilidad.Text);

            //validamos que el partido este activo
            if (!Logica_LocalidadXPartido.PartidoActivo(localidadXpartido))
            {
                MessageBox.Show("No se pueden registrar localidades para partidos inactivos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Logica_LocalidadXPartido logicaXPartido = new Logica_LocalidadXPartido(); //Instancia de la clase Logica_localidades
            //Validamos que no se repita la localidad

            if (logicaXPartido.ExisteLocalidadPartido(localidadXpartido))
            {
                MessageBox.Show("Esta localidad ya fue asignada a este partido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!logicaXPartido.CantidadValida(localidadXpartido))
            {
                MessageBox.Show("La cantidad disponible debe ser mayor que cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llamamos al método Agregar de la clase Logica_localidades para agregar la localidad
            if (logicaXPartido.Agregar(localidadXpartido))
            {
                cargar_localidadesXPartido(); // Recargar el DataGridView para mostrar la nueva localidad
                limpiar();
            }
            else
            {
                MessageBox.Show("Error No se permiten ID repetidos o a llegado al limite de 10 registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiar();
            }

        }

        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
