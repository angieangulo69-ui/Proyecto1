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
    public partial class Registro_partido : Form
    {
        public Registro_partido()
        {
            InitializeComponent();
            configurar_data_partidos();
            cargar_partidos();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txt_idpartido.Text) ||
                string.IsNullOrWhiteSpace(txt_rival.Text) ||
                string.IsNullOrWhiteSpace(txt_hora.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Refenciamos la clase partidos
            Partidos partido = new Partidos();

            // Asignar valores a las propiedades del nuevo partido
            partido.IdPartido = int.Parse(txt_idpartido.Text);
            partido.Rival = txt_rival.Text;
            partido.Fecha = dateTime_fecha.Value;
            partido.Hora = txt_hora.Text;
            partido.Activo = checkBox_activo.Checked;


            // instanciamos la clase logica 
            Logica_Partidos logica = new Logica_Partidos();

            if (logica.Agregar(partido))
            {

                limpiar();
                cargar_partidos(); // Recargar la lista de partidos después de agregar uno nuevo
            }
            else
            {
                MessageBox.Show("Error al registrar el partido. Verifique los datos e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu_Registros menu_Registro = new Menu_Registros();
            menu_Registro.Show();
            this.Dispose();

        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Metodos
        private void limpiar()
        {
            txt_idpartido.Clear();
            txt_rival.Clear();
            dateTime_fecha.Value = DateTime.Now;
            txt_hora.Clear();
            checkBox_activo.Checked = true;
        }
        public void configurar_data_partidos()
        {
            //configuracion de columnas
            data_localidades.Columns.Add("IdPartido", "ID Partido");
            data_localidades.Columns.Add("Rival", "Rival");
            data_localidades.Columns.Add("Fecha", "Fecha");
            data_localidades.Columns.Add("Hora", "Hora");
            data_localidades.Columns.Add("Activo", "Activo");

            //configuracion adicional
            data_localidades.AutoGenerateColumns = false;
            data_localidades.ReadOnly = true;
            data_localidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void cargar_partidos()
        {
            //cargar partidos desde la logica
            Logica_Partidos logica_Partidos = new Logica.Logica_Partidos();

            data_localidades.Rows.Clear(); // Limpiar filas existentes

            if (logica_Partidos.TienePartidos())
            {
                var lista_partidos = logica_Partidos.Listar(); // Obtener la lista de partidos
                for (int i = 0; i < lista_partidos.Length; i++)
                {
                    if (lista_partidos[i] != null)
                    {
                        Partidos partidos = lista_partidos[i];
                        data_localidades.Rows.Add(
                            partidos.IdPartido,
                            partidos.Rival,
                            partidos.Fecha.ToShortDateString(),
                            partidos.Hora.ToString(),
                            partidos.Activo ? "Sí" : "No"
                        );
                    }
                }



            }
        }

        private void Registro_partido_Load(object sender, EventArgs e)
        {

        }
    }
}
