namespace Presentaciones.Consultas
{
    partial class Consulta_Partidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Partidos));
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            data_partidos = new DataGridView();
            btn_consultar = new Button();
            btn_atras = new Button();
            btn_salir = new Button();
            comboBox_fechas = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)data_partidos).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(32, 227);
            label5.Name = "label5";
            label5.Size = new Size(242, 29);
            label5.TabIndex = 62;
            label5.Text = "Consultas  realizadas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(231, 21);
            label4.Name = "label4";
            label4.Size = new Size(358, 48);
            label4.TabIndex = 61;
            label4.Text = "Consulta de Partidos";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(178, 93);
            label1.Name = "label1";
            label1.Size = new Size(96, 36);
            label1.TabIndex = 59;
            label1.Text = "Fecha:";
            // 
            // data_partidos
            // 
            data_partidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_partidos.Location = new Point(74, 276);
            data_partidos.Name = "data_partidos";
            data_partidos.RowHeadersWidth = 51;
            data_partidos.Size = new Size(723, 119);
            data_partidos.TabIndex = 66;
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = Color.Transparent;
            btn_consultar.BackgroundImage = (Image)resources.GetObject("btn_consultar.BackgroundImage");
            btn_consultar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_consultar.Cursor = Cursors.Hand;
            btn_consultar.Location = new Point(592, 93);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(59, 55);
            btn_consultar.TabIndex = 65;
            btn_consultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_consultar.UseVisualStyleBackColor = false;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(742, 474);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(38, 39);
            btn_atras.TabIndex = 64;
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
            btn_salir.Location = new Point(786, 474);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(34, 39);
            btn_salir.TabIndex = 63;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // comboBox_fechas
            // 
            comboBox_fechas.FormattingEnabled = true;
            comboBox_fechas.Location = new Point(289, 101);
            comboBox_fechas.Name = "comboBox_fechas";
            comboBox_fechas.Size = new Size(281, 28);
            comboBox_fechas.TabIndex = 68;
            // 
            // Consulta_Partidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(832, 525);
            Controls.Add(comboBox_fechas);
            Controls.Add(data_partidos);
            Controls.Add(btn_consultar);
            Controls.Add(btn_atras);
            Controls.Add(btn_salir);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Consulta_Partidos";
            Text = "Consulta_Partidos";
            Load += Consulta_Partidos_Load;
            ((System.ComponentModel.ISupportInitialize)data_partidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label1;
        private DateTimePicker dateTime_fecha;
        private DataGridView data_partidos;
        private Button btn_consultar;
        private Button btn_atras;
        private Button btn_salir;
        private ComboBox comboBox_fechas;
    }
}