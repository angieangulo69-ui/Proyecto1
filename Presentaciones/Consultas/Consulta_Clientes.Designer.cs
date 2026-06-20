namespace Presentaciones.Consultas
{
    partial class Consulta_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Clientes));
            label7 = new Label();
            label5 = new Label();
            data_cliente = new DataGridView();
            btn_consulta = new Button();
            label4 = new Label();
            btn_atras = new Button();
            btn_salir = new Button();
            comboBox_cliente = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)data_cliente).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SpringGreen;
            label7.Location = new Point(98, 125);
            label7.Name = "label7";
            label7.Size = new Size(197, 36);
            label7.TabIndex = 86;
            label7.Text = "Identificación:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(62, 240);
            label5.Name = "label5";
            label5.Size = new Size(224, 29);
            label5.TabIndex = 85;
            label5.Text = "Consulta  realizada:";
            // 
            // data_cliente
            // 
            data_cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_cliente.Location = new Point(112, 302);
            data_cliente.Name = "data_cliente";
            data_cliente.RowHeadersWidth = 51;
            data_cliente.Size = new Size(780, 205);
            data_cliente.TabIndex = 84;
            // 
            // btn_consulta
            // 
            btn_consulta.BackColor = Color.Transparent;
            btn_consulta.BackgroundImage = (Image)resources.GetObject("btn_consulta.BackgroundImage");
            btn_consulta.BackgroundImageLayout = ImageLayout.Stretch;
            btn_consulta.Cursor = Cursors.Hand;
            btn_consulta.Location = new Point(547, 106);
            btn_consulta.Name = "btn_consulta";
            btn_consulta.Size = new Size(52, 55);
            btn_consulta.TabIndex = 83;
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
            label4.Location = new Point(317, 9);
            label4.Name = "label4";
            label4.Size = new Size(367, 48);
            label4.TabIndex = 82;
            label4.Text = "Consulta  de Clientes";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(893, 560);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(51, 48);
            btn_atras.TabIndex = 81;
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
            btn_salir.Location = new Point(950, 562);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(40, 44);
            btn_salir.TabIndex = 80;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // comboBox_cliente
            // 
            comboBox_cliente.FormattingEnabled = true;
            comboBox_cliente.Location = new Point(317, 125);
            comboBox_cliente.Name = "comboBox_cliente";
            comboBox_cliente.Size = new Size(185, 28);
            comboBox_cliente.TabIndex = 88;
            // 
            // Consulta_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1012, 627);
            Controls.Add(comboBox_cliente);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(data_cliente);
            Controls.Add(btn_consulta);
            Controls.Add(label4);
            Controls.Add(btn_atras);
            Controls.Add(btn_salir);
            Name = "Consulta_Clientes";
            Text = "Consulta_Clientes";
            Load += Consulta_Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)data_cliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mask_identificacion;
        private Label label7;
        private Label label5;
        private DataGridView data_cliente;
        private Button btn_consulta;
        private Label label4;
        private Button btn_atras;
        private Button btn_salir;
        private ComboBox comboBox_cliente;
    }
}