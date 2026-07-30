namespace Servidor.Registros
{
    partial class RegistroVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroVenta));
            panel9 = new Panel();
            panel10 = new Panel();
            label20 = new Label();
            btn_limpiar = new Button();
            panel8 = new Panel();
            comboBoxLocalidad = new ComboBox();
            comboBoxPartido = new ComboBox();
            label14 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            txtTipo = new TextBox();
            label3 = new Label();
            comboBoxVendedor = new ComboBox();
            label11 = new Label();
            label4 = new Label();
            txtMontototal = new TextBox();
            txtCantidad = new TextBox();
            label12 = new Label();
            panel4 = new Panel();
            label13 = new Label();
            panel5 = new Panel();
            label1 = new Label();
            date_venta = new DateTimePicker();
            panel2 = new Panel();
            comboBoxCliente = new ComboBox();
            label2 = new Label();
            button2 = new Button();
            btn_guardar = new Button();
            panel6 = new Panel();
            label15 = new Label();
            panel7 = new Panel();
            label16 = new Label();
            button4 = new Button();
            label6 = new Label();
            panel1 = new Panel();
            btn_atras = new Button();
            data_Venta = new DataGridView();
            btn_salir = new Button();
            label5 = new Label();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Venta).BeginInit();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.BackColor = Color.Snow;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(btn_limpiar);
            panel9.Controls.Add(panel8);
            panel9.Controls.Add(panel3);
            panel9.Controls.Add(panel4);
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(panel2);
            panel9.Controls.Add(button2);
            panel9.Controls.Add(btn_guardar);
            panel9.Controls.Add(panel6);
            panel9.Controls.Add(panel7);
            panel9.Controls.Add(button4);
            panel9.Location = new Point(34, 86);
            panel9.Name = "panel9";
            panel9.Size = new Size(731, 483);
            panel9.TabIndex = 101;
            // 
            // panel10
            // 
            panel10.BackColor = Color.SandyBrown;
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Controls.Add(label20);
            panel10.Location = new Point(368, 174);
            panel10.Name = "panel10";
            panel10.Size = new Size(312, 42);
            panel10.TabIndex = 88;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(53, -8);
            label20.Name = "label20";
            label20.Size = new Size(167, 68);
            label20.TabIndex = 86;
            label20.Text = "Datos Partido";
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.Moccasin;
            btn_limpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("Rockwell", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar.ForeColor = SystemColors.ControlText;
            btn_limpiar.Location = new Point(353, 417);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(122, 39);
            btn_limpiar.TabIndex = 91;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(comboBoxLocalidad);
            panel8.Controls.Add(comboBoxPartido);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(label10);
            panel8.Location = new Point(368, 215);
            panel8.Name = "panel8";
            panel8.Size = new Size(312, 186);
            panel8.TabIndex = 89;
            // 
            // comboBoxLocalidad
            // 
            comboBoxLocalidad.FormattingEnabled = true;
            comboBoxLocalidad.Location = new Point(124, 47);
            comboBoxLocalidad.Name = "comboBoxLocalidad";
            comboBoxLocalidad.Size = new Size(151, 28);
            comboBoxLocalidad.TabIndex = 64;
            comboBoxLocalidad.SelectedIndexChanged += comboBoxLocalidad_SelectedIndexChanged;
            // 
            // comboBoxPartido
            // 
            comboBoxPartido.FormattingEnabled = true;
            comboBoxPartido.Location = new Point(124, 13);
            comboBoxPartido.Name = "comboBoxPartido";
            comboBoxPartido.Size = new Size(151, 28);
            comboBoxPartido.TabIndex = 63;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ControlText;
            label14.Location = new Point(18, 19);
            label14.Name = "label14";
            label14.Size = new Size(77, 20);
            label14.TabIndex = 62;
            label14.Text = "Partido:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(18, 54);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 48;
            label10.Text = "Localidad:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(txtTipo);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(comboBoxVendedor);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtMontototal);
            panel3.Controls.Add(txtCantidad);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(19, 215);
            panel3.Name = "panel3";
            panel3.Size = new Size(312, 186);
            panel3.TabIndex = 88;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(143, 142);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(147, 27);
            txtTipo.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(44, 140);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 66;
            label3.Text = "Tipo:";
            // 
            // comboBoxVendedor
            // 
            comboBoxVendedor.FormattingEnabled = true;
            comboBoxVendedor.Location = new Point(143, 25);
            comboBoxVendedor.Name = "comboBoxVendedor";
            comboBoxVendedor.Size = new Size(147, 28);
            comboBoxVendedor.TabIndex = 65;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(50, 68);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 62;
            label11.Text = "Monto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(39, 25);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 46;
            label4.Text = "Vendedor:";
            // 
            // txtMontototal
            // 
            txtMontototal.Location = new Point(143, 65);
            txtMontototal.Name = "txtMontototal";
            txtMontototal.Size = new Size(147, 27);
            txtMontototal.TabIndex = 52;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(143, 107);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(147, 27);
            txtCantidad.TabIndex = 60;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(44, 110);
            label12.Name = "label12";
            label12.Size = new Size(93, 20);
            label12.TabIndex = 58;
            label12.Text = "Cantidad:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label13);
            panel4.Location = new Point(19, 174);
            panel4.Name = "panel4";
            panel4.Size = new Size(312, 42);
            panel4.TabIndex = 87;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(73, -8);
            label13.Name = "label13";
            label13.Size = new Size(151, 68);
            label13.TabIndex = 86;
            label13.Text = "Datos Venta";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label1);
            panel5.Controls.Add(date_venta);
            panel5.Location = new Point(368, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(312, 84);
            panel5.TabIndex = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(41, 11);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 47;
            label1.Text = "Venta:";
            // 
            // date_venta
            // 
            date_venta.Location = new Point(123, 11);
            date_venta.Name = "date_venta";
            date_venta.Size = new Size(173, 27);
            date_venta.TabIndex = 62;
            date_venta.Value = new DateTime(2026, 7, 4, 0, 0, 0, 0);
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(comboBoxCliente);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(19, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 87);
            panel2.TabIndex = 85;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(105, 16);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(151, 28);
            comboBoxCliente.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(22, 25);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 46;
            label2.Text = "Cliente:";
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
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Moccasin;
            btn_guardar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Font = new Font("Rockwell", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar.ForeColor = SystemColors.ControlText;
            btn_guardar.Location = new Point(209, 417);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(122, 39);
            btn_guardar.TabIndex = 53;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
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
            label15.Location = new Point(7, -2);
            label15.Name = "label15";
            label15.Size = new Size(262, 68);
            label15.TabIndex = 86;
            label15.Text = "Información del cliente";
            // 
            // panel7
            // 
            panel7.BackColor = Color.SandyBrown;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(label16);
            panel7.Location = new Point(368, 17);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(224, 21);
            label6.Name = "label6";
            label6.Size = new Size(277, 48);
            label6.TabIndex = 103;
            label6.Text = "Registro Ventas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(btn_atras);
            panel1.Controls.Add(data_Venta);
            panel1.Controls.Add(btn_salir);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 827);
            panel1.TabIndex = 104;
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(3, 785);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(38, 39);
            btn_atras.TabIndex = 45;
            btn_atras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_atras.UseVisualStyleBackColor = false;
            btn_atras.Click += btn_atras_Click;
            // 
            // data_Venta
            // 
            data_Venta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_Venta.Location = new Point(34, 628);
            data_Venta.Name = "data_Venta";
            data_Venta.RowHeadersWidth = 51;
            data_Venta.Size = new Size(731, 151);
            data_Venta.TabIndex = 54;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Transparent;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.Location = new Point(771, 785);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(35, 39);
            btn_salir.TabIndex = 44;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(34, 605);
            label5.Name = "label5";
            label5.Size = new Size(193, 20);
            label5.TabIndex = 55;
            label5.Text = "Registros  realizados:";
            // 
            // RegistroVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 860);
            Controls.Add(panel1);
            Name = "RegistroVenta";
            Text = "RegistroVenta";
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_Venta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel9;
        private Button btn_limpiar;
        private Panel panel5;
        private Label label1;
        private DateTimePicker date_venta;
        private Panel panel2;
        private Label label2;
        private TextBox txt_cliente;
        private Button button2;
        private Button btn_guardar;
        private Panel panel6;
        private Label label15;
        private Panel panel7;
        private Label label16;
        private Button button4;
        private Label label6;
        private Panel panel1;
        private Button btn_atras;
        private DataGridView data_Venta;
        private Button btn_salir;
        private Label label5;
        private Panel panel3;
        private Label label4;
        private TextBox textBox1;
        private Label label10;
        private TextBox txtMontototal;
        private TextBox txtCantidad;
        private Label label12;
        private Panel panel4;
        private Label label13;
        private Panel panel10;
        private Label label20;
        private Panel panel8;
        private Label label14;
        private Label label11;
        private ComboBox comboBoxLocalidad;
        private ComboBox comboBoxPartido;
        private ComboBox comboBoxVendedor;
        private ComboBox comboBoxCliente;
        private TextBox txtTipo;
        private Label label3;
    }
}