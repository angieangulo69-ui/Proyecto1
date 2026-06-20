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
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            data_cliente = new DataGridView();
            btn_guardar = new Button();
            txt_nombre = new TextBox();
            txt_idcliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btn_atras = new Button();
            btn_salir = new Button();
            label6 = new Label();
            checkBox_activo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)data_cliente).BeginInit();
            SuspendLayout();
            // 
            // date_fecharegistro
            // 
            date_fecharegistro.Location = new Point(654, 196);
            date_fecharegistro.Name = "date_fecharegistro";
            date_fecharegistro.Size = new Size(250, 27);
            date_fecharegistro.TabIndex = 81;
            // 
            // date_fechanacimiento
            // 
            date_fechanacimiento.Location = new Point(654, 157);
            date_fechanacimiento.Name = "date_fechanacimiento";
            date_fechanacimiento.Size = new Size(250, 27);
            date_fechanacimiento.TabIndex = 80;
            // 
            // mask_identificacion
            // 
            mask_identificacion.Location = new Point(654, 120);
            mask_identificacion.Mask = "0-0000-0000";
            mask_identificacion.Name = "mask_identificacion";
            mask_identificacion.Size = new Size(250, 27);
            mask_identificacion.TabIndex = 79;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(244, 198);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(147, 27);
            txt_apellido.TabIndex = 78;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SpringGreen;
            label9.Location = new Point(455, 187);
            label9.Name = "label9";
            label9.Size = new Size(216, 36);
            label9.TabIndex = 77;
            label9.Text = "Fecha Registro::";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SpringGreen;
            label8.Location = new Point(115, 187);
            label8.Name = "label8";
            label8.Size = new Size(132, 36);
            label8.TabIndex = 76;
            label8.Text = "Apellido:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SpringGreen;
            label7.Location = new Point(455, 111);
            label7.Name = "label7";
            label7.Size = new Size(197, 36);
            label7.TabIndex = 75;
            label7.Text = "Identificación:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(12, 306);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 74;
            label5.Text = "Registros  realizados:";
            // 
            // data_cliente
            // 
            data_cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_cliente.Location = new Point(88, 356);
            data_cliente.Name = "data_cliente";
            data_cliente.RowHeadersWidth = 51;
            data_cliente.Size = new Size(787, 205);
            data_cliente.TabIndex = 73;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Transparent;
            btn_guardar.BackgroundImage = (Image)resources.GetObject("btn_guardar.BackgroundImage");
            btn_guardar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Location = new Point(425, 269);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(59, 55);
            btn_guardar.TabIndex = 72;
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(244, 165);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(147, 27);
            txt_nombre.TabIndex = 71;
            // 
            // txt_idcliente
            // 
            txt_idcliente.Location = new Point(244, 127);
            txt_idcliente.Name = "txt_idcliente";
            txt_idcliente.Size = new Size(147, 27);
            txt_idcliente.TabIndex = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(234, 29);
            label4.Name = "label4";
            label4.Size = new Size(349, 48);
            label4.TabIndex = 69;
            label4.Text = "Registro de Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SpringGreen;
            label3.Location = new Point(113, 151);
            label3.Name = "label3";
            label3.Size = new Size(125, 36);
            label3.TabIndex = 68;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(414, 151);
            label1.Name = "label1";
            label1.Size = new Size(249, 36);
            label1.TabIndex = 67;
            label1.Text = "Fecha Nacimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(97, 119);
            label2.Name = "label2";
            label2.Size = new Size(150, 36);
            label2.TabIndex = 66;
            label2.Text = "Id Cliente:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(837, 567);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(38, 39);
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
            btn_salir.Location = new Point(890, 567);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(31, 39);
            btn_salir.TabIndex = 64;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SpringGreen;
            label6.Location = new Point(143, 228);
            label6.Name = "label6";
            label6.Size = new Size(106, 36);
            label6.TabIndex = 82;
            label6.Text = "Activo:";
            // 
            // checkBox_activo
            // 
            checkBox_activo.AutoSize = true;
            checkBox_activo.Location = new Point(244, 242);
            checkBox_activo.Name = "checkBox_activo";
            checkBox_activo.Size = new Size(18, 17);
            checkBox_activo.TabIndex = 83;
            checkBox_activo.UseVisualStyleBackColor = true;
            checkBox_activo.CheckedChanged += checkBox_activo_CheckedChanged;
            // 
            // Registro_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(947, 635);
            Controls.Add(checkBox_activo);
            Controls.Add(label6);
            Controls.Add(date_fecharegistro);
            Controls.Add(date_fechanacimiento);
            Controls.Add(mask_identificacion);
            Controls.Add(txt_apellido);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(data_cliente);
            Controls.Add(btn_guardar);
            Controls.Add(txt_nombre);
            Controls.Add(txt_idcliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btn_atras);
            Controls.Add(btn_salir);
            Name = "Registro_Clientes";
            Text = "Registro_Clientes";
            Load += Registro_Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)data_cliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker date_fecharegistro;
        private DateTimePicker date_fechanacimiento;
        private MaskedTextBox mask_identificacion;
        private TextBox txt_apellido;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private DataGridView data_cliente;
        private Button btn_guardar;
        private TextBox txt_nombre;
        private TextBox txt_idcliente;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btn_atras;
        private Button btn_salir;
        private Label label6;
        private CheckBox checkBox_activo;
    }
}