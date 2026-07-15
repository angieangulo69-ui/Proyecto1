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
Descripción:formulario de regsitros de clientes registrados 
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
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
                cliente.Identificacion = mask_identificacion.Text.Replace("-", "");
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
            //CArgar cleintes
            Logica_Clientes logicaCliente = new Logica_Clientes();
            data_cliente.Rows.Clear(); //limpiamos para evitar duplicados

            if (logicaCliente.TieneClientes())
            {
                foreach(Clientes cliente in logicaCliente.Listar())
                {                                       
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
        

        private void txt_idcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
                MessageBox.Show("Solo se permiten números en el campo Id Cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {  // Validar que solo se ingresen letras y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignorar el carácter ingresado
                MessageBox.Show("Solo se permiten letras en el campo Nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {  // Validar que solo se ingresen letras y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignorar el carácter ingresado
                MessageBox.Show("Solo se permiten letras en el campo Apellido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}