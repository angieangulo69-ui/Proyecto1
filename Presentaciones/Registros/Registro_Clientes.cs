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
    public partial class Registro_Clientes : Form

    {
        Logica_Clientes logicaCliente = new Logica_Clientes(); //Creamos un objeto
        public Registro_Clientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            configurar_data_clientes();
            cargar_Clientes();
        }

        private void Registro_Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            {
                //Validamos los campos no esten vacios 
                if (string.IsNullOrWhiteSpace(txt_idcliente.Text) || string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_apellido.Text))
                {
                    MessageBox.Show("Por favor, complete todos los espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // validamos que solo sean numeros
                if (!int.TryParse(txt_idcliente.Text, out int idVendedor))
                {
                    MessageBox.Show("El Id del cliente debe ser numérico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_idcliente.Focus();
                    return;
                }

                //Referenciamos a la clase vendedor
                Clientes cliente = new Clientes();

                //Asignamos los valores a las propiedades del nuevo partido
                cliente.IdCliente = int.Parse(txt_idcliente.Text);
                cliente.Apellido = txt_apellido.Text;
                cliente.Nombre = txt_nombre.Text;
                cliente.Identificacion = mask_identificacion.Text;
                cliente.FechaRegistro = date_fecharegistro.Value;
                cliente.FechaNacimiento = date_fechanacimiento.Value;
                cliente.Activo = checkBox_activo.Checked;

                //Instanciamos la calse logica

                String mensaje = logicaCliente.validacionesCliente(cliente);
                // 
                if (!String.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Si 
                if (logicaCliente.Agregar(cliente))
                {
                    MessageBox.Show("Cliente registrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    cargar_Clientes();
                }
                else
                {
                    MessageBox.Show("Error al registrar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu_Registros ventana_Registros = new Menu_Registros();
            ventana_Registros.Show(this);
            Dispose();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_activo_CheckedChanged(object sender, EventArgs e)
        {

        }
        //Metodo para  limpiar campos deo form
        public void limpiar()
        {
            txt_apellido.Clear();
            mask_identificacion.Clear();
            txt_idcliente.Clear();
            txt_nombre.Clear();
            date_fecharegistro.Value = DateTime.Now;
            date_fechanacimiento.Value = DateTime.Now;
            checkBox_activo.Checked = false;

        }
        //Configuracion de mi data 
        public void configurar_data_clientes()
        {
            //  configurar las columnas
            data_cliente.Columns.Add("IdCliente", "Id Cliente");
            data_cliente.Columns.Add("Identificacion", "Identificación");
            data_cliente.Columns.Add("Nombre", "Nombre");
            data_cliente.Columns.Add("Apellido", "Apellido");
            data_cliente.Columns.Add("FechaNacimiento", "Fecha Nacimiento");
            data_cliente.Columns.Add("FechaRegistro", "Fecha Registro");
            data_cliente.Columns.Add("Activo", "Activo");

            //Cconfiguracion adicional
            data_cliente.AutoGenerateColumns = false;
            data_cliente.ReadOnly = true;
            data_cliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Metodo para cargar los vendedores registrados 
        public void cargar_Clientes()
        {
            

            data_cliente.Rows.Clear(); //limpiamos para evitar duplicados

            if (logicaCliente.TieneClientes())
            {
                var lista_cliente = logicaCliente.Listar(); //Obtenemos las lista de partidos
                for (int i = 0; i < lista_cliente.Length; i++)
                {
                    if (lista_cliente[i] != null)
                    {
                        Clientes cliente = lista_cliente[i];
                        data_cliente.Rows.Add(
                           cliente.IdCliente,
                           cliente.Identificacion,
                           cliente.Nombre,
                            cliente.Apellido,
                            cliente.FechaNacimiento.ToShortDateString(),
                             cliente.FechaRegistro.ToShortDateString(),
                        cliente.Activo.ToString());
                    }
                }
            }
        }
    }

}