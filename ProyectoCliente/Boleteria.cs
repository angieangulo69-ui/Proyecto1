
/*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción: Este formulario permite registrar las ventas, ademas carga datos de otro formularios como cliente, vendedor
localidades y partidos, los cuales son clave para la venta de entradas. 
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
using Comunicaciones;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCliente
{

    public partial class Boleteria : Form
    {
        private ClienteTCP clienteTCP = new ClienteTCP();
        private Cliente clienteActual;
        public Boleteria(Cliente cliente, ClienteTCP tcp)
        {
            InitializeComponent();

            clienteActual = cliente;
            clienteTCP = tcp;

            this.StartPosition = FormStartPosition.CenterScreen;
            configurar_data_venta();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPartido.SelectedItem == null ||
                    comboBoxLocalidad.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione partido y localidad.");
                    return;
                }

                int cantidad;

                if (!int.TryParse(txtCantidad.Text, out cantidad))
                {
                    MessageBox.Show("Cantidad inválida.");
                    return;
                }

                Entidades.Ventas venta = new Entidades.Ventas();
                venta.Cliente = clienteActual;
         
                LocalidadesXpartido localidadPartido = (LocalidadesXpartido)comboBoxLocalidad.SelectedItem;
                venta.Partidos = localidadPartido.Partido;
                venta.Localidades = localidadPartido.Localidades;
                venta.Cantidad = cantidad;
                venta.Vendedores = null;
                venta.FechaVenta = DateTime.Now;
                venta.TipoVenta = "En Línea";
                venta.MontoTotal = 0;

                Mensaje mensaje = new Mensaje("RegistrarVenta", venta);

                string respuestaJson = clienteTCP.Enviar(mensaje);

                Mensaje respuesta =
                    JsonConvert.DeserializeObject<Mensaje>(respuestaJson);

                MessageBox.Show(respuesta.Entidad.ToString());

                if (respuesta.Metodo == "OK")
                {
                    limpiar();
                    CargarVentas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Boleteria_Load(object sender, EventArgs e)
        {
            CargarPartidos();

            txt_nombreCliente.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
            txt_identificacion.Text = clienteActual.Identificacion;
        }
        private void configurar_data_venta()
        {
            data_compras.Columns.Add("IDVenta", "ID Venta");
            data_compras.Columns.Add("Cliente", "Cliente");
            data_compras.Columns.Add("Partido", "Partido");
            data_compras.Columns.Add("Localidad", "Localidad");
            data_compras.Columns.Add("Cantidad", "Cantidad");
            data_compras.Columns.Add("Vendedor", "Vendedor");
            data_compras.Columns.Add("FechaVenta", "Fecha Venta");
            data_compras.Columns.Add("MontoTotal", "Monto Total");
            data_compras.Columns.Add("TipoVenta", "Tipo Venta");

            //Configuración adicional para el DataGridView
            data_compras.AutoGenerateColumns = false;
            data_compras.ReadOnly = true;
            data_compras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_compras.Columns["MontoTotal"].DefaultCellStyle.Format = "C2"; // Formato de moneda para la columna de precio]
            data_compras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void limpiar()
        {
            txtCantidad.Clear();
            lblMontoTotal.Text = "";

            comboBoxPartido.SelectedIndex = -1;
            comboBoxLocalidad.SelectedIndex = -1;

            date_partido.Value = DateTime.Now;
        }
        private void CalcularTotal()
        {
            if (comboBoxLocalidad.SelectedItem == null)
                return;

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                lblMontoTotal.Text = "";
                return;
            }

            LocalidadesXpartido localidadPartido =
                (LocalidadesXpartido)comboBoxLocalidad.SelectedItem;

            decimal total = cantidad * localidadPartido.Localidades.Precio;

            lblMontoTotal.Text = total.ToString("N2");
        }

        private void comboBoxLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        // 
        private void CargarPartidos()
        {
            try
            {
                Mensaje mensaje = new Mensaje("ConsultarPartidos", null);

                string respuestaJson = clienteTCP.Enviar(mensaje);

                Mensaje respuesta =
                    JsonConvert.DeserializeObject<Mensaje>(respuestaJson);

                List<Partidos> lista =
                    JsonConvert.DeserializeObject<List<Partidos>>(JsonConvert.SerializeObject(respuesta.Entidad));

                comboBoxPartido.DataSource = lista;
                comboBoxPartido.DisplayMember = "Rival";
                comboBoxPartido.ValueMember = "IdPartido";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarVentas()
        {
            try
            {
                Mensaje mensaje = new Mensaje("ConsultarCompras", clienteActual.IdCliente);

                string respuestaJson = clienteTCP.Enviar(mensaje);

                Mensaje respuesta =
                    JsonConvert.DeserializeObject<Mensaje>(respuestaJson);

                if (respuesta.Metodo == "OK")
                {
                    List<Entidades.Ventas> lista =
                        JsonConvert.DeserializeObject<List<Entidades.Ventas>>(
                            JsonConvert.SerializeObject(respuesta.Entidad));

                    data_compras.DataSource = null;
                    data_compras.DataSource = lista;
                }
                else
                {
                    MessageBox.Show(respuesta.Entidad.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las compras: " + ex.Message);
            }
        }
        private void CargarLocalidades(int idPartido)
        {
            try
            {
                Mensaje mensaje = new Mensaje("ConsultarLocalidades", idPartido);

                string respuestaJson = clienteTCP.Enviar(mensaje);

                Mensaje respuesta =
                    JsonConvert.DeserializeObject<Mensaje>(respuestaJson);

                if (respuesta.Metodo == "OK")
                {
                    List<LocalidadesXpartido> lista =JsonConvert.DeserializeObject<List<LocalidadesXpartido>>(JsonConvert.SerializeObject(respuesta.Entidad));

                    comboBoxLocalidad.DataSource = null;
                    comboBoxLocalidad.DataSource = lista;
                    comboBoxLocalidad.DisplayMember = "NombreLocalidad";
                    comboBoxLocalidad.ValueMember = "IdLocalidadPartido";
                }
                else
                {
                    MessageBox.Show(respuesta.Entidad.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void comboBoxPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPartido.SelectedItem == null)
                return;

            Partidos partidoSeleccionado = (Partidos)comboBoxPartido.SelectedItem;

            date_partido.Value = partidoSeleccionado.Fecha;
            date_hora.Text = partidoSeleccionado.Hora.ToString();

            CargarLocalidades(partidoSeleccionado.IdPartido);
        }

        private void data_compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
