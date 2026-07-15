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
    public partial class Consulta_LocalidadXPartido : Form
    {
        public Consulta_LocalidadXPartido()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            configurar_data_localidadXpartido();
            cargarCombo();
        }
            
        private void Consulta_LocalidadXPartido_Load(object sender, EventArgs e)
        {

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {//Vuelve al menu principal de consultas y cierra esta ventana
            Menu_Consulta ventanaconsultas = new Menu_Consulta();
            ventanaconsultas.ShowDialog();
            Dispose();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        { //salimos del programa
            Application.Exit();
        }

        private void data_localidadXpartido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {//Carga en la data los partidos al consultar
            mostrar_localidadesXPartidoseleccionada();

        }
        //Permite mostrar la localidad x partido  limpia tabla y muestra el partido en su licalidad 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //Metodo encargado de configurar la data para una mejor visualización
        private void configurar_data_localidadXpartido()
        {
            data_localidadXpartido.Columns.Add("IDPartido", "ID Partido");
            data_localidadXpartido.Columns.Add("Rival", "Rival");
            data_localidadXpartido.Columns.Add("FechaPartido", "Fecha partido");
            data_localidadXpartido.Columns.Add("Horapartido", "Hora Partido");
            data_localidadXpartido.Columns.Add("Activo", "Partido  Activo");
            data_localidadXpartido.Columns.Add("IDLocalidad", "ID Localidad");
            data_localidadXpartido.Columns.Add("Nombrelocalidad", "Nombre Localidad");
            data_localidadXpartido.Columns.Add("Precio", "Precio Localidad");
            data_localidadXpartido.Columns.Add("Disponiblidad", "Disponibilidad");

            //Configuración adicional para el DataGridView
            data_localidadXpartido.AutoGenerateColumns = false;
            data_localidadXpartido.ReadOnly = true;
            data_localidadXpartido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_localidadXpartido.Columns["Precio"].DefaultCellStyle.Format = "C2"; // Formato de moneda para la columna de precio]
            data_localidadXpartido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //Metodo Encargado de cargar las localidades registradas
        public void mostrar_localidadesXPartidoseleccionada()
        {
            if (comboBoxlocalidadXpartido.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una localidad por partido.");
                return;
            }

            LocalidadesXpartido item = (LocalidadesXpartido)comboBoxlocalidadXpartido.SelectedItem;

            data_localidadXpartido.Rows.Clear();

            data_localidadXpartido.Rows.Add(
                item.Partido.IdPartido,
                item.Partido.Rival,
                item.Partido.Fecha.ToShortDateString(),
                item.Partido.Hora,
                item.Partido.Activo ? "Sí" : "No",
                item.Localidades.IdLocalidad,
                item.Localidades.NombreLocalidad,
                item.Localidades.Precio,
                item.CantidadDisponible
            );

        }
            //Permite carga el combox de busqueda
            public void cargarCombo()
             {
            Logica_LocalidadXPartido logica = new Logica_LocalidadXPartido();

            if (logica.TieneLocalidadesXPartido())
            {
                List<LocalidadesXpartido> lista = logica.Listar();

                comboBoxlocalidadXpartido.Items.Clear();

                foreach (LocalidadesXpartido item in lista)
                {
                    if (item != null)
                    {
                        comboBoxlocalidadXpartido.Items.Add(item);
                    }
                }
            }


        }
    }
    
}

