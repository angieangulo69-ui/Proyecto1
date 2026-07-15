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
    public partial class Consulta_Partidos : Form

    {
        //Obtenemos la lista de partidos
        Logica_Partidos logicaPartidos = new Logica_Partidos();
        public Consulta_Partidos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            configurar_data_partidos();
            cargar_fechapartido();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        //Metodos
        public void configurar_data_partidos()
        {
            //configuracion de columnas
            data_partidos.Columns.Add("IdPartido", "ID Partido");
            data_partidos.Columns.Add("Rival", "Rival");
            data_partidos.Columns.Add("Fecha", "Fecha");
            data_partidos.Columns.Add("Hora", "Hora");
            data_partidos.Columns.Add("Activo", "Activo");

            //configuracion adicional
            data_partidos.AutoGenerateColumns = false;
            data_partidos.ReadOnly = true;
            data_partidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_partidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void cargar_partidos()
        {
            data_partidos.Rows.Clear();

            if (comboBox_fechas.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una fecha.");
                return;
            }

            DateTime fechaSeleccionada;

            if (!DateTime.TryParse(comboBox_fechas.Text, out fechaSeleccionada))
            {
                return;
            }
             var listaPartidos = logicaPartidos.Listar(); //Listamos
            foreach (Partidos partido in listaPartidos)
            {
                if (partido.Fecha.Date == fechaSeleccionada.Date)
                {
                    data_partidos.Rows.Add(
                        partido.IdPartido,
                        partido.Rival,
                        partido.Fecha.ToShortDateString(),
                        partido.Hora,
                        partido.Activo ? "Sí" : "No"
                    );
                }
            }
        }

        public void cargar_fechapartido()
        {
            var listaPartidos = logicaPartidos.Listar(); //Listamos 

            comboBox_fechas.Items.Clear(); //Limpiamos combox antes de cargar

            if (listaPartidos != null)
            {
                foreach (Partidos partido in listaPartidos)
                {
                    string fecha = partido.Fecha.ToShortDateString();

                    if (!comboBox_fechas.Items.Contains(fecha))
                    {
                        comboBox_fechas.Items.Add(fecha);
                    }
                }
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            cargar_partidos();
        }

        private void Consulta_Partidos_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_fechas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
