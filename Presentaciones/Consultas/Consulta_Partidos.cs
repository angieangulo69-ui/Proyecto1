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
    public partial class Consulta_Partidos : Form

    { 
        //Obtenemos la lista de partidos
        Logica_Partidos logicaPartidos = new Logica_Partidos();
        public Consulta_Partidos()
        {
            InitializeComponent();
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
        }

        public void cargar_partidos()
        { 
            data_partidos.Rows.Clear();

            if (comboBox_fechas.SelectedIndex == -1)
            {
                return;
            }

            DateTime fechaSeleccionada;

            if (!DateTime.TryParse(comboBox_fechas.Text, out fechaSeleccionada))
            {
                return;
            }

            var listaPartidos = logicaPartidos.Listar();

            for (int i = 0; i < listaPartidos.Length; i++)
            {
                if (listaPartidos[i] != null &&
                    listaPartidos[i].Fecha.Date == fechaSeleccionada.Date)
                {
                    data_partidos.Rows.Add(
                        listaPartidos[i].IdPartido,
                        listaPartidos[i].Rival,
                        listaPartidos[i].Fecha,
                        listaPartidos[i].Hora,
                        listaPartidos[i].Activo
                    );
                }
            }
        }

        public void cargar_fechapartido()
        {
            var listaPartidos = logicaPartidos.Listar(); //Listamos 

            comboBox_fechas.Items.Clear(); //Lompiamor combox antes de cargar

            if (listaPartidos != null)
            {
                foreach (var partido in listaPartidos)
                {
                    if (partido != null)
                    {
                        comboBox_fechas.Items.Add(
                            partido.Fecha.ToShortDateString()
                        );
                    }
                }
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            cargar_partidos();
        }
    }
}
