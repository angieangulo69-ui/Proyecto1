namespace Presentaciones.Consultas
{
    partial class Consulta_Localidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Localidades));
            label5 = new Label();
            data_localidades = new DataGridView();
            btn_consulta = new Button();
            label4 = new Label();
            label2 = new Label();
            btn_atras = new Button();
            btn_salir = new Button();
            comboBox_nombrelocalidad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)data_localidades).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(51, 203);
            label5.Name = "label5";
            label5.Size = new Size(234, 29);
            label5.TabIndex = 51;
            label5.Text = "Consulta  realizados:";
            // 
            // data_localidades
            // 
            data_localidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_localidades.Location = new Point(179, 263);
            data_localidades.Name = "data_localidades";
            data_localidades.RowHeadersWidth = 51;
            data_localidades.Size = new Size(425, 188);
            data_localidades.TabIndex = 50;
            // 
            // btn_consulta
            // 
            btn_consulta.BackColor = Color.Transparent;
            btn_consulta.BackgroundImage = (Image)resources.GetObject("btn_consulta.BackgroundImage");
            btn_consulta.BackgroundImageLayout = ImageLayout.Stretch;
            btn_consulta.Cursor = Cursors.Hand;
            btn_consulta.Location = new Point(545, 108);
            btn_consulta.Name = "btn_consulta";
            btn_consulta.Size = new Size(59, 55);
            btn_consulta.TabIndex = 49;
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
            label4.Location = new Point(220, 16);
            label4.Name = "label4";
            label4.Size = new Size(382, 48);
            label4.TabIndex = 47;
            label4.Text = "Consulta de Localidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(83, 114);
            label2.Name = "label2";
            label2.Size = new Size(253, 36);
            label2.TabIndex = 46;
            label2.Text = "Nombre Localidad:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(734, 465);
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
            btn_salir.Location = new Point(787, 465);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(31, 39);
            btn_salir.TabIndex = 44;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // comboBox_nombrelocalidad
            // 
            comboBox_nombrelocalidad.FormattingEnabled = true;
            comboBox_nombrelocalidad.Location = new Point(342, 122);
            comboBox_nombrelocalidad.Name = "comboBox_nombrelocalidad";
            comboBox_nombrelocalidad.Size = new Size(176, 28);
            comboBox_nombrelocalidad.TabIndex = 52;
            // 
            // Consulta_Localidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(830, 516);
            Controls.Add(comboBox_nombrelocalidad);
            Controls.Add(label5);
            Controls.Add(data_localidades);
            Controls.Add(btn_consulta);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btn_atras);
            Controls.Add(btn_salir);
            Name = "Consulta_Localidades";
            Text = "Consulta_Localidades";
            Load += Consulta_Localidades_Load;
            ((System.ComponentModel.ISupportInitialize)data_localidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView data_localidades;
        private Button btn_consulta;
        private Label label4;
        private Label label2;
        private Button btn_atras;
        private Button btn_salir;
        private ComboBox comboBox_nombrelocalidad;
    }
}