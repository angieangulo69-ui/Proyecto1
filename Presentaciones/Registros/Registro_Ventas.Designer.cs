namespace Presentaciones.Registros
{
    partial class Registro_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Ventas));
            label5 = new Label();
            data_Venta = new DataGridView();
            btn_guardar = new Button();
            txt_idventa = new TextBox();
            label2 = new Label();
            btn_atras = new Button();
            btn_salir = new Button();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            comboBox_Cliente = new ComboBox();
            comboBox_Partido = new ComboBox();
            comboBox_Localidad = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            txt_cantidad = new TextBox();
            comboBox_Vendedor = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            date_fechaVenta = new DateTimePicker();
            txt_montoTotal = new TextBox();
            comboBox_tipoVenta = new ComboBox();
            panel9 = new Panel();
            btn_limpiar = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            panel8 = new Panel();
            label14 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            label15 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            panel6 = new Panel();
            label18 = new Label();
            panel7 = new Panel();
            label19 = new Label();
            button4 = new Button();
            panel10 = new Panel();
            label12 = new Label();
            panel11 = new Panel();
            ((System.ComponentModel.ISupportInitialize)data_Venta).BeginInit();
            panel9.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(30, 484);
            label5.Name = "label5";
            label5.Size = new Size(193, 20);
            label5.TabIndex = 100;
            label5.Text = "Registros  realizados:";
            // 
            // data_Venta
            // 
            data_Venta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_Venta.Location = new Point(30, 521);
            data_Venta.Name = "data_Venta";
            data_Venta.RowHeadersWidth = 51;
            data_Venta.Size = new Size(647, 109);
            data_Venta.TabIndex = 99;
            data_Venta.CellContentClick += data_Venta_CellContentClick;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.AntiqueWhite;
            btn_guardar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar.Location = new Point(522, 354);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(135, 36);
            btn_guardar.TabIndex = 98;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseCompatibleTextRendering = true;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_idventa
            // 
            txt_idventa.Location = new Point(109, 18);
            txt_idventa.Name = "txt_idventa";
            txt_idventa.Size = new Size(150, 27);
            txt_idventa.TabIndex = 97;
            txt_idventa.KeyPress += txt_idventa_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(4, 21);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 95;
            label2.Text = "Id Venta:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Bisque;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(5, 649);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(38, 39);
            btn_atras.TabIndex = 94;
            btn_atras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_atras.UseVisualStyleBackColor = false;
            btn_atras.Click += btn_atras_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Bisque;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.Location = new Point(663, 649);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 39);
            btn_salir.TabIndex = 93;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(10, 65);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 101;
            label1.Text = "Localidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(33, 23);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 102;
            label3.Text = "Partido:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(21, 57);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 103;
            label6.Text = "Cliente:";
            // 
            // comboBox_Cliente
            // 
            comboBox_Cliente.FormattingEnabled = true;
            comboBox_Cliente.Location = new Point(109, 57);
            comboBox_Cliente.Name = "comboBox_Cliente";
            comboBox_Cliente.Size = new Size(151, 28);
            comboBox_Cliente.TabIndex = 104;
            comboBox_Cliente.SelectedIndexChanged += comboBox_Cliente_SelectedIndexChanged;
            // 
            // comboBox_Partido
            // 
            comboBox_Partido.FormattingEnabled = true;
            comboBox_Partido.Location = new Point(119, 18);
            comboBox_Partido.Name = "comboBox_Partido";
            comboBox_Partido.Size = new Size(151, 28);
            comboBox_Partido.TabIndex = 105;
            comboBox_Partido.SelectedIndexChanged += comboBox_Partido_SelectedIndexChanged;
            // 
            // comboBox_Localidad
            // 
            comboBox_Localidad.FormattingEnabled = true;
            comboBox_Localidad.Location = new Point(119, 57);
            comboBox_Localidad.Name = "comboBox_Localidad";
            comboBox_Localidad.Size = new Size(151, 28);
            comboBox_Localidad.TabIndex = 106;
            comboBox_Localidad.SelectedIndexChanged += comboBox_Localidad_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(21, 46);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 107;
            label7.Text = "Cantidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(16, 82);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 108;
            label8.Text = "Vendedor:";
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(122, 46);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(169, 27);
            txt_cantidad.TabIndex = 109;
            txt_cantidad.TextChanged += txt_cantidad_TextChanged;
            // 
            // comboBox_Vendedor
            // 
            comboBox_Vendedor.FormattingEnabled = true;
            comboBox_Vendedor.Location = new Point(122, 79);
            comboBox_Vendedor.Name = "comboBox_Vendedor";
            comboBox_Vendedor.Size = new Size(169, 28);
            comboBox_Vendedor.TabIndex = 110;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(21, 44);
            label9.Name = "label9";
            label9.Size = new Size(107, 20);
            label9.TabIndex = 111;
            label9.Text = "Tipo Venta:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(10, 15);
            label10.Name = "label10";
            label10.Size = new Size(118, 20);
            label10.TabIndex = 112;
            label10.Text = "Monto Total:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(-2, 9);
            label11.Name = "label11";
            label11.Size = new Size(120, 20);
            label11.TabIndex = 113;
            label11.Text = "Fecha Venta:";
            // 
            // date_fechaVenta
            // 
            date_fechaVenta.CalendarTitleBackColor = Color.Transparent;
            date_fechaVenta.CustomFormat = "dd/MM/yyy";
            date_fechaVenta.Location = new Point(122, 7);
            date_fechaVenta.Name = "date_fechaVenta";
            date_fechaVenta.Size = new Size(169, 27);
            date_fechaVenta.TabIndex = 114;
            date_fechaVenta.Value = new DateTime(2026, 7, 4, 0, 0, 0, 0);
            // 
            // txt_montoTotal
            // 
            txt_montoTotal.Location = new Point(135, 9);
            txt_montoTotal.Name = "txt_montoTotal";
            txt_montoTotal.Size = new Size(150, 27);
            txt_montoTotal.TabIndex = 115;
            txt_montoTotal.TextChanged += txt_montoTotal_TextChanged;
            // 
            // comboBox_tipoVenta
            // 
            comboBox_tipoVenta.FormattingEnabled = true;
            comboBox_tipoVenta.Location = new Point(135, 44);
            comboBox_tipoVenta.Name = "comboBox_tipoVenta";
            comboBox_tipoVenta.Size = new Size(151, 28);
            comboBox_tipoVenta.TabIndex = 116;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Snow;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(btn_limpiar);
            panel9.Controls.Add(panel3);
            panel9.Controls.Add(panel1);
            panel9.Controls.Add(panel8);
            panel9.Controls.Add(btn_guardar);
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(panel4);
            panel9.Controls.Add(panel2);
            panel9.Controls.Add(button2);
            panel9.Controls.Add(panel6);
            panel9.Controls.Add(panel7);
            panel9.Controls.Add(button4);
            panel9.Location = new Point(32, 90);
            panel9.Name = "panel9";
            panel9.Size = new Size(681, 410);
            panel9.TabIndex = 117;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.AntiqueWhite;
            btn_limpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar.Location = new Point(368, 354);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(135, 36);
            btn_limpiar.TabIndex = 99;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limpiar.UseCompatibleTextRendering = true;
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(comboBox_tipoVenta);
            panel3.Controls.Add(txt_montoTotal);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(345, 216);
            panel3.Name = "panel3";
            panel3.Size = new Size(312, 121);
            panel3.TabIndex = 88;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(comboBox_Partido);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox_Localidad);
            panel1.Location = new Point(345, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 103);
            panel1.TabIndex = 92;
            // 
            // panel8
            // 
            panel8.BackColor = Color.SandyBrown;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(label14);
            panel8.Location = new Point(345, 170);
            panel8.Name = "panel8";
            panel8.Size = new Size(312, 42);
            panel8.TabIndex = 87;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(109, -7);
            label14.Name = "label14";
            label14.Size = new Size(80, 68);
            label14.TabIndex = 86;
            label14.Text = "Pago";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label11);
            panel5.Controls.Add(date_fechaVenta);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(txt_cantidad);
            panel5.Controls.Add(comboBox_Vendedor);
            panel5.Location = new Point(19, 219);
            panel5.Name = "panel5";
            panel5.Size = new Size(312, 118);
            panel5.TabIndex = 90;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label15);
            panel4.Location = new Point(345, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(312, 42);
            panel4.TabIndex = 91;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(45, -6);
            label15.Name = "label15";
            label15.Size = new Size(225, 68);
            label15.TabIndex = 86;
            label15.Text = "Detalles del Partido";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_idventa);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBox_Cliente);
            panel2.Location = new Point(19, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 103);
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
            panel6.Controls.Add(label18);
            panel6.Location = new Point(19, 17);
            panel6.Name = "panel6";
            panel6.Size = new Size(312, 42);
            panel6.TabIndex = 84;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(67, -6);
            label18.Name = "label18";
            label18.Size = new Size(172, 68);
            label18.TabIndex = 86;
            label18.Text = "Identificación ";
            // 
            // panel7
            // 
            panel7.BackColor = Color.SandyBrown;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(label19);
            panel7.Location = new Point(19, 171);
            panel7.Name = "panel7";
            panel7.Size = new Size(312, 42);
            panel7.TabIndex = 89;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(63, -8);
            label19.Name = "label19";
            label19.Size = new Size(151, 68);
            label19.TabIndex = 86;
            label19.Text = "Transaccion";
            label19.Click += label19_Click;
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
            // panel10
            // 
            panel10.BackColor = Color.SandyBrown;
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Controls.Add(label12);
            panel10.Location = new Point(7, 12);
            panel10.Name = "panel10";
            panel10.Size = new Size(720, 61);
            panel10.TabIndex = 118;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(118, 0);
            label12.Name = "label12";
            label12.Size = new Size(473, 48);
            label12.TabIndex = 102;
            label12.Text = "Registro Ventas de entradas";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Bisque;
            panel11.Controls.Add(label5);
            panel11.Controls.Add(data_Venta);
            panel11.Controls.Add(btn_salir);
            panel11.Controls.Add(btn_atras);
            panel11.Location = new Point(7, 40);
            panel11.Name = "panel11";
            panel11.Size = new Size(719, 702);
            panel11.TabIndex = 119;
            // 
            // Registro_Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(739, 751);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel11);
            Name = "Registro_Ventas";
            Text = "Registro_Ventas";
            Load += Registro_Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)data_Venta).EndInit();
            panel9.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private DataGridView data_Venta;
        private Button btn_guardar;
        private TextBox txt_idventa;
        private Label label2;
        private Button btn_atras;
        private Button btn_salir;
        private Label label1;
        private Label label3;
        private Label label6;
        private ComboBox comboBox_Cliente;
        private ComboBox comboBox_Partido;
        private ComboBox comboBox_Localidad;
        private Label label7;
        private Label label8;
        private TextBox txt_cantidad;
        private ComboBox comboBox_Vendedor;
        private Label label9;
        private Label label10;
        private Label label11;
        private DateTimePicker date_fechaVenta;
        private TextBox txt_montoTotal;
        private ComboBox comboBox_tipoVenta;
        private Panel panel9;
        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Label label15;
        private Panel panel2;
        private Button button2;
        private Panel panel6;
        private Label label18;
        private Panel panel7;
        private Label label19;
        private Button button4;
        private Panel panel3;
        private Panel panel8;
        private Label label14;
        private Panel panel10;
        private Label label12;
        private Panel panel11;
        private Button btn_limpiar;
    }
}