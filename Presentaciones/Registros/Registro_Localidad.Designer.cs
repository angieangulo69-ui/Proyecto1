namespace Presentaciones
{
    partial class Registro_Localidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Localidad));
            label2 = new Label();
            btn_atras = new Button();
            btn_salir = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_idlocalidad = new TextBox();
            txt_precio = new TextBox();
            txt_nombrelocalidad = new TextBox();
            btn_guardar = new Button();
            data_localidades = new DataGridView();
            label5 = new Label();
            panel2 = new Panel();
            btn_limpiar = new Button();
            panel1 = new Panel();
            label10 = new Label();
            panel7 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)data_localidades).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(15, 13);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 34;
            label2.Text = "Id Localidad:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(21, 568);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(38, 39);
            btn_atras.TabIndex = 33;
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
            btn_salir.Location = new Point(662, 538);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(40, 39);
            btn_salir.TabIndex = 32;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(67, 73);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 35;
            label1.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(53, 39);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 36;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(174, 0);
            label4.Name = "label4";
            label4.Size = new Size(374, 48);
            label4.TabIndex = 37;
            label4.Text = "Registro de Localidad";
            // 
            // txt_idlocalidad
            // 
            txt_idlocalidad.Location = new Point(143, 5);
            txt_idlocalidad.Name = "txt_idlocalidad";
            txt_idlocalidad.Size = new Size(136, 27);
            txt_idlocalidad.TabIndex = 38;
            txt_idlocalidad.KeyPress += txt_idlocalidad_KeyPress;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(143, 71);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(136, 27);
            txt_precio.TabIndex = 39;
            txt_precio.KeyUp += txt_precio_KeyUp;
            // 
            // txt_nombrelocalidad
            // 
            txt_nombrelocalidad.Location = new Point(143, 38);
            txt_nombrelocalidad.Name = "txt_nombrelocalidad";
            txt_nombrelocalidad.Size = new Size(136, 27);
            txt_nombrelocalidad.TabIndex = 40;
            txt_nombrelocalidad.TextChanged += txt_nombrelocalidad_TextChanged;
            txt_nombrelocalidad.KeyPress += txt_nombrelocalidad_KeyPress;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Transparent;
            btn_guardar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Location = new Point(194, 115);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(99, 39);
            btn_guardar.TabIndex = 41;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // data_localidades
            // 
            data_localidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_localidades.Location = new Point(100, 382);
            data_localidades.Name = "data_localidades";
            data_localidades.RowHeadersWidth = 51;
            data_localidades.Size = new Size(508, 152);
            data_localidades.TabIndex = 42;
            data_localidades.CellContentClick += data_localidades_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(30, 334);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 43;
            label5.Text = "Registros  realizados:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btn_limpiar);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btn_guardar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_idlocalidad);
            panel2.Controls.Add(txt_nombrelocalidad);
            panel2.Controls.Add(txt_precio);
            panel2.Location = new Point(151, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 171);
            panel2.TabIndex = 87;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.Transparent;
            btn_limpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Location = new Point(67, 115);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(99, 39);
            btn_limpiar.TabIndex = 42;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label10);
            panel1.Location = new Point(151, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 42);
            panel1.TabIndex = 86;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(60, -4);
            label10.Name = "label10";
            label10.Size = new Size(190, 68);
            label10.TabIndex = 86;
            label10.Text = "Datos Localidad";
            // 
            // panel7
            // 
            panel7.BackColor = Color.SeaShell;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(panel2);
            panel7.Controls.Add(btn_salir);
            panel7.Controls.Add(panel1);
            panel7.Controls.Add(data_localidades);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(btn_atras);
            panel7.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel7.Location = new Point(21, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(719, 611);
            panel7.TabIndex = 91;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SandyBrown;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(709, 61);
            panel3.TabIndex = 87;
            // 
            // Registro_Localidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(764, 636);
            Controls.Add(panel7);
            Name = "Registro_Localidad";
            Text = "Registro_Localidad";
            Load += Registro_Localidad_Load;
            ((System.ComponentModel.ISupportInitialize)data_localidades).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Button btn_atras;
        private Button btn_salir;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txt_idlocalidad;
        private TextBox txt_precio;
        private TextBox txt_nombrelocalidad;
        private Button btn_guardar;
        private DataGridView data_localidades;
        private Label label5;
        private Panel panel2;
        private Panel panel1;
        private Label label10;
        private Panel panel7;
        private Panel panel3;
        private Button btn_limpiar;
    }
}