using Entidades;
using Logica;
using Presentaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor.Registros
{
    public partial class RegistroVenta : Form
    {
        public RegistroVenta()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            configurar_data_ventas();
            cargarLocalidades();
            cargarPartidos();
            cargarClientes();
            cargarVendedores();

            txtMontototal.ReadOnly = true; //Inavilitar el montototal

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Validamos que los campos no estén vacíos
            if (comboBoxCliente.SelectedItem == null ||
               comboBoxPartido.SelectedItem == null ||
               comboBoxLocalidad.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
               comboBoxVendedor.SelectedItem == null)
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            try
            {
                //Referencia a la clase Localidad
                Ventas venta = new Ventas();

                //asignamos los datos ingresados a la clase Localidad                
                venta.Cliente = (Cliente)comboBoxCliente.SelectedItem;
                venta.Partidos = (Partidos)comboBoxPartido.SelectedItem;
                venta.Localidades = (Localidades)comboBoxLocalidad.SelectedItem;
                //validamos que solo numeros
                if (!int.TryParse(txtCantidad.Text, out int cantidad))
                {
                    MessageBox.Show("Cantidad inválida");
                    return;
                }
                venta.Cantidad = cantidad;
                venta.Vendedores = (Vendedores)comboBoxVendedor.SelectedItem;
                venta.FechaVenta = date_venta.Value;
                venta.MontoTotal = decimal.Parse(txtMontototal.Text);
                venta.TipoVenta = "Boleteria";


                Logica_Ventas logicaVentas = new Logica_Ventas(); //Instancia de la clase Logica ventas

                // Llamamos al método Agregar de la clase Logica ventas para agregar la venta
                string resultado = logicaVentas.Agregar(venta);

                if (string.IsNullOrEmpty(resultado))
                {
                    MessageBox.Show(
                        "Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarVentas();
                    limpiar();
                }
                else
                {
                    MessageBox.Show(resultado,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu_Registros ventana_registros = new Menu_Registros();
            ventana_registros.Show(this);
            Dispose();
        }

        private void configurar_data_ventas()
        {
            data_Venta.Columns.Add("IDVenta", "ID Venta");
            data_Venta.Columns.Add("Cliente", "Cliente");
            data_Venta.Columns.Add("Partido", "Partido");
            data_Venta.Columns.Add("Localidad", "Localidad");
            data_Venta.Columns.Add("Cantidad", "Cantidad");
            data_Venta.Columns.Add("Vendedor", "Vendedor");
            data_Venta.Columns.Add("FechaVenta", "Fecha Venta");
            data_Venta.Columns.Add("MontoTotal", "Monto Total");
            data_Venta.Columns.Add("TipoVenta", "Tipo Venta");

            //Configuración adicional para el DataGridView
            data_Venta.AutoGenerateColumns = false;
            data_Venta.ReadOnly = true;
            data_Venta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Venta.Columns["MontoTotal"].DefaultCellStyle.Format = "C2"; // Formato de moneda para la columna de precio]
            data_Venta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Metodo que se encargado de limpiar los espacios para un nuevo registro
        public void limpiar()
        {
            txtCantidad.Clear();
            txtMontototal.Clear();
            txtTipo.Clear();

            comboBoxCliente.SelectedIndex = -1;
            comboBoxPartido.SelectedIndex = -1;
            comboBoxLocalidad.SelectedIndex = -1;
            comboBoxVendedor.SelectedIndex = -1;


            date_venta.Value = DateTime.Now;
        }
        //Carga los registros de ventas realizadas
        public void CargarVentas()
        {

            // Cargar localidades desde la lógica y mostrarlas en el DataGridView
            Logica_Ventas logica_Ventas = new Logica_Ventas();

            //Evitar duplicados al cargar ventas
            data_Venta.Rows.Clear();

            if (logica_Ventas.TieneVentas()) //Tiene Ventas
            {
                foreach (Ventas Venta in logica_Ventas.Listar()) //Recorremos la lista de ventas
                    data_Venta.Rows.Add(
                            Venta.IdVenta,
                            Venta.Cliente.Nombre,
                            Venta.Partidos.Rival,
                            Venta.Localidades.NombreLocalidad,
                            Venta.Cantidad,
                            Venta.Vendedores.Nombre,
                            Venta.FechaVenta,
                            Venta.MontoTotal,
                            Venta.TipoVenta
                     );
            }

        }
        //Permite calcular el total
        private void CalcularTotal()
        {
            if (comboBoxLocalidad.SelectedItem == null) return;

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                txtMontototal.Clear();
                return;
            }

            Localidades localidad = (Localidades)comboBoxLocalidad.SelectedItem;

            decimal total = cantidad * localidad.Precio;

            txtMontototal.Text = total.ToString("0.00");
        }

        //Metodo que carga las localidades registradas
        public void cargarLocalidades()
        {
            try
            {
                comboBoxLocalidad.Items.Clear(); //Eviar duplicado
                // Cargar localidades desde la lógica y mostrarlas en el DataGridView
                Logica_localidades logicaLocalidades = new Logica_localidades();

                if (logicaLocalidades.TieneLocalidades()) //Tiene localidades
                {
                    var listaLocalidades = logicaLocalidades.Listar(); // Obtener la lista de localidades
                    for (int i = 0; i < listaLocalidades.Count; i++)
                    {
                        if (listaLocalidades[i] != null) // Verificar que la localidad no sea nula
                        {
                            comboBoxLocalidad.Items.Add(listaLocalidades[i]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Localidades: " + ex.Message);
            }
        }

        //Metodo que carga los clientes registrados en el combox correspondiente
        public void cargarClientes()
        {
            try
            {
                comboBoxCliente.Items.Clear();
                // Cargar clientes desde la lógica y mostrarlas en el DataGridView
                Logica_Clientes logicaClientes = new Logica_Clientes();

                if (logicaClientes.TieneClientes()) //Tiene clientes
                {
                    var listaClientes = logicaClientes.Listar(); // Obtener la lista de clientes
                    for (int i = 0; i < listaClientes.Count; i++)
                    {
                        if (listaClientes[i] != null) // Verificar que clientes no sea nula
                        {
                            comboBoxCliente.Items.Add(listaClientes[i]); //cargamos datos 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        //Metodo que carga los vendedores registrados en el combox correspondiente
        public void cargarVendedores()
        {
            try
            {
                comboBoxVendedor.Items.Clear();
                // Cargar clientes desde la lógica y mostrarlas en el DataGridView
                Logica_Vendedores logicaVendedores = new Logica_Vendedores();

                if (logicaVendedores.TieneVendedores()) //Tiene vendedores
                {
                    var listaVendedores = logicaVendedores.Listar(); // Obtener la lista de vendedores
                    for (int i = 0; i < listaVendedores.Count; i++)
                    {
                        if (listaVendedores[i] != null) // Verificar que clientes no sea nula
                        {
                            comboBoxVendedor.Items.Add(listaVendedores[i]); //cargamos datos 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vendedores: " + ex.Message);
            }
        }

        //Metodo que carga los partidos registrados en el combox correspondiente
        public void cargarPartidos()
        {
            try
            {
                comboBoxPartido.Items.Clear();
                // Cargar partidosdesde la lógica y mostrarlas en el DataGridView
                Logica_Partidos logica_Partidos = new Logica_Partidos();

                if (logica_Partidos.TienePartidos()) //Tiene partidos
                {
                    var listaPartidos = logica_Partidos.Listar(); // Obtener la lista de partidos
                    for (int i = 0; i < listaPartidos.Count; i++)
                    {
                        if (listaPartidos[i] != null) // Verificar que partidos no sea nula
                        {
                            comboBoxPartido.Items.Add(listaPartidos[i]); //cargamos datos 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los partidos " + ex.Message);
            }
        }

        private void comboBoxLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }

}
