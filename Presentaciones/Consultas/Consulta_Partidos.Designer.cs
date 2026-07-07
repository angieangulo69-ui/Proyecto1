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
            panel8 = new Panel();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label12 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)data_partidos).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(20, 215);
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
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(209, 0);
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
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(37, 116);
            label1.Name = "label1";
            label1.Size = new Size(96, 36);
            label1.TabIndex = 59;
            label1.Text = "Fecha:";
            // 
            // data_partidos
            // 
            data_partidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_partidos.Location = new Point(37, 269);
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
            btn_consultar.Location = new Point(426, 114);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(47, 47);
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
            btn_atras.Location = new Point(3, 461);
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
            btn_salir.Location = new Point(734, 461);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(41, 39);
            btn_salir.TabIndex = 63;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // comboBox_fechas
            // 
            comboBox_fechas.FormattingEnabled = true;
            comboBox_fechas.Location = new Point(139, 124);
            comboBox_fechas.Name = "comboBox_fechas";
            comboBox_fechas.Size = new Size(281, 28);
            comboBox_fechas.TabIndex = 68;
            comboBox_fechas.SelectedIndexChanged += comboBox_fechas_SelectedIndexChanged;
            // 
            // panel8
            // 
            panel8.BackColor = Color.SandyBrown;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(dataGridView1);
            panel8.Controls.Add(button2);
            panel8.Controls.Add(button3);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(label4);
            panel8.Location = new Point(13, 12);
            panel8.Name = "panel8";
            panel8.Size = new Size(791, 60);
            panel8.TabIndex = 94;
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
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(comboBox_fechas);
            panel1.Controls.Add(btn_consultar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(data_partidos);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_atras);
            panel1.Controls.Add(btn_salir);
            panel1.Location = new Point(12, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 505);
            panel1.TabIndex = 95;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(578, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 121);
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // Consulta_Partidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(816, 534);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Name = "Consulta_Partidos";
            Text = "Consulta_Partidos";
            Load += Consulta_Partidos_Load;
            ((System.ComponentModel.ISupportInitialize)data_partidos).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Panel panel8;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Label label12;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}