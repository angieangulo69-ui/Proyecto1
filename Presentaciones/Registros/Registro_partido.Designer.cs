namespace Presentaciones.Registros
{
    partial class Registro_partido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_partido));
            label5 = new Label();
            data_partidos = new DataGridView();
            btn_guardar = new Button();
            txt_rival = new TextBox();
            txt_idpartido = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btn_atras = new Button();
            btn_salir = new Button();
            label6 = new Label();
            label7 = new Label();
            dateTime_fecha = new DateTimePicker();
            checkBox_activo = new CheckBox();
            dateTime_hora = new DateTimePicker();
            panel3 = new Panel();
            panel9 = new Panel();
            btn_limpiar = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            label13 = new Label();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            panel6 = new Panel();
            label12 = new Label();
            panel7 = new Panel();
            label14 = new Label();
            button4 = new Button();
            label15 = new Label();
            panel8 = new Panel();
            ((System.ComponentModel.ISupportInitialize)data_partidos).BeginInit();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(15, 352);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 55;
            label5.Text = "Registros  realizados:";
            // 
            // data_partidos
            // 
            data_partidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_partidos.Location = new Point(115, 400);
            data_partidos.Name = "data_partidos";
            data_partidos.RowHeadersWidth = 51;
            data_partidos.Size = new Size(773, 119);
            data_partidos.TabIndex = 54;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Bisque;
            btn_guardar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guardar.Location = new Point(372, 195);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(112, 37);
            btn_guardar.TabIndex = 53;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_rival
            // 
            txt_rival.Location = new Point(132, 50);
            txt_rival.Name = "txt_rival";
            txt_rival.Size = new Size(163, 27);
            txt_rival.TabIndex = 52;
            // 
            // txt_idpartido
            // 
            txt_idpartido.Location = new Point(132, 8);
            txt_idpartido.Name = "txt_idpartido";
            txt_idpartido.Size = new Size(163, 27);
            txt_idpartido.TabIndex = 50;
            txt_idpartido.KeyPress += txt_idpartido_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(358, 0);
            label4.Name = "label4";
            label4.Size = new Size(350, 48);
            label4.TabIndex = 49;
            label4.Text = "Registro de Partidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(33, 53);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 48;
            label3.Text = "Rival:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 47;
            label1.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(24, 16);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 46;
            label2.Text = "Id Partido:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(15, 496);
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
            btn_salir.Location = new Point(989, 510);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(34, 39);
            btn_salir.TabIndex = 44;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(11, 51);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 57;
            label6.Text = "Hora:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(25, 28);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 56;
            label7.Text = "Activo:";
            // 
            // dateTime_fecha
            // 
            dateTime_fecha.Location = new Point(84, 3);
            dateTime_fecha.Name = "dateTime_fecha";
            dateTime_fecha.Size = new Size(208, 27);
            dateTime_fecha.TabIndex = 58;
            // 
            // checkBox_activo
            // 
            checkBox_activo.AutoSize = true;
            checkBox_activo.Location = new Point(100, 31);
            checkBox_activo.Name = "checkBox_activo";
            checkBox_activo.Size = new Size(18, 17);
            checkBox_activo.TabIndex = 59;
            checkBox_activo.UseVisualStyleBackColor = true;
            // 
            // dateTime_hora
            // 
            dateTime_hora.CustomFormat = "hh:mm tt";
            dateTime_hora.Format = DateTimePickerFormat.Custom;
            dateTime_hora.Location = new Point(84, 47);
            dateTime_hora.Name = "dateTime_hora";
            dateTime_hora.ShowUpDown = true;
            dateTime_hora.Size = new Size(208, 27);
            dateTime_hora.TabIndex = 60;
            dateTime_hora.Value = new DateTime(2026, 7, 4, 11, 38, 0, 0);
            // 
            // panel3
            // 
            panel3.BackColor = Color.SandyBrown;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(23, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1013, 61);
            panel3.TabIndex = 88;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Snow;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(btn_limpiar);
            panel9.Controls.Add(panel1);
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(panel4);
            panel9.Controls.Add(panel2);
            panel9.Controls.Add(btn_guardar);
            panel9.Controls.Add(dataGridView2);
            panel9.Controls.Add(button2);
            panel9.Controls.Add(panel6);
            panel9.Controls.Add(panel7);
            panel9.Controls.Add(button4);
            panel9.Controls.Add(label15);
            panel9.Location = new Point(10, 72);
            panel9.Name = "panel9";
            panel9.Size = new Size(1013, 246);
            panel9.TabIndex = 100;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.Bisque;
            btn_limpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar.Location = new Point(506, 195);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(112, 37);
            btn_limpiar.TabIndex = 93;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTime_fecha);
            panel1.Controls.Add(dateTime_hora);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(345, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 103);
            panel1.TabIndex = 92;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(checkBox_activo);
            panel5.Location = new Point(680, 58);
            panel5.Name = "panel5";
            panel5.Size = new Size(312, 106);
            panel5.TabIndex = 90;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label13);
            panel4.Location = new Point(345, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(312, 42);
            panel4.TabIndex = 91;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(84, -5);
            label13.Name = "label13";
            label13.Size = new Size(173, 68);
            label13.TabIndex = 86;
            label13.Text = "Programación";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_idpartido);
            panel2.Controls.Add(txt_rival);
            panel2.Location = new Point(19, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 106);
            panel2.TabIndex = 85;
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
            // panel6
            // 
            panel6.BackColor = Color.SandyBrown;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(label12);
            panel6.Location = new Point(19, 17);
            panel6.Name = "panel6";
            panel6.Size = new Size(312, 42);
            panel6.TabIndex = 84;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(96, -2);
            label12.Name = "label12";
            label12.Size = new Size(172, 68);
            label12.TabIndex = 86;
            label12.Text = "Identificación ";
            // 
            // panel7
            // 
            panel7.BackColor = Color.SandyBrown;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(label14);
            panel7.Location = new Point(680, 14);
            panel7.Name = "panel7";
            panel7.Size = new Size(312, 42);
            panel7.TabIndex = 89;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(124, -2);
            label14.Name = "label14";
            label14.Size = new Size(98, 68);
            label14.TabIndex = 86;
            label14.Text = "Estado";
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
            // panel8
            // 
            panel8.BackColor = Color.AntiqueWhite;
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(btn_atras);
            panel8.Controls.Add(btn_salir);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(data_partidos);
            panel8.Location = new Point(13, 7);
            panel8.Name = "panel8";
            panel8.Size = new Size(1033, 563);
            panel8.TabIndex = 101;
            // 
            // Registro_partido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1058, 591);
            Controls.Add(panel3);
            Controls.Add(panel8);
            Name = "Registro_partido";
            Text = "Registro_partido";
            Load += Registro_partido_Load;
            ((System.ComponentModel.ISupportInitialize)data_partidos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private DataGridView data_partidos;
        private Button btn_guardar;
        private TextBox txt_rival;
        private TextBox txt_idpartido;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btn_atras;
        private Button btn_salir;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTime_fecha;
        private CheckBox checkBox_activo;
        private DateTimePicker dateTime_hora;
        private Panel panel3;
        private Panel panel9;
        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Label label13;
        private Panel panel2;
        private DataGridView dataGridView2;
        private Button button2;
        private Panel panel6;
        private Label label12;
        private Panel panel7;
        private Label label14;
        private Button button4;
        private Label label15;
        private Panel panel8;
        private Button btn_limpiar;
    }
}