namespace Presentaciones.Registros
{
    partial class Registro_Vendedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Vendedores));
            label5 = new Label();
            data_vendedores = new DataGridView();
            btn_guardar = new Button();
            txt_nombre = new TextBox();
            txt_idvendedor = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btn_atras = new Button();
            btn_salir = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_apellido = new TextBox();
            mask_identificacion = new MaskedTextBox();
            date_fechanacimiento = new DateTimePicker();
            date_fechaingreso = new DateTimePicker();
            panel9 = new Panel();
            btn_limpiar = new Button();
            panel5 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            panel6 = new Panel();
            label15 = new Label();
            panel7 = new Panel();
            label16 = new Label();
            button4 = new Button();
            panel4 = new Panel();
            label6 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)data_vendedores).BeginInit();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(21, 421);
            label5.Name = "label5";
            label5.Size = new Size(193, 20);
            label5.TabIndex = 55;
            label5.Text = "Registros  realizados:";
            // 
            // data_vendedores
            // 
            data_vendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_vendedores.Location = new Point(34, 464);
            data_vendedores.Name = "data_vendedores";
            data_vendedores.RowHeadersWidth = 51;
            data_vendedores.Size = new Size(731, 160);
            data_vendedores.TabIndex = 54;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Moccasin;
            btn_guardar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Font = new Font("Rockwell", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar.ForeColor = SystemColors.ControlText;
            btn_guardar.Location = new Point(220, 254);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(122, 39);
            btn_guardar.TabIndex = 53;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(143, 92);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(147, 27);
            txt_nombre.TabIndex = 52;
            txt_nombre.TextChanged += txt_nombre_TextChanged;
            txt_nombre.KeyPress += txt_nombre_KeyPress;
            // 
            // txt_idvendedor
            // 
            txt_idvendedor.Location = new Point(143, 22);
            txt_idvendedor.Name = "txt_idvendedor";
            txt_idvendedor.Size = new Size(147, 27);
            txt_idvendedor.TabIndex = 50;
            txt_idvendedor.KeyPress += txt_idvendedor_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(53, 95);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 48;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 47;
            label1.Text = "Nacimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(22, 25);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 46;
            label2.Text = "Id Vendedor:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(21, 651);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(38, 39);
            btn_atras.TabIndex = 45;
            btn_atras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_atras.UseVisualStyleBackColor = false;
            btn_atras.Click += btn_atras_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Transparent;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.Location = new Point(762, 651);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(31, 39);
            btn_salir.TabIndex = 44;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(7, 58);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 57;
            label7.Text = "Identificación:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(53, 132);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 58;
            label8.Text = "Apellido:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(24, 59);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 59;
            label9.Text = "Ingreso:";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(143, 129);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(147, 27);
            txt_apellido.TabIndex = 60;
            txt_apellido.KeyPress += txt_apellido_KeyPress;
            // 
            // mask_identificacion
            // 
            mask_identificacion.Location = new Point(143, 55);
            mask_identificacion.Mask = "0-0000-0000";
            mask_identificacion.Name = "mask_identificacion";
            mask_identificacion.Size = new Size(147, 27);
            mask_identificacion.TabIndex = 61;
            // 
            // date_fechanacimiento
            // 
            date_fechanacimiento.Location = new Point(123, 11);
            date_fechanacimiento.Name = "date_fechanacimiento";
            date_fechanacimiento.Size = new Size(173, 27);
            date_fechanacimiento.TabIndex = 62;
            date_fechanacimiento.Value = new DateTime(2026, 7, 4, 0, 0, 0, 0);
            // 
            // date_fechaingreso
            // 
            date_fechaingreso.Location = new Point(123, 55);
            date_fechaingreso.Name = "date_fechaingreso";
            date_fechaingreso.Size = new Size(173, 27);
            date_fechaingreso.TabIndex = 63;
            date_fechaingreso.Value = new DateTime(2026, 7, 4, 0, 0, 0, 0);
            // 
            // panel9
            // 
            panel9.BackColor = Color.Snow;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(btn_limpiar);
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(panel2);
            panel9.Controls.Add(button2);
            panel9.Controls.Add(btn_guardar);
            panel9.Controls.Add(panel6);
            panel9.Controls.Add(panel7);
            panel9.Controls.Add(button4);
            panel9.Location = new Point(34, 86);
            panel9.Name = "panel9";
            panel9.Size = new Size(731, 313);
            panel9.TabIndex = 101;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.Moccasin;
            btn_limpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("Rockwell", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar.ForeColor = SystemColors.ControlText;
            btn_limpiar.Location = new Point(368, 254);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(122, 39);
            btn_limpiar.TabIndex = 91;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label1);
            panel5.Controls.Add(date_fechaingreso);
            panel5.Controls.Add(date_fechanacimiento);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(383, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(312, 173);
            panel5.TabIndex = 90;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_idvendedor);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(mask_identificacion);
            panel2.Controls.Add(txt_nombre);
            panel2.Controls.Add(txt_apellido);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(19, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 176);
            panel2.TabIndex = 85;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(3, 613);
            button2.Name = "button2";
            button2.Size = new Size(49, 49);
            button2.TabIndex = 65;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.SandyBrown;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(label15);
            panel6.Location = new Point(19, 17);
            panel6.Name = "panel6";
            panel6.Size = new Size(312, 42);
            panel6.TabIndex = 84;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(96, -2);
            label15.Name = "label15";
            label15.Size = new Size(172, 68);
            label15.TabIndex = 86;
            label15.Text = "Identificación ";
            // 
            // panel7
            // 
            panel7.BackColor = Color.SandyBrown;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(label16);
            panel7.Location = new Point(383, 17);
            panel7.Name = "panel7";
            panel7.Size = new Size(312, 42);
            panel7.TabIndex = 89;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(105, -8);
            label16.Name = "label16";
            label16.Size = new Size(99, 68);
            label16.TabIndex = 86;
            label16.Text = "Fechas";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(1004, 618);
            button4.Name = "button4";
            button4.Size = new Size(45, 49);
            button4.TabIndex = 64;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label6);
            panel4.Location = new Point(20, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(809, 61);
            panel4.TabIndex = 91;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(254, 0);
            label6.Name = "label6";
            label6.Size = new Size(360, 48);
            label6.TabIndex = 102;
            label6.Text = "Registro Vendedores";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(btn_atras);
            panel1.Controls.Add(data_vendedores);
            panel1.Controls.Add(btn_salir);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(20, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 703);
            panel1.TabIndex = 102;
            // 
            // Registro_Vendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(855, 752);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "Registro_Vendedores";
            Text = "Registro_Vendedores";
            Load += Registro_Vendedores_Load;
            ((System.ComponentModel.ISupportInitialize)data_vendedores).EndInit();
            panel9.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private DataGridView data_vendedores;
        private Button btn_guardar;
        private TextBox txt_nombre;
        private TextBox txt_idvendedor;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btn_atras;
        private Button btn_salir;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_apellido;
        private MaskedTextBox mask_identificacion;
        private DateTimePicker date_fechanacimiento;
        private DateTimePicker date_fechaingreso;
        private Panel panel9;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private Button button2;
        private Panel panel6;
        private Label label15;
        private Panel panel7;
        private Label label16;
        private Button button4;
        private Label label6;
        private Panel panel1;
        private Button btn_limpiar;
    }
}