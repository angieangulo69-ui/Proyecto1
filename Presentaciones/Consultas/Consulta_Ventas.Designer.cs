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
            ((System.ComponentModel.ISupportInitialize)data_venta).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(52, 197);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 106;
            label5.Text = "Registros  realizados:";
            // 
            // data_venta
            // 
            data_venta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_venta.Location = new Point(71, 256);
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
            btn_guardar.Location = new Point(514, 82);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(59, 55);
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
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(192, 11);
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
            btn_atras.Location = new Point(879, 546);
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
            btn_salir.Location = new Point(923, 546);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(31, 39);
            btn_salir.TabIndex = 101;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // comboBox_venta
            // 
            comboBox_venta.FormattingEnabled = true;
            comboBox_venta.Location = new Point(331, 82);
            comboBox_venta.Name = "comboBox_venta";
            comboBox_venta.Size = new Size(151, 28);
            comboBox_venta.TabIndex = 108;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(183, 74);
            label2.Name = "label2";
            label2.Size = new Size(133, 36);
            label2.TabIndex = 107;
            label2.Text = "Id Venta:";
            // 
            // Consulta_Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(974, 617);
            Controls.Add(comboBox_venta);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(data_venta);
            Controls.Add(btn_guardar);
            Controls.Add(label4);
            Controls.Add(btn_atras);
            Controls.Add(btn_salir);
            Name = "Consulta_Ventas";
            Text = "Consulta_Ventas";
            Load += Consulta_Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)data_venta).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}