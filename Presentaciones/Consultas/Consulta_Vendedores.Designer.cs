namespace Presentaciones.Consultas
{
    partial class Consulta_Vendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Vendedores));
            label5 = new Label();
            data_vendedores = new DataGridView();
            btn_consulta = new Button();
            label4 = new Label();
            label2 = new Label();
            btn_atras = new Button();
            btn_salir = new Button();
            comboBox_vendedores = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)data_vendedores).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(46, 265);
            label5.Name = "label5";
            label5.Size = new Size(217, 29);
            label5.TabIndex = 64;
            label5.Text = "Consulta realizada:";
            // 
            // data_vendedores
            // 
            data_vendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_vendedores.Location = new Point(93, 319);
            data_vendedores.Name = "data_vendedores";
            data_vendedores.RowHeadersWidth = 51;
            data_vendedores.Size = new Size(787, 205);
            data_vendedores.TabIndex = 63;
            // 
            // btn_consulta
            // 
            btn_consulta.BackColor = Color.Transparent;
            btn_consulta.BackgroundImage = (Image)resources.GetObject("btn_consulta.BackgroundImage");
            btn_consulta.BackgroundImageLayout = ImageLayout.Stretch;
            btn_consulta.Cursor = Cursors.Hand;
            btn_consulta.Location = new Point(488, 125);
            btn_consulta.Name = "btn_consulta";
            btn_consulta.Size = new Size(59, 55);
            btn_consulta.TabIndex = 62;
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
            label4.Location = new Point(290, 22);
            label4.Name = "label4";
            label4.Size = new Size(417, 48);
            label4.TabIndex = 59;
            label4.Text = "Consulta de Vendedores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(66, 125);
            label2.Name = "label2";
            label2.Size = new Size(183, 36);
            label2.TabIndex = 58;
            label2.Text = "Id Vendedor:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Transparent;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.Location = new Point(835, 554);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(45, 47);
            btn_atras.TabIndex = 57;
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
            btn_salir.Location = new Point(906, 562);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(34, 39);
            btn_salir.TabIndex = 56;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // comboBox_vendedores
            // 
            comboBox_vendedores.FormattingEnabled = true;
            comboBox_vendedores.Location = new Point(255, 133);
            comboBox_vendedores.Name = "comboBox_vendedores";
            comboBox_vendedores.Size = new Size(185, 28);
            comboBox_vendedores.TabIndex = 89;
            // 
            // Consulta_Vendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(970, 620);
            Controls.Add(comboBox_vendedores);
            Controls.Add(label5);
            Controls.Add(data_vendedores);
            Controls.Add(btn_consulta);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btn_atras);
            Controls.Add(btn_salir);
            Name = "Consulta_Vendedores";
            Text = "Consulta_Vendedores";
            Load += Consulta_Vendedores_Load;
            ((System.ComponentModel.ISupportInitialize)data_vendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView data_vendedores;
        private Button btn_consulta;
        private Label label4;
        private Label label2;
        private Button btn_atras;
        private Button btn_salir;
        private ComboBox comboBox_vendedores;
    }
}