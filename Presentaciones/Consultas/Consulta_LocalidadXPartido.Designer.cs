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
            panel8 = new Panel();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label12 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)data_localidadXpartido).BeginInit();
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
            label5.Location = new Point(59, 273);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 99;
            label5.Text = "Registros  realizados:";
            // 
            // data_localidadXpartido
            // 
            data_localidadXpartido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_localidadXpartido.Location = new Point(37, 336);
            data_localidadXpartido.Name = "data_localidadXpartido";
            data_localidadXpartido.RowHeadersWidth = 51;
            data_localidadXpartido.Size = new Size(881, 205);
            data_localidadXpartido.TabIndex = 98;
            data_localidadXpartido.CellContentClick += data_localidadXpartido_CellContentClick;
            // 
            // btn_consulta
            // 
            btn_consulta.BackColor = Color.Transparent;
            btn_consulta.BackgroundImage = (Image)resources.GetObject("btn_consulta.BackgroundImage");
            btn_consulta.BackgroundImageLayout = ImageLayout.Stretch;
            btn_consulta.Cursor = Cursors.Hand;
            btn_consulta.Location = new Point(776, 87);
            btn_consulta.Name = "btn_consulta";
            btn_consulta.Size = new Size(47, 41);
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
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(171, 0);
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
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(19, 92);
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
            btn_atras.Location = new Point(3, 565);
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
            btn_salir.Location = new Point(872, 565);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(38, 39);
            btn_salir.TabIndex = 93;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // comboBoxlocalidadXpartido
            // 
            comboBoxlocalidadXpartido.FormattingEnabled = true;
            comboBoxlocalidadXpartido.Location = new Point(308, 100);
            comboBoxlocalidadXpartido.Name = "comboBoxlocalidadXpartido";
            comboBoxlocalidadXpartido.Size = new Size(447, 28);
            comboBoxlocalidadXpartido.TabIndex = 100;
            comboBoxlocalidadXpartido.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            panel8.Location = new Point(12, 12);
            panel8.Name = "panel8";
            panel8.Size = new Size(919, 60);
            panel8.TabIndex = 101;
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
            panel1.Controls.Add(comboBoxlocalidadXpartido);
            panel1.Controls.Add(btn_consulta);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_atras);
            panel1.Controls.Add(btn_salir);
            panel1.Location = new Point(18, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 609);
            panel1.TabIndex = 102;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(660, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 119);
            pictureBox1.TabIndex = 101;
            pictureBox1.TabStop = false;
            // 
            // Consulta_LocalidadXPartido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(943, 646);
            Controls.Add(data_localidadXpartido);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Name = "Consulta_LocalidadXPartido";
            Text = "Consulta_LocalidadXPartido";
            Load += Consulta_LocalidadXPartido_Load;
            ((System.ComponentModel.ISupportInitialize)data_localidadXpartido).EndInit();
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
        private DataGridView data_localidadXpartido;
        private Button btn_consulta;
        private Label label4;
        private Label label2;
        private Button btn_atras;
        private Button btn_salir;
        private ComboBox comboBoxlocalidadXpartido;
        private Panel panel8;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Label label12;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}