using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
Descripción:formulario de regsitros de vendedores
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Presentaciones.Registros

{

    public partial class Registro_Vendedores : Form
    {
        public Registro_Vendedores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            configurar_data_vendedores();
            cargar_vendedores();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Validamos los campos no esten vacios 
            if (string.IsNullOrWhiteSpace(txt_idvendedor.Text) || string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_apellido.Text))
            {
                MessageBox.Show("Por favor, complete todos los espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // validamos que solo sean numeros
            if (!int.TryParse(txt_idvendedor.Text, out int idVendedor))
            {
                MessageBox.Show("El Id del vendedor debe ser numérico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_idvendedor.Focus();
                return;
            }

            //Referenciamos a la clase vendedor
            Vendedores vendedor = new Vendedores();

            //Asignamos los valores a las propiedades del nuevo partido
            vendedor.IdVendedor = int.Parse(txt_idvendedor.Text);
            vendedor.Apellido = txt_apellido.Text;
            vendedor.Nombre = txt_nombre.Text;
            vendedor.Identificacion = mask_identificacion.Text;
            vendedor.FechaIngreso = date_fechaingreso.Value;
            vendedor.FechaNacimiento = date_fechanacimiento.Value;

            //Instanciamos la calse logica

            Logica_Vendedores logica = new Logica_Vendedores(); //Creamos un objeto
            String mensaje = logica.validacionVendedor(vendedor);
            // 
            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Si 
            if (logica.Agregar(vendedor))
            {
                MessageBox.Show("Vendedor registrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                cargar_vendedores();
            }
            else
            {
                MessageBox.Show("Error al registrar el vendedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu_Registros ventana_registros = new Menu_Registros();
            ventana_registros.Show();
            Dispose();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Metodo para limpiar los campos
        public void limpiar()
        {
            txt_apellido.Clear();
            mask_identificacion.Clear();
            txt_idvendedor.Clear();
            txt_nombre.Clear();
            date_fechaingreso.Value = DateTime.Now;
            date_fechanacimiento.Value = DateTime.Now;

        }
        //Configuracion de mi data 
        public void configurar_data_vendedores()
        {
            //  configurar las columnas
            data_vendedores.Columns.Add("IdVendedor", "Id Vendedor");
            data_vendedores.Columns.Add("Identificacion", "Identificación");
            data_vendedores.Columns.Add("Nombre", "Nombre");
            data_vendedores.Columns.Add("Apellido", "Apellido");
            data_vendedores.Columns.Add("FechaNacimiento", "Fecha Nacimiento");
            data_vendedores.Columns.Add("FechaIngreso", "Fecha Ingreso");

            //Cconfiguracion adicional
            data_vendedores.AutoGenerateColumns = false;
            data_vendedores.ReadOnly = true;
            data_vendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_vendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Metodo para cargar los vendedores registrados 
        public void cargar_vendedores()
        {
            //cargar partidos desde la logica
            Logica_Vendedores logica_vendedor = new Logica_Vendedores();

            data_vendedores.Rows.Clear(); //limpiamos para evitar duplicados

            if (logica_vendedor.TieneVendedores())
            {
                var lista_vendedor = logica_vendedor.Listar(); //Obtenemos las lista de partidos
                for (int i = 0; i < lista_vendedor.Length; i++)
                {
                    if (lista_vendedor[i] != null)
                    {
                        Vendedores vendedor = lista_vendedor[i];
                        data_vendedores.Rows.Add(
                            vendedor.IdVendedor,
                            vendedor.Identificacion,
                            vendedor.Nombre,
                            vendedor.Apellido,
                            vendedor.FechaNacimiento.ToShortDateString(),
                             vendedor.FechaIngreso.ToShortDateString());
                    }
                }
            }
        }

        private void Registro_Vendedores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txt_idvendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validamos que solo se puedan ingresar numeros en el campo de id vendedor
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
                MessageBox.Show("Solo se permiten números en el campo de Id Vendedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validamos que solo se puedan ingresar letras en el campo de nombre
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
                MessageBox.Show("Solo se permiten letras en el campo de Nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validamos que solo se puedan ingresar letras en el campo de apellido
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
                MessageBox.Show("Solo se permiten letras en el campo de Apellido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
