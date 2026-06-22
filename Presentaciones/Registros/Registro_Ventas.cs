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
Descripción: Este formulario permite registrar las ventas, ademas carga datos de otro formularios como cliente, vendedor
localidades y partidos, los cuales son clave para la venta de entradas. 
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Presentaciones.Registros
{
    public partial class Registro_Ventas : Form
    {
        public Registro_Ventas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            configurar_data_ventas();
            cargarLocalidades();
            cargarPartidos();
            cargarClientes();
            cargarVendedores();

            txt_montoTotal.ReadOnly = true; //Inaviliatr el montototal
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Validamos que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txt_idventa.Text) ||
               comboBox_Cliente.SelectedItem == null ||
               comboBox_Partido.SelectedItem == null ||
               comboBox_Localidad.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txt_cantidad.Text) ||
               comboBox_Vendedor.SelectedItem == null )               
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            try
            {
                //Referencia a la clase Localidad
                Ventas venta = new Ventas();

                //asignamos los datos ingresados a la clase Localidad
                venta.IdVenta = int.Parse(txt_idventa.Text); // Convertir el texto a entero
                venta.Clientes = (Clientes)comboBox_Cliente.SelectedItem;
                venta.Partidos = (Partidos)comboBox_Partido.SelectedItem;
                venta.Localidades = (Localidades)comboBox_Localidad.SelectedItem;
               //validamos que solo numeros
                if (!int.TryParse(txt_cantidad.Text, out int cantidad))
                {
                    MessageBox.Show("Cantidad inválida");
                    return;
                }
                venta.Cantidad = int.Parse(txt_cantidad.Text);
                venta.Vendedores = (Vendedores)comboBox_Vendedor.SelectedItem;
                venta.FechaVenta = date_fechaVenta.Value;
                venta.TipoVenta = "Boleteria";

                Logica_Ventas logicaVentas = new Logica_Ventas(); //Instancia de la clase Logica ventas

                // Llamamos al método Agregar de la clase Logica ventas para agregar la venta
                if (logicaVentas.Agregar(venta))
                {
                    CargarVentas(); // Recargar el DataGridView para mostrar la nueva venta
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error No se permiten IDs repetidos o se alcanzó el límite de 200 registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu_Registros ventana_registros = new Menu_Registros();
            ventana_registros.Show(this);
            Dispose();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Partido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void data_Venta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Metodo para configurar la data de ventas
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
            txt_idventa.Clear();
            txt_cantidad.Clear();
            txt_montoTotal.Clear();

            comboBox_Cliente.SelectedIndex = -1;
            comboBox_Partido.SelectedIndex = -1;
            comboBox_Localidad.SelectedIndex = -1;
            comboBox_Vendedor.SelectedIndex = -1;
            comboBox_tipoVenta.SelectedIndex = -1;

            date_fechaVenta.Value = DateTime.Now;

            txt_idventa.Focus();
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
                var listaVentas = logica_Ventas.Listar(); // Obtener la lista de Ventas
                for (int i = 0; i < listaVentas.Length; i++)
                {
                    if (listaVentas[i] != null) // Verificar que la localidad no sea nula
                    {
                        Ventas Venta = listaVentas[i]; // Obtener la Ventas actual
                        data_Venta.Rows.Add(
                            Venta.IdVenta,
                            Venta.Clientes.Nombre,
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
            }
        }

        //Metodo que carga las localidades registradas
        public void cargarLocalidades()
        {
            try
            {
                comboBox_Localidad.Items.Clear(); //Eviar duplicado
                // Cargar localidades desde la lógica y mostrarlas en el DataGridView
                Logica_localidades logicaLocalidades = new Logica_localidades();

                if (logicaLocalidades.TieneLocalidades()) //Tiene localidades
                {
                    var listaLocalidades = logicaLocalidades.Listar(); // Obtener la lista de localidades
                    for (int i = 0; i < listaLocalidades.Length; i++)
                    {
                        if (listaLocalidades[i] != null) // Verificar que la localidad no sea nula
                        {
                            comboBox_Localidad.Items.Add(listaLocalidades[i]);
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
                comboBox_Cliente.Items.Clear();
                // Cargar clientes desde la lógica y mostrarlas en el DataGridView
                Logica_Clientes logicaClientes = new Logica_Clientes();

                if (logicaClientes.TieneClientes()) //Tiene clientes
                {
                    var listaClientes = logicaClientes.Listar(); // Obtener la lista de clientes
                    for (int i = 0; i < listaClientes.Length; i++)
                    {
                        if (listaClientes[i] != null) // Verificar que clientes no sea nula
                        {
                            comboBox_Cliente.Items.Add(listaClientes[i]); //cargamos datos 
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
                comboBox_Vendedor.Items.Clear();
                // Cargar clientes desde la lógica y mostrarlas en el DataGridView
                Logica_Vendedores logicaVendedores = new Logica_Vendedores();

                if (logicaVendedores.TieneVendedores()) //Tiene vendedores
                {
                    var listaVendedores = logicaVendedores.Listar(); // Obtener la lista de vendedores
                    for (int i = 0; i < listaVendedores.Length; i++)
                    {
                        if (listaVendedores[i] != null) // Verificar que clientes no sea nula
                        {
                            comboBox_Vendedor.Items.Add(listaVendedores[i]); //cargamos datos 
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
                comboBox_Partido.Items.Clear();
                // Cargar partidosdesde la lógica y mostrarlas en el DataGridView
                Logica_Partidos logica_Partidos = new Logica_Partidos();

                if (logica_Partidos.TienePartidos()) //Tiene partidos
                {
                    var listaPartidos = logica_Partidos.Listar(); // Obtener la lista de partidos
                    for (int i = 0; i < listaPartidos.Length; i++)
                    {
                        if (listaPartidos[i] != null) // Verificar que partidos no sea nula
                        {
                            comboBox_Partido.Items.Add(listaPartidos[i]); //cargamos datos 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los partidos " + ex.Message);
            }
        }

        private void txt_montoTotal_TextChanged(object sender, EventArgs e)
        {

        }
        //Permite calcular el total
        private void CalcularTotal()
        {
            if (comboBox_Localidad.SelectedItem == null) return;

            if (!int.TryParse(txt_cantidad.Text, out int cantidad) || cantidad <= 0)
            {
                txt_montoTotal.Clear();
                return;
            }

            Localidades localidad = (Localidades)comboBox_Localidad.SelectedItem;

            decimal total = cantidad * localidad.Precio;

            txt_montoTotal.Text = total.ToString("0.00");
        }
       
        private void comboBox_Localidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }
}

