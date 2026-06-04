using System;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class RegistroLocalidad : Form
    {
        public RegistroLocalidad()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos campos
                if(string.IsNullOrWhiteSpace(txt_nombrelocalidad.Text))
                {
                    MessageBox.Show("El campo Nombre Localidad es obligatorio.");
                    txt_nombrelocalidad.Focus();
                    return;
                }
                if(string.IsNullOrWhiteSpace(txt_precio.Text))
                {
                    MessageBox.Show("El campo Precio es obligatorio.");
                    txt_precio.Focus();
                    return;
                }
                if (!decimal.TryParse(txt_precio.Text.Trim(), out decimal precio))
                {
                    MessageBox.Show("El campo Precio debe ser un número válido.");
                    txt_precio.Focus();
                    return;
                }

                //Obtenemos los datos ingresados
                String Nombre = txt_nombrelocalidad.Text.Trim();
                decimal Precio = decimal.Parse(txt_precio.Text.Trim());

                //Creamos un nuevo objeto Localidad
                RegistroLocalidad localidad = new RegistroLocalidad();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message);
            }
            //Obtenemos los datos ingresados




        }

        //Metodo para limpiar los campos despues de guardar  un registro
        public void limpiar() 
        { 
            txt_nombrelocalidad.Text = "";
            txt_precio.Text = "";
            lbl_idlocalidad.Focus();
        }
    }
}
