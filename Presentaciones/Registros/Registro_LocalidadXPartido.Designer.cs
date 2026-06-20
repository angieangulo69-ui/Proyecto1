namespace Presentaciones.Registros
{
    partial class Registro_LocalidadXPartido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_LocalidadXPartido));
            label8 = new Label();
            label5 = new Label();
            data_localidadXpartido = new DataGridView();
            btn_guardar = new Button();
            txt_idlocalidadPartido = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_atras = new Button();
            btn_salir = new Button();
            comboBox_partido = new ComboBox();
            label1 = new Label();
            comboBox_localidad = new ComboBox();
            txt_disponibilidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)data_localidadXpartido).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SpringGreen;
            label8.Location = new Point(205, 111);
            label8.Name = "label8";
            label8.Size = new Size(116, 36);
            label8.TabIndex = 94;
            label8.Text = "Partido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(49, 271);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 92;
            label5.Text = "Registros  realizados:";
            // 
            // data_localidadXpartido
            // 
            data_localidadXpartido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_localidadXpartido.Location = new Point(70, 326);
            data_localidadXpartido.Name = "data_localidadXpartido";
            data_localidadXpartido.RowHeadersWidth = 51;
            data_localidadXpartido.Size = new Size(787, 205);
            data_localidadXpartido.TabIndex = 91;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Transparent;
            btn_guardar.BackgroundImage = (Image)resources.GetObject("btn_guardar.BackgroundImage");
            btn_guardar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Location = new Point(687, 92);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(59, 55);
            btn_guardar.TabIndex = 90;
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_idlocalidadPartido
            // 
            txt_idlocalidadPartido.Location = new Point(327, 83);
            txt_idlocalidadPartido.Name = "txt_idlocalidadPartido";
            txt_idlocalidadPartido.Size = new Size(276, 27);
            txt_idlocalidadPartido.TabIndex = 88;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(203, 9);
            label4.Name = "label4";
            label4.Size = new Size(522, 48);
            label4.TabIndex = 87;
            label4.Text = "Definir localidades por partido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SpringGreen;
            label3.Location = new Point(178, 147);
            label3.Name = "label3";
            label3.Size = new Size(143, 36);
            label3.TabIndex = 86;
            label3.Text = "Localidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(38, 75);
            label2.Name = "label2";
            label2.Size = new Size(283, 36);
            label2.TabIndex = 84;
            label2.Text = "Id Localidad-Partido:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(860, 549);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(38, 39);
            btn_atras.TabIndex = 83;
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
            btn_salir.Location = new Point(904, 549);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(31, 39);
            btn_salir.TabIndex = 82;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // comboBox_partido
            // 
            comboBox_partido.FormattingEnabled = true;
            comboBox_partido.Location = new Point(327, 119);
            comboBox_partido.Name = "comboBox_partido";
            comboBox_partido.Size = new Size(276, 28);
            comboBox_partido.TabIndex = 95;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(38, 183);
            label1.Name = "label1";
            label1.Size = new Size(281, 36);
            label1.TabIndex = 96;
            label1.Text = "Cantidad Disponible:";
            // 
            // comboBox_localidad
            // 
            comboBox_localidad.FormattingEnabled = true;
            comboBox_localidad.Location = new Point(327, 155);
            comboBox_localidad.Name = "comboBox_localidad";
            comboBox_localidad.Size = new Size(276, 28);
            comboBox_localidad.TabIndex = 97;
            // 
            // txt_disponibilidad
            // 
            txt_disponibilidad.Location = new Point(325, 191);
            txt_disponibilidad.Name = "txt_disponibilidad";
            txt_disponibilidad.Size = new Size(276, 27);
            txt_disponibilidad.TabIndex = 98;
            // 
            // Registro_LocalidadXPartido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(947, 609);
            Controls.Add(txt_disponibilidad);
            Controls.Add(comboBox_localidad);
            Controls.Add(label1);
            Controls.Add(comboBox_partido);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(data_localidadXpartido);
            Controls.Add(btn_guardar);
            Controls.Add(txt_idlocalidadPartido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_atras);
            Controls.Add(btn_salir);
            Name = "Registro_LocalidadXPartido";
            Text = "Registro_LocalidadXPartidocs";
            Load += Registro_LocalidadXPartido_Load;
            ((System.ComponentModel.ISupportInitialize)data_localidadXpartido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label5;
        private DataGridView data_localidadXpartido;
        private Button btn_guardar;
        private TextBox txt_idlocalidadPartido;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_atras;
        private Button btn_salir;
        private ComboBox comboBox_partido;
        private Label label1;
        private ComboBox comboBox_localidad;
        private TextBox txt_disponibilidad;
    }
}