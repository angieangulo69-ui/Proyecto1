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
            ((System.ComponentModel.ISupportInitialize)data_localidades).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(75, 76);
            label2.Name = "label2";
            label2.Size = new Size(178, 36);
            label2.TabIndex = 34;
            label2.Text = "Id Localidad:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(738, 474);
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
            btn_salir.Location = new Point(782, 474);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(31, 39);
            btn_salir.TabIndex = 32;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(149, 151);
            label1.Name = "label1";
            label1.Size = new Size(104, 36);
            label1.TabIndex = 35;
            label1.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SpringGreen;
            label3.Location = new Point(128, 112);
            label3.Name = "label3";
            label3.Size = new Size(125, 36);
            label3.TabIndex = 36;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(213, 9);
            label4.Name = "label4";
            label4.Size = new Size(374, 48);
            label4.TabIndex = 37;
            label4.Text = "Registro de Localidad";
            // 
            // txt_idlocalidad
            // 
            txt_idlocalidad.Location = new Point(251, 84);
            txt_idlocalidad.Name = "txt_idlocalidad";
            txt_idlocalidad.Size = new Size(136, 27);
            txt_idlocalidad.TabIndex = 38;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(251, 160);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(136, 27);
            txt_precio.TabIndex = 39;
            // 
            // txt_nombrelocalidad
            // 
            txt_nombrelocalidad.Location = new Point(251, 121);
            txt_nombrelocalidad.Name = "txt_nombrelocalidad";
            txt_nombrelocalidad.Size = new Size(136, 27);
            txt_nombrelocalidad.TabIndex = 40;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Transparent;
            btn_guardar.BackgroundImage = (Image)resources.GetObject("btn_guardar.BackgroundImage");
            btn_guardar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.Location = new Point(437, 107);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(59, 55);
            btn_guardar.TabIndex = 41;
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // data_localidades
            // 
            data_localidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_localidades.Location = new Point(188, 295);
            data_localidades.Name = "data_localidades";
            data_localidades.RowHeadersWidth = 51;
            data_localidades.Size = new Size(399, 188);
            data_localidades.TabIndex = 42;
            data_localidades.CellContentClick += data_localidades_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(42, 243);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 43;
            label5.Text = "Registros  realizados:";
            // 
            // Registro_Localidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(825, 525);
            Controls.Add(label5);
            Controls.Add(data_localidades);
            Controls.Add(btn_guardar);
            Controls.Add(txt_nombrelocalidad);
            Controls.Add(txt_precio);
            Controls.Add(txt_idlocalidad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btn_atras);
            Controls.Add(btn_salir);
            Name = "Registro_Localidad";
            Text = "Registro_Localidad";
            ((System.ComponentModel.ISupportInitialize)data_localidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}