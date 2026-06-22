namespace Presentaciones.Consultas
{
    partial class Consulta_LocalidadXPartido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_LocalidadXPartido));
            label5 = new Label();
            data_localidadXpartido = new DataGridView();
            btn_consulta = new Button();
            label4 = new Label();
            label2 = new Label();
            btn_atras = new Button();
            btn_salir = new Button();
            comboBoxlocalidadXpartido = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)data_localidadXpartido).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(29, 285);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 99;
            label5.Text = "Registros  realizados:";
            // 
            // data_localidadXpartido
            // 
            data_localidadXpartido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_localidadXpartido.Location = new Point(18, 336);
            data_localidadXpartido.Name = "data_localidadXpartido";
            data_localidadXpartido.RowHeadersWidth = 51;
            data_localidadXpartido.Size = new Size(913, 205);
            data_localidadXpartido.TabIndex = 98;
            data_localidadXpartido.CellContentClick += data_localidadXpartido_CellContentClick;
            // 
            // btn_consulta
            // 
            btn_consulta.BackColor = Color.Transparent;
            btn_consulta.BackgroundImage = (Image)resources.GetObject("btn_consulta.BackgroundImage");
            btn_consulta.BackgroundImageLayout = ImageLayout.Stretch;
            btn_consulta.Cursor = Cursors.Hand;
            btn_consulta.Location = new Point(554, 172);
            btn_consulta.Name = "btn_consulta";
            btn_consulta.Size = new Size(59, 55);
            btn_consulta.TabIndex = 97;
            btn_consulta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_consulta.UseVisualStyleBackColor = false;
            btn_consulta.Click += btn_consulta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(183, 40);
            label4.Name = "label4";
            label4.Size = new Size(549, 48);
            label4.TabIndex = 96;
            label4.Text = "Consulta localidades por partido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(68, 117);
            label2.Name = "label2";
            label2.Size = new Size(283, 36);
            label2.TabIndex = 95;
            label2.Text = "Id Localidad-Partido:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(840, 580);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(38, 39);
            btn_atras.TabIndex = 94;
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
            btn_salir.Location = new Point(884, 580);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(31, 39);
            btn_salir.TabIndex = 93;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // comboBoxlocalidadXpartido
            // 
            comboBoxlocalidadXpartido.FormattingEnabled = true;
            comboBoxlocalidadXpartido.Location = new Point(91, 186);
            comboBoxlocalidadXpartido.Name = "comboBoxlocalidadXpartido";
            comboBoxlocalidadXpartido.Size = new Size(447, 28);
            comboBoxlocalidadXpartido.TabIndex = 100;
            comboBoxlocalidadXpartido.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Consulta_LocalidadXPartido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(943, 646);
            Controls.Add(comboBoxlocalidadXpartido);
            Controls.Add(label5);
            Controls.Add(data_localidadXpartido);
            Controls.Add(btn_consulta);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btn_atras);
            Controls.Add(btn_salir);
            Name = "Consulta_LocalidadXPartido";
            Text = "Consulta_LocalidadXPartido";
            Load += Consulta_LocalidadXPartido_Load;
            ((System.ComponentModel.ISupportInitialize)data_localidadXpartido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView data_localidadXpartido;
        private Button btn_consulta;
        private Label label4;
        private Label label2;
        private Button btn_atras;
        private Button btn_salir;
        private ComboBox comboBoxlocalidadXpartido;
    }
}