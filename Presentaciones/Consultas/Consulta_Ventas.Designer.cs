namespace Presentaciones.Consultas
{
    partial class Consulta_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Ventas));
            label5 = new Label();
            data_venta = new DataGridView();
            btn_guardar = new Button();
            label4 = new Label();
            btn_atras = new Button();
            btn_salir = new Button();
            comboBox_venta = new ComboBox();
            label2 = new Label();
            panel8 = new Panel();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)data_venta).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(41, 180);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 106;
            label5.Text = "Registros  realizados:";
            // 
            // data_venta
            // 
            data_venta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_venta.Location = new Point(86, 242);
            data_venta.Name = "data_venta";
            data_venta.RowHeadersWidth = 51;
            data_venta.Size = new Size(787, 205);
            data_venta.TabIndex = 105;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Transparent;
            btn_guardar.BackgroundImage = (Image)resources.GetObject("btn_guardar.BackgroundImage");
            btn_guardar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Location = new Point(463, 28);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(45, 42);
            btn_guardar.TabIndex = 104;
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(261, -2);
            label4.Name = "label4";
            label4.Size = new Size(481, 48);
            label4.TabIndex = 103;
            label4.Text = "Consulta Ventas de entradas";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(12, 473);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(38, 39);
            btn_atras.TabIndex = 102;
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
            btn_salir.Location = new Point(916, 544);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(38, 41);
            btn_salir.TabIndex = 101;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // comboBox_venta
            // 
            comboBox_venta.FormattingEnabled = true;
            comboBox_venta.Location = new Point(295, 42);
            comboBox_venta.Name = "comboBox_venta";
            comboBox_venta.Size = new Size(151, 28);
            comboBox_venta.TabIndex = 108;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(156, 34);
            label2.Name = "label2";
            label2.Size = new Size(133, 36);
            label2.TabIndex = 107;
            label2.Text = "Id Venta:";
            label2.Click += label2_Click;
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
            panel8.Location = new Point(12, 11);
            panel8.Name = "panel8";
            panel8.Size = new Size(952, 60);
            panel8.TabIndex = 109;
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
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(720, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 111);
            pictureBox1.TabIndex = 110;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_atras);
            panel1.Controls.Add(btn_guardar);
            panel1.Controls.Add(comboBox_venta);
            panel1.Controls.Add(data_venta);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(16, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 524);
            panel1.TabIndex = 111;
            // 
            // Consulta_Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(974, 617);
            Controls.Add(btn_salir);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Name = "Consulta_Ventas";
            Text = "Consulta_Ventas";
            Load += Consulta_Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)data_venta).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private DataGridView data_venta;
        private Button btn_guardar;
        private Label label4;
        private Button btn_atras;
        private Button btn_salir;
        private ComboBox comboBox_venta;
        private Label label2;
        private Panel panel8;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Label label12;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}