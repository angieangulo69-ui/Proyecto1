
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

                if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Cantidad inválida.");
                    return;
                }

                Ventas venta = new Ventas();
                venta.Cliente = clienteActual;

                LocalidadesXpartido localidadPartido = (LocalidadesXpartido)comboBoxLocalidad.SelectedItem;
                venta.Partidos = localidadPartido.Partido;
                venta.Localidades = localidadPartido.Localidades;
                venta.Cantidad = cantidad;
                venta.Vendedores = null;
                venta.FechaVenta = DateTime.Now;
                venta.TipoVenta = "En Línea";
                venta.MontoTotal = 0;

                //
                MensajeSocket<object> mensaje = new MensajeSocket<object>("RegistrarVenta")
                {
                    Entidad = venta
                };

                string respuestaJson = clienteTCP.Enviar(mensaje);

                MensajeSocket<object> respuesta = JsonConvert.DeserializeObject<MensajeSocket<object>>(respuestaJson);

                //
                if (respuesta.Metodo == "OK")
                {
                    MessageBox.Show(respuesta.Entidad.ToString());
                    limpiar();
                    CargarVentas();
                }
                else
                {
                    MessageBox.Show(respuesta.Entidad.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            MessageBox.Show(clienteActual.Nombre);
            CargarPartidos();

            txt_nombreCliente.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
            txt_identificacion.Text = clienteActual.Identificacion;

            
            CargarVentas();

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
            //
            LocalidadesXpartido localidadPartido = (LocalidadesXpartido)comboBoxLocalidad.SelectedItem;

            decimal total = cantidad * localidadPartido.Localidades.Precio;

            lblMontoTotal.Text = total.ToString("N2"); //
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
                MensajeSocket<object> mensaje = new MensajeSocket<object>("ConsultarPartidos");

                string respuestaJson = clienteTCP.Enviar(mensaje);
                //
                MensajeSocket<object> respuesta = JsonConvert.DeserializeObject<MensajeSocket<object>>(respuestaJson);
                if (respuesta.Metodo == "OK")
                {
                    //
                    List<Partidos> lista = JsonConvert.DeserializeObject<List<Partidos>>(JsonConvert.SerializeObject(respuesta.Entidad));

                    comboBoxPartido.DataSource = null;
                    comboBoxPartido.DataSource = lista;
                    comboBoxPartido.DisplayMember = "Rival";
                    comboBoxPartido.ValueMember = "IdPartido";
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
        private void CargarVentas()
        {
            try
            {   //
                MensajeSocket<object> mensaje = new MensajeSocket<object>("ConsultarCompras")
                {
                    Entidad = clienteActual.IdCliente
                };

                string respuestaJson = clienteTCP.Enviar(mensaje);
                //
                MensajeSocket<object> respuesta = JsonConvert.DeserializeObject<MensajeSocket<object>>(respuestaJson);

                if (respuesta.Metodo == "OK")
                {
                    List<Ventas> lista = JsonConvert.DeserializeObject<List<Ventas>>(JsonConvert.SerializeObject(respuesta.Entidad));

                    data_compras.Rows.Clear();

                    foreach (Ventas venta in lista)
                    {
                        data_compras.Rows.Add(
                            venta.IdVenta,
                            venta.Cliente.Nombre,
                            venta.Partidos.Rival,
                            venta.Localidades.NombreLocalidad,
                            venta.Cantidad,
                            venta.Vendedores == null ? "" : venta.Vendedores.Nombre,
                            venta.FechaVenta.ToShortDateString(),
                            venta.MontoTotal,
                            venta.TipoVenta
                        );
                    }
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
                MensajeSocket<object> mensaje = new MensajeSocket<object>("ConsultarLocalidades")
                {
                    Entidad = idPartido
                };

                string respuestaJson = clienteTCP.Enviar(mensaje);

                MensajeSocket<object> respuesta = JsonConvert.DeserializeObject<MensajeSocket<object>>(respuestaJson);

                if (respuesta.Metodo == "OK")
                {
                    List<LocalidadesXpartido> lista = JsonConvert.DeserializeObject<List<LocalidadesXpartido>>(JsonConvert.SerializeObject(respuesta.Entidad));

                    comboBoxLocalidad.DataSource = null;
                    comboBoxLocalidad.DataSource = lista;

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
            date_hora.Text = partidoSeleccionado.Hora;

            CargarLocalidades(partidoSeleccionado.IdPartido);
        }

        private void data_compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxLocalidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxLocalidad.SelectedItem == null)
                return;

            CalcularTotal();
        }
    }
}
