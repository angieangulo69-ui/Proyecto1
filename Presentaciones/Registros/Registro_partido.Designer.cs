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
            data_localidades = new DataGridView();
            btn_guardar = new Button();
            txt_rival = new TextBox();
            txt_hora = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)data_localidades).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(23, 297);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 55;
            label5.Text = "Registros  realizados:";
            // 
            // data_localidades
            // 
            data_localidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_localidades.Location = new Point(59, 342);
            data_localidades.Name = "data_localidades";
            data_localidades.RowHeadersWidth = 51;
            data_localidades.Size = new Size(723, 119);
            data_localidades.TabIndex = 54;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Transparent;
            btn_guardar.BackgroundImage = (Image)resources.GetObject("btn_guardar.BackgroundImage");
            btn_guardar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Location = new Point(572, 137);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(59, 55);
            btn_guardar.TabIndex = 53;
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_rival
            // 
            txt_rival.Location = new Point(276, 126);
            txt_rival.Name = "txt_rival";
            txt_rival.Size = new Size(249, 27);
            txt_rival.TabIndex = 52;
            // 
            // txt_hora
            // 
            txt_hora.Location = new Point(276, 198);
            txt_hora.Name = "txt_hora";
            txt_hora.Size = new Size(249, 27);
            txt_hora.TabIndex = 51;
            // 
            // txt_idpartido
            // 
            txt_idpartido.Location = new Point(276, 89);
            txt_idpartido.Name = "txt_idpartido";
            txt_idpartido.Size = new Size(249, 27);
            txt_idpartido.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(281, 24);
            label4.Name = "label4";
            label4.Size = new Size(350, 48);
            label4.TabIndex = 49;
            label4.Text = "Registro de Partidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SpringGreen;
            label3.Location = new Point(182, 120);
            label3.Name = "label3";
            label3.Size = new Size(88, 36);
            label3.TabIndex = 48;
            label3.Text = "Rival:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(174, 156);
            label1.Name = "label1";
            label1.Size = new Size(96, 36);
            label1.TabIndex = 47;
            label1.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(100, 81);
            label2.Name = "label2";
            label2.Size = new Size(151, 36);
            label2.TabIndex = 46;
            label2.Text = "Id Partido:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(702, 482);
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
            btn_salir.Location = new Point(764, 482);
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
            label6.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SpringGreen;
            label6.Location = new Point(182, 190);
            label6.Name = "label6";
            label6.Size = new Size(85, 36);
            label6.TabIndex = 57;
            label6.Text = "Hora:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SpringGreen;
            label7.Location = new Point(162, 226);
            label7.Name = "label7";
            label7.Size = new Size(106, 36);
            label7.TabIndex = 56;
            label7.Text = "Activo:";
            // 
            // dateTime_fecha
            // 
            dateTime_fecha.Location = new Point(275, 165);
            dateTime_fecha.Name = "dateTime_fecha";
            dateTime_fecha.Size = new Size(264, 27);
            dateTime_fecha.TabIndex = 58;
            // 
            // checkBox_activo
            // 
            checkBox_activo.AutoSize = true;
            checkBox_activo.Location = new Point(276, 236);
            checkBox_activo.Name = "checkBox_activo";
            checkBox_activo.Size = new Size(18, 17);
            checkBox_activo.TabIndex = 59;
            checkBox_activo.UseVisualStyleBackColor = true;
            // 
            // Registro_partido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(818, 524);
            Controls.Add(checkBox_activo);
            Controls.Add(dateTime_fecha);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(data_localidades);
            Controls.Add(btn_guardar);
            Controls.Add(txt_rival);
            Controls.Add(txt_hora);
            Controls.Add(txt_idpartido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btn_atras);
            Controls.Add(btn_salir);
            Name = "Registro_partido";
            Text = "Registro_partido";
            Load += Registro_partido_Load;
            ((System.ComponentModel.ISupportInitialize)data_localidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView data_localidades;
        private Button btn_guardar;
        private TextBox txt_rival;
        private TextBox txt_hora;
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
    }
}