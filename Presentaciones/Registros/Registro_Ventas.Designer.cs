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
            label4 = new Label();
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
            textBox1 = new TextBox();
            comboBox_tipoVenta = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)data_Venta).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(12, 309);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 100;
            label5.Text = "Registros  realizados:";
            // 
            // data_Venta
            // 
            data_Venta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_Venta.Location = new Point(86, 354);
            data_Venta.Name = "data_Venta";
            data_Venta.RowHeadersWidth = 51;
            data_Venta.Size = new Size(787, 205);
            data_Venta.TabIndex = 99;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Transparent;
            btn_guardar.BackgroundImage = (Image)resources.GetObject("btn_guardar.BackgroundImage");
            btn_guardar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Location = new Point(585, 272);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(59, 55);
            btn_guardar.TabIndex = 98;
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            // 
            // txt_idventa
            // 
            txt_idventa.Location = new Point(236, 109);
            txt_idventa.Name = "txt_idventa";
            txt_idventa.Size = new Size(150, 27);
            txt_idventa.TabIndex = 97;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(189, 32);
            label4.Name = "label4";
            label4.Size = new Size(473, 48);
            label4.TabIndex = 96;
            label4.Text = "Registro Ventas de entradas";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(97, 101);
            label2.Name = "label2";
            label2.Size = new Size(133, 36);
            label2.TabIndex = 95;
            label2.Text = "Id Venta:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(876, 567);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(38, 39);
            btn_atras.TabIndex = 94;
            btn_atras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_atras.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Transparent;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.Location = new Point(920, 567);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(31, 39);
            btn_salir.TabIndex = 93;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(86, 216);
            label1.Name = "label1";
            label1.Size = new Size(143, 36);
            label1.TabIndex = 101;
            label1.Text = "Localidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SpringGreen;
            label3.Location = new Point(109, 180);
            label3.Name = "label3";
            label3.Size = new Size(116, 36);
            label3.TabIndex = 102;
            label3.Text = "Partido:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SpringGreen;
            label6.Location = new Point(114, 137);
            label6.Name = "label6";
            label6.Size = new Size(115, 36);
            label6.TabIndex = 103;
            label6.Text = "Cliente:";
            // 
            // comboBox_Cliente
            // 
            comboBox_Cliente.FormattingEnabled = true;
            comboBox_Cliente.Location = new Point(235, 149);
            comboBox_Cliente.Name = "comboBox_Cliente";
            comboBox_Cliente.Size = new Size(151, 28);
            comboBox_Cliente.TabIndex = 104;
            // 
            // comboBox_Partido
            // 
            comboBox_Partido.FormattingEnabled = true;
            comboBox_Partido.Location = new Point(235, 188);
            comboBox_Partido.Name = "comboBox_Partido";
            comboBox_Partido.Size = new Size(151, 28);
            comboBox_Partido.TabIndex = 105;
            // 
            // comboBox_Localidad
            // 
            comboBox_Localidad.FormattingEnabled = true;
            comboBox_Localidad.Location = new Point(235, 224);
            comboBox_Localidad.Name = "comboBox_Localidad";
            comboBox_Localidad.Size = new Size(151, 28);
            comboBox_Localidad.TabIndex = 106;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SpringGreen;
            label7.Location = new Point(428, 103);
            label7.Name = "label7";
            label7.Size = new Size(136, 36);
            label7.TabIndex = 107;
            label7.Text = "Cantidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SpringGreen;
            label8.Location = new Point(416, 141);
            label8.Name = "label8";
            label8.Size = new Size(148, 36);
            label8.TabIndex = 108;
            label8.Text = "Vendedor:";
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(570, 109);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(150, 27);
            txt_cantidad.TabIndex = 109;
            // 
            // comboBox_Vendedor
            // 
            comboBox_Vendedor.FormattingEnabled = true;
            comboBox_Vendedor.Location = new Point(569, 149);
            comboBox_Vendedor.Name = "comboBox_Vendedor";
            comboBox_Vendedor.Size = new Size(151, 28);
            comboBox_Vendedor.TabIndex = 110;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SpringGreen;
            label9.Location = new Point(407, 211);
            label9.Name = "label9";
            label9.Size = new Size(164, 36);
            label9.TabIndex = 111;
            label9.Text = "Tipo Venta:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SpringGreen;
            label10.Location = new Point(392, 175);
            label10.Name = "label10";
            label10.Size = new Size(179, 36);
            label10.TabIndex = 112;
            label10.Text = "Monto Total:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SpringGreen;
            label11.Location = new Point(51, 252);
            label11.Name = "label11";
            label11.Size = new Size(179, 36);
            label11.TabIndex = 113;
            label11.Text = "Fecha Venta:";
            // 
            // date_fechaVenta
            // 
            date_fechaVenta.Location = new Point(236, 261);
            date_fechaVenta.Name = "date_fechaVenta";
            date_fechaVenta.Size = new Size(250, 27);
            date_fechaVenta.TabIndex = 114;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(569, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 115;
            // 
            // comboBox_tipoVenta
            // 
            comboBox_tipoVenta.FormattingEnabled = true;
            comboBox_tipoVenta.Location = new Point(568, 220);
            comboBox_tipoVenta.Name = "comboBox_tipoVenta";
            comboBox_tipoVenta.Size = new Size(151, 28);
            comboBox_tipoVenta.TabIndex = 116;
            // 
            // Registro_Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(963, 618);
            Controls.Add(comboBox_tipoVenta);
            Controls.Add(textBox1);
            Controls.Add(date_fechaVenta);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboBox_Vendedor);
            Controls.Add(txt_cantidad);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox_Localidad);
            Controls.Add(comboBox_Partido);
            Controls.Add(comboBox_Cliente);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(data_Venta);
            Controls.Add(btn_guardar);
            Controls.Add(txt_idventa);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btn_atras);
            Controls.Add(btn_salir);
            Name = "Registro_Ventas";
            Text = "Registro_Ventas";
            Load += Registro_Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)data_Venta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView data_Venta;
        private Button btn_guardar;
        private TextBox txt_idventa;
        private Label label4;
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
        private TextBox textBox1;
        private ComboBox comboBox_tipoVenta;
    }
}