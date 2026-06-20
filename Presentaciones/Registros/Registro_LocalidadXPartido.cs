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
            cargar_localidadesXPartido();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu_Registros menu_Registro = new Menu_Registros();
            menu_Registro.Show();
            this.Dispose();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
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
            localidadXpartido.id_localidadPartido = int.Parse(txt_idlocalidadPartido.Text); // Convertir el texto a entero
            localidadXpartido.partido = (Partidos)comboBox_partido.SelectedItem;
            localidadXpartido.localidades = (Localidades)comboBox_localidad.SelectedItem;
            localidadXpartido.cantidadDisponible = int.Parse(txt_disponibilidad.Text);

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

        public void cargar_localidadesXPartido()
        {
            // Cargar localidades desde la lógica y mostrarlas en el DataGridView
            Logica_LocalidadXPartido logica_Partidos = new Logica_LocalidadXPartido();

            if (logica_Partidos.TieneLocalidadesXPartido()) //Tiene localidades
            {
                var lista_localidadXpartido = logica_Partidos.Listar(); // Obtener la lista de localidades
                for (int i = 0; i < lista_localidadXpartido.Length; i++)
                {
                    if (lista_localidadXpartido[i] != null) // Verificar que la localidad no sea nula
                    {
                        LocalidadesXpartido localidadXpartido = lista_localidadXpartido[i]; // Obtener la localidad actual
                        data_localidadXpartido.Rows.Add(
                            localidadXpartido.id_localidadPartido,
                           localidadXpartido.partido,
                            localidadXpartido.localidades,
                            localidadXpartido.cantidadDisponible
                        );
                    }
                }
            }
        }

        public void cargar_Partidos()
        {
            // Cargar localidades desde la lógica y mostrarlas en el DataGridView
            Logica_Partidos logica_Partidos = new Logica_Partidos();

            if (logica_Partidos.TienePartidos()) //Tiene localidades
            {
                var listaPartidos = logica_Partidos.Listar(); // Obtener la lista de localidades
                for (int i = 0; i < listaPartidos.Length; i++)
                {
                    if (listaPartidos[i] != null) // Verificar que la localidad no sea nula
                    {
                        comboBox_partido.Items.Add(listaPartidos[i]); //cargamos datos 
                    }
                }
            }
        }
        public void cargar_Localidades()
        {
            // Cargar localidades desde la lógica y mostrarlas en el DataGridView
            Logica_localidades logica_Localidades = new Logica_localidades();

            if (logica_Localidades.TieneLocalidades()) //Tiene localidades
            {
                var listaLocalidades = logica_Localidades.Listar(); // Obtener la lista de localidades
                for (int i = 0; i < listaLocalidades.Length; i++)
                {
                    if (listaLocalidades[i] != null) // Verificar que la localidad no sea nula
                    {
                        comboBox_localidad.Items.Add(listaLocalidades[i]);
                    }
                }
            }

        }

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
    }
}
