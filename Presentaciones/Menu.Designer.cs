namespace Presentaciones
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            btn_registro = new Button();
            btn_consultar = new Button();
            label2 = new Label();
            label3 = new Label();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(232, 59);
            label1.Name = "label1";
            label1.Size = new Size(320, 44);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido (a):";
            // 
            // btn_registro
            // 
            btn_registro.BackgroundImage = (Image)resources.GetObject("btn_registro.BackgroundImage");
            btn_registro.BackgroundImageLayout = ImageLayout.Stretch;
            btn_registro.Cursor = Cursors.Hand;
            btn_registro.Location = new Point(218, 163);
            btn_registro.Name = "btn_registro";
            btn_registro.Size = new Size(88, 82);
            btn_registro.TabIndex = 1;
            btn_registro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_registro.UseVisualStyleBackColor = true;
            btn_registro.Click += btn_registro_Click;
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = Color.Transparent;
            btn_consultar.BackgroundImage = (Image)resources.GetObject("btn_consultar.BackgroundImage");
            btn_consultar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_consultar.Cursor = Cursors.Hand;
            btn_consultar.Location = new Point(218, 271);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(88, 82);
            btn_consultar.TabIndex = 2;
            btn_consultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_consultar.UseVisualStyleBackColor = false;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(326, 194);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 3;
            label2.Text = "Registro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SpringGreen;
            label3.Location = new Point(326, 295);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 4;
            label3.Text = "Consulta";
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Transparent;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.Location = new Point(723, 438);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(54, 55);
            btn_salir.TabIndex = 6;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 505);
            Controls.Add(btn_salir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_consultar);
            Controls.Add(btn_registro);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_registro;
        private Button btn_consultar;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button btn_salir;
    }
}