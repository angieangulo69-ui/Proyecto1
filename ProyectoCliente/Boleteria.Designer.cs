namespace ProyectoCliente
{
    partial class Boleteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boleteria));
            panel9 = new Panel();
            panel3 = new Panel();
            comboBoxLocalidad = new ComboBox();
            txtCantidad = new TextBox();
            lblMontoTotal = new Label();
            label12 = new Label();
            label4 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtPrecio = new TextBox();
            label13 = new Label();
            panel4 = new Panel();
            label14 = new Label();
            panel5 = new Panel();
            comboBoxPartido = new ComboBox();
            label22 = new Label();
            label1 = new Label();
            date_hora = new DateTimePicker();
            date_partido = new DateTimePicker();
            label9 = new Label();
            btn_limpiar = new Button();
            panel2 = new Panel();
            txt_identificacion = new TextBox();
            label21 = new Label();
            txt_nombreCliente = new TextBox();
            lbl_cliente = new Label();
            label2 = new Label();
            label7 = new Label();
            button2 = new Button();
            btn_comprar = new Button();
            panel6 = new Panel();
            label15 = new Label();
            panel7 = new Panel();
            label16 = new Label();
            button4 = new Button();
            label6 = new Label();
            panel1 = new Panel();
            btn_atras = new Button();
            data_compras = new DataGridView();
            btn_salir = new Button();
            label5 = new Label();
            panel9.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_compras).BeginInit();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.BackColor = Color.Snow;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(panel3);
            panel9.Controls.Add(panel4);
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(btn_limpiar);
            panel9.Controls.Add(panel2);
            panel9.Controls.Add(button2);
            panel9.Controls.Add(btn_comprar);
            panel9.Controls.Add(panel6);
            panel9.Controls.Add(panel7);
            panel9.Controls.Add(button4);
            panel9.Location = new Point(13, 86);
            panel9.Name = "panel9";
            panel9.Size = new Size(986, 316);
            panel9.TabIndex = 101;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(comboBoxLocalidad);
            panel3.Controls.Add(txtCantidad);
            panel3.Controls.Add(lblMontoTotal);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtPrecio);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(655, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(312, 154);
            panel3.TabIndex = 88;
            // 
            // comboBoxLocalidad
            // 
            comboBoxLocalidad.FormattingEnabled = true;
            comboBoxLocalidad.Location = new Point(131, 9);
            comboBoxLocalidad.Name = "comboBoxLocalidad";
            comboBoxLocalidad.Size = new Size(149, 28);
            comboBoxLocalidad.TabIndex = 107;
            comboBoxLocalidad.SelectedIndexChanged += comboBoxLocalidad_SelectedIndexChanged_1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(130, 85);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(150, 27);
            txtCantidad.TabIndex = 109;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.BackColor = Color.Transparent;
            lblMontoTotal.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            lblMontoTotal.ForeColor = SystemColors.ControlText;
            lblMontoTotal.Location = new Point(130, 118);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(0, 20);
            lblMontoTotal.TabIndex = 108;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(6, 118);
            label12.Name = "label12";
            label12.Size = new Size(118, 20);
            label12.TabIndex = 107;
            label12.Text = "Monto Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(99, 14);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 104;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(17, 17);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 46;
            label10.Text = "Localidad:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(47, 56);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 48;
            label11.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(130, 53);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 27);
            txtPrecio.TabIndex = 52;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(30, 90);
            label13.Name = "label13";
            label13.Size = new Size(93, 20);
            label13.TabIndex = 58;
            label13.Text = "Cantidad:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label14);
            panel4.Location = new Point(655, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(312, 42);
            panel4.TabIndex = 87;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(96, -2);
            label14.Name = "label14";
            label14.Size = new Size(110, 68);
            label14.TabIndex = 86;
            label14.Text = "Compra";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(comboBoxPartido);
            panel5.Controls.Add(label22);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(date_hora);
            panel5.Controls.Add(date_partido);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(337, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(312, 151);
            panel5.TabIndex = 90;
            // 
            // comboBoxPartido
            // 
            comboBoxPartido.FormattingEnabled = true;
            comboBoxPartido.Location = new Point(104, 16);
            comboBoxPartido.Name = "comboBoxPartido";
            comboBoxPartido.Size = new Size(174, 28);
            comboBoxPartido.TabIndex = 106;
            comboBoxPartido.SelectedIndexChanged += comboBoxPartido_SelectedIndexChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label22.ForeColor = SystemColors.ControlText;
            label22.Location = new Point(22, 27);
            label22.Name = "label22";
            label22.Size = new Size(77, 20);
            label22.TabIndex = 105;
            label22.Text = "Partido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(32, 59);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 47;
            label1.Text = "Fecha";
            // 
            // date_hora
            // 
            date_hora.Location = new Point(105, 96);
            date_hora.Name = "date_hora";
            date_hora.Size = new Size(173, 27);
            date_hora.TabIndex = 63;
            date_hora.Value = new DateTime(2026, 7, 4, 0, 0, 0, 0);
            // 
            // date_partido
            // 
            date_partido.Location = new Point(105, 54);
            date_partido.Name = "date_partido";
            date_partido.Size = new Size(173, 27);
            date_partido.TabIndex = 62;
            date_partido.Value = new DateTime(2026, 7, 4, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(37, 96);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 59;
            label9.Text = "Hora:";
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.Moccasin;
            btn_limpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("Rockwell", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar.ForeColor = SystemColors.ControlText;
            btn_limpiar.Location = new Point(486, 247);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(122, 39);
            btn_limpiar.TabIndex = 91;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txt_identificacion);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(txt_nombreCliente);
            panel2.Controls.Add(lbl_cliente);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(19, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 154);
            panel2.TabIndex = 85;
            // 
            // txt_identificacion
            // 
            txt_identificacion.Location = new Point(148, 86);
            txt_identificacion.Name = "txt_identificacion";
            txt_identificacion.Size = new Size(147, 27);
            txt_identificacion.TabIndex = 106;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label21.ForeColor = SystemColors.ControlText;
            label21.Location = new Point(53, 48);
            label21.Name = "label21";
            label21.Size = new Size(84, 20);
            label21.TabIndex = 105;
            label21.Text = "Nombre:";
            // 
            // txt_nombreCliente
            // 
            txt_nombreCliente.Location = new Point(148, 48);
            txt_nombreCliente.Name = "txt_nombreCliente";
            txt_nombreCliente.Size = new Size(147, 27);
            txt_nombreCliente.TabIndex = 105;
            // 
            // lbl_cliente
            // 
            lbl_cliente.AutoSize = true;
            lbl_cliente.BackColor = Color.Transparent;
            lbl_cliente.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            lbl_cliente.ForeColor = SystemColors.ControlText;
            lbl_cliente.Location = new Point(99, 14);
            lbl_cliente.Name = "lbl_cliente";
            lbl_cliente.Size = new Size(0, 20);
            lbl_cliente.TabIndex = 104;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(22, 14);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 46;
            label2.Text = "Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(7, 88);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 57;
            label7.Text = "Identificación:";
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
            // btn_comprar
            // 
            btn_comprar.BackColor = Color.Moccasin;
            btn_comprar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_comprar.Cursor = Cursors.Hand;
            btn_comprar.Font = new Font("Rockwell", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_comprar.ForeColor = SystemColors.ControlText;
            btn_comprar.Location = new Point(340, 247);
            btn_comprar.Name = "btn_comprar";
            btn_comprar.Size = new Size(122, 39);
            btn_comprar.TabIndex = 53;
            btn_comprar.Text = "Comprar";
            btn_comprar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_comprar.UseVisualStyleBackColor = false;
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
            label15.Location = new Point(37, -2);
            label15.Name = "label15";
            label15.Size = new Size(243, 68);
            label15.TabIndex = 86;
            label15.Text = "Identificación Cliente";
            // 
            // panel7
            // 
            panel7.BackColor = Color.SandyBrown;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(label16);
            panel7.Location = new Point(337, 17);
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
            label16.Location = new Point(53, -8);
            label16.Name = "label16";
            label16.Size = new Size(202, 68);
            label16.TabIndex = 86;
            label16.Text = "Datos del Partido";
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
            label6.Location = new Point(407, 15);
            label6.Name = "label6";
            label6.Size = new Size(168, 48);
            label6.TabIndex = 103;
            label6.Text = "Boletería";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(btn_atras);
            panel1.Controls.Add(data_compras);
            panel1.Controls.Add(btn_salir);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(29, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 641);
            panel1.TabIndex = 104;
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(13, 588);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(38, 39);
            btn_atras.TabIndex = 45;
            btn_atras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_atras.UseVisualStyleBackColor = false;
            // 
            // data_compras
            // 
            data_compras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_compras.Location = new Point(76, 482);
            data_compras.Name = "data_compras";
            data_compras.RowHeadersWidth = 51;
            data_compras.Size = new Size(906, 107);
            data_compras.TabIndex = 54;
            data_compras.CellContentClick += data_compras_CellContentClick;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Transparent;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.Location = new Point(988, 588);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(31, 39);
            btn_salir.TabIndex = 44;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(18, 447);
            label5.Name = "label5";
            label5.Size = new Size(186, 20);
            label5.TabIndex = 55;
            label5.Text = "Compras realizados:";
            // 
            // Boleteria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 686);
            Controls.Add(panel1);
            Name = "Boleteria";
            Text = "Boleteria";
            panel9.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)data_compras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel9;
        private Button btn_limpiar;
        private Panel panel5;
        private Label label1;
        private DateTimePicker date_hora;
        private DateTimePicker date_partido;
        private Label label9;
        private Panel panel2;
        private Label label2;
        private Label label7;
        private Button button2;
        private Button btn_comprar;
        private Panel panel6;
        private Label label15;
        private Panel panel7;
        private Label label16;
        private Button button4;
        private Label label6;
        private Panel panel1;
        private Button btn_atras;
        private DataGridView data_compras;
        private Button btn_salir;
        private Label label5;
        private Panel panel3;
        private Label label4;
        private Label label10;
        private Label label11;
        private TextBox txtPrecio;
        private Label label13;
        private Panel panel4;
        private Label label14;
        private Label lbl_cliente;
        private Label label22;
        private Label label21;
        private TextBox txt_nombreCliente;
        private Label lblMontoTotal;
        private Label label12;
        private TextBox txt_identificacion;
        private ComboBox comboBoxLocalidad;
        private TextBox txtCantidad;
        private ComboBox comboBoxPartido;
    }
}