namespace Presentaciones.Registros
{
    partial class Registro_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Clientes));
            date_fecharegistro = new DateTimePicker();
            date_fechanacimiento = new DateTimePicker();
            mask_identificacion = new MaskedTextBox();
            txt_apellido = new TextBox();
            label9 = new Label();
            label5 = new Label();
            data_cliente = new DataGridView();
            btn_guardar = new Button();
            txt_nombre = new TextBox();
            txt_idcliente = new TextBox();
            label4 = new Label();
            label1 = new Label();
            btn_atras = new Button();
            btn_salir = new Button();
            label6 = new Label();
            checkBox_activo = new CheckBox();
            label7 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label14 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            label13 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label12 = new Label();
            panel9 = new Panel();
            btn_limpiar = new Button();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            button4 = new Button();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)data_cliente).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // date_fecharegistro
            // 
            date_fecharegistro.Location = new Point(132, 45);
            date_fecharegistro.Name = "date_fecharegistro";
            date_fecharegistro.Size = new Size(161, 27);
            date_fecharegistro.TabIndex = 81;
            date_fecharegistro.Value = new DateTime(2026, 7, 4, 10, 24, 52, 0);
            // 
            // date_fechanacimiento
            // 
            date_fechanacimiento.Location = new Point(132, 6);
            date_fechanacimiento.Name = "date_fechanacimiento";
            date_fechanacimiento.Size = new Size(161, 27);
            date_fechanacimiento.TabIndex = 80;
            date_fechanacimiento.Value = new DateTime(2026, 7, 4, 0, 0, 0, 0);
            // 
            // mask_identificacion
            // 
            mask_identificacion.Location = new Point(149, 15);
            mask_identificacion.Mask = "0-0000-0000";
            mask_identificacion.Name = "mask_identificacion";
            mask_identificacion.Size = new Size(147, 27);
            mask_identificacion.TabIndex = 79;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(120, 77);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(147, 27);
            txt_apellido.TabIndex = 78;
            txt_apellido.KeyPress += txt_apellido_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(39, 45);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 77;
            label9.Text = "Registro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 348);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 74;
            label5.Text = "Registros  realizados:";
            // 
            // data_cliente
            // 
            data_cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_cliente.Location = new Point(123, 406);
            data_cliente.Name = "data_cliente";
            data_cliente.RowHeadersWidth = 51;
            data_cliente.Size = new Size(787, 151);
            data_cliente.TabIndex = 73;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.MistyRose;
            btn_guardar.BackgroundImageLayout = ImageLayout.None;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar.Location = new Point(363, 193);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(107, 34);
            btn_guardar.TabIndex = 72;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(120, 44);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(147, 27);
            txt_nombre.TabIndex = 71;
            txt_nombre.KeyPress += txt_nombre_KeyPress;
            // 
            // txt_idcliente
            // 
            txt_idcliente.Location = new Point(120, 11);
            txt_idcliente.Name = "txt_idcliente";
            txt_idcliente.Size = new Size(147, 27);
            txt_idcliente.TabIndex = 70;
            txt_idcliente.KeyPress += txt_idcliente_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(344, -2);
            label4.Name = "label4";
            label4.Size = new Size(349, 48);
            label4.TabIndex = 69;
            label4.Text = "Registro de Clientes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 67;
            label1.Text = "Nacimiento:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(3, 508);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(49, 49);
            btn_atras.TabIndex = 65;
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
            btn_salir.Location = new Point(987, 525);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(45, 49);
            btn_salir.TabIndex = 64;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(74, 50);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 82;
            label6.Text = "Activo:";
            // 
            // checkBox_activo
            // 
            checkBox_activo.AutoSize = true;
            checkBox_activo.Location = new Point(158, 55);
            checkBox_activo.Name = "checkBox_activo";
            checkBox_activo.Size = new Size(18, 17);
            checkBox_activo.TabIndex = 83;
            checkBox_activo.UseVisualStyleBackColor = true;
            checkBox_activo.CheckedChanged += checkBox_activo_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(8, 18);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 75;
            label7.Text = "Identificación:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label10);
            panel1.Location = new Point(19, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 42);
            panel1.TabIndex = 84;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(60, -4);
            label10.Name = "label10";
            label10.Size = new Size(205, 68);
            label10.TabIndex = 86;
            label10.Text = "Datos Personales";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_nombre);
            panel2.Controls.Add(txt_apellido);
            panel2.Controls.Add(txt_idcliente);
            panel2.Location = new Point(19, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 120);
            panel2.TabIndex = 85;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 45);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 2;
            label8.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 80);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 1;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 14);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 0;
            label2.Text = "Id Cliente:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(checkBox_activo);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(mask_identificacion);
            panel3.Location = new Point(380, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(312, 120);
            panel3.TabIndex = 88;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label14);
            panel4.Location = new Point(380, 116);
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
            label14.Location = new Point(59, -6);
            label14.Name = "label14";
            label14.Size = new Size(208, 68);
            label14.TabIndex = 86;
            label14.Text = "Estado del Cliente";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(date_fecharegistro);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(date_fechanacimiento);
            panel5.Location = new Point(680, 58);
            panel5.Name = "panel5";
            panel5.Size = new Size(312, 120);
            panel5.TabIndex = 90;
            // 
            // panel6
            // 
            panel6.BackColor = Color.SandyBrown;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(label13);
            panel6.Location = new Point(680, 14);
            panel6.Name = "panel6";
            panel6.Size = new Size(312, 42);
            panel6.TabIndex = 89;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(103, -9);
            label13.Name = "label13";
            label13.Size = new Size(99, 68);
            label13.TabIndex = 86;
            label13.Text = "Fechas";
            // 
            // panel7
            // 
            panel7.BackColor = Color.SeaShell;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(data_cliente);
            panel7.Controls.Add(btn_atras);
            panel7.Controls.Add(btn_salir);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel9);
            panel7.Location = new Point(12, 23);
            panel7.Name = "panel7";
            panel7.Size = new Size(1056, 592);
            panel7.TabIndex = 90;
            panel7.Paint += panel7_Paint;
            // 
            // panel8
            // 
            panel8.BackColor = Color.SandyBrown;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(label4);
            panel8.Controls.Add(dataGridView1);
            panel8.Controls.Add(button2);
            panel8.Controls.Add(button3);
            panel8.Controls.Add(label12);
            panel8.Location = new Point(11, 10);
            panel8.Name = "panel8";
            panel8.Size = new Size(1021, 60);
            panel8.TabIndex = 91;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(117, 451);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(787, 151);
            dataGridView1.TabIndex = 73;
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
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(1004, 618);
            button3.Name = "button3";
            button3.Size = new Size(45, 49);
            button3.TabIndex = 64;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(43, 394);
            label12.Name = "label12";
            label12.Size = new Size(237, 29);
            label12.TabIndex = 74;
            label12.Text = "Registros  realizados:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Snow;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(btn_limpiar);
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(btn_guardar);
            panel9.Controls.Add(panel2);
            panel9.Controls.Add(dataGridView2);
            panel9.Controls.Add(button1);
            panel9.Controls.Add(panel1);
            panel9.Controls.Add(panel6);
            panel9.Controls.Add(button4);
            panel9.Controls.Add(label15);
            panel9.Location = new Point(11, 72);
            panel9.Name = "panel9";
            panel9.Size = new Size(1021, 252);
            panel9.TabIndex = 92;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.MistyRose;
            btn_limpiar.BackgroundImageLayout = ImageLayout.None;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar.Location = new Point(531, 193);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(107, 34);
            btn_limpiar.TabIndex = 93;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(117, 451);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(787, 151);
            dataGridView2.TabIndex = 73;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(3, 613);
            button1.Name = "button1";
            button1.Size = new Size(49, 49);
            button1.TabIndex = 65;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
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
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(43, 394);
            label15.Name = "label15";
            label15.Size = new Size(237, 29);
            label15.TabIndex = 74;
            label15.Text = "Registros  realizados:";
            // 
            // Registro_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1088, 629);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel7);
            Name = "Registro_Clientes";
            Text = "Registro_Clientes";
            Load += Registro_Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)data_cliente).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker date_fecharegistro;
        private DateTimePicker date_fechanacimiento;
        private MaskedTextBox mask_identificacion;
        private TextBox txt_apellido;
        private Label label9;
        private Label label5;
        private DataGridView data_cliente;
        private Button btn_guardar;
        private TextBox txt_nombre;
        private TextBox txt_idcliente;
        private Label label4;
        private Label label1;
        private Button btn_atras;
        private Button btn_salir;
        private Label label6;
        private CheckBox checkBox_activo;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Label label10;
        private Label label8;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Label label14;
        private Panel panel5;
        private Panel panel6;
        private Label label13;
        private Panel panel7;
        private Panel panel8;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Label label12;
        private Panel panel9;
        private DataGridView dataGridView2;
        private Button button1;
        private Button button4;
        private Label label15;
        private Button btn_limpiar;
    }
}