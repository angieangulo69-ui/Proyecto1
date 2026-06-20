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
            label4 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)data_vendedores).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(11, 296);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 55;
            label5.Text = "Registros  realizados:";
            // 
            // data_vendedores
            // 
            data_vendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_vendedores.Location = new Point(54, 326);
            data_vendedores.Name = "data_vendedores";
            data_vendedores.RowHeadersWidth = 51;
            data_vendedores.Size = new Size(787, 205);
            data_vendedores.TabIndex = 54;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Transparent;
            btn_guardar.BackgroundImage = (Image)resources.GetObject("btn_guardar.BackgroundImage");
            btn_guardar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Location = new Point(372, 246);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(59, 55);
            btn_guardar.TabIndex = 53;
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(207, 176);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(147, 27);
            txt_nombre.TabIndex = 52;
            // 
            // txt_idvendedor
            // 
            txt_idvendedor.Location = new Point(207, 138);
            txt_idvendedor.Name = "txt_idvendedor";
            txt_idvendedor.Size = new Size(147, 27);
            txt_idvendedor.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(251, 29);
            label4.Name = "label4";
            label4.Size = new Size(409, 48);
            label4.TabIndex = 49;
            label4.Text = "Registro de Vendedores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SpringGreen;
            label3.Location = new Point(76, 162);
            label3.Name = "label3";
            label3.Size = new Size(125, 36);
            label3.TabIndex = 48;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(377, 162);
            label1.Name = "label1";
            label1.Size = new Size(249, 36);
            label1.TabIndex = 47;
            label1.Text = "Fecha Nacimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(27, 132);
            label2.Name = "label2";
            label2.Size = new Size(183, 36);
            label2.TabIndex = 46;
            label2.Text = "Id Vendedor:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(803, 569);
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
            btn_salir.Location = new Point(867, 569);
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
            label7.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SpringGreen;
            label7.Location = new Point(429, 123);
            label7.Name = "label7";
            label7.Size = new Size(197, 36);
            label7.TabIndex = 57;
            label7.Text = "Identificación:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SpringGreen;
            label8.Location = new Point(78, 198);
            label8.Name = "label8";
            label8.Size = new Size(132, 36);
            label8.TabIndex = 58;
            label8.Text = "Apellido:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SpringGreen;
            label9.Location = new Point(418, 198);
            label9.Name = "label9";
            label9.Size = new Size(198, 36);
            label9.TabIndex = 59;
            label9.Text = "Fecha Ingreso:";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(207, 209);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(147, 27);
            txt_apellido.TabIndex = 60;
            // 
            // mask_identificacion
            // 
            mask_identificacion.Location = new Point(617, 131);
            mask_identificacion.Mask = "0-0000-0000";
            mask_identificacion.Name = "mask_identificacion";
            mask_identificacion.Size = new Size(250, 27);
            mask_identificacion.TabIndex = 61;
            // 
            // date_fechanacimiento
            // 
            date_fechanacimiento.Location = new Point(617, 168);
            date_fechanacimiento.Name = "date_fechanacimiento";
            date_fechanacimiento.Size = new Size(250, 27);
            date_fechanacimiento.TabIndex = 62;
            // 
            // date_fechaingreso
            // 
            date_fechaingreso.Location = new Point(617, 207);
            date_fechaingreso.Name = "date_fechaingreso";
            date_fechaingreso.Size = new Size(250, 27);
            date_fechaingreso.TabIndex = 63;
            // 
            // Registro_Vendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(940, 620);
            Controls.Add(date_fechaingreso);
            Controls.Add(date_fechanacimiento);
            Controls.Add(mask_identificacion);
            Controls.Add(txt_apellido);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(data_vendedores);
            Controls.Add(btn_guardar);
            Controls.Add(txt_nombre);
            Controls.Add(txt_idvendedor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btn_atras);
            Controls.Add(btn_salir);
            Name = "Registro_Vendedores";
            Text = "Registro_Vendedores";
            Load += Registro_Vendedores_Load;
            ((System.ComponentModel.ISupportInitialize)data_vendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView data_vendedores;
        private Button btn_guardar;
        private TextBox txt_nombre;
        private TextBox txt_idvendedor;
        private Label label4;
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
    }
}