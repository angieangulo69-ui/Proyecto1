namespace ProyectoCliente
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_Mensaje = new Label();
            btn_consultaboletos = new Button();
            btnSalir = new Button();
            btnCompraboletos = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(123, 13);
            label1.Name = "label1";
            label1.Size = new Size(465, 37);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE VENTA DE BOLETOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(29, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 82);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lbl_Mensaje);
            panel2.Controls.Add(btn_consultaboletos);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnCompraboletos);
            panel2.Location = new Point(37, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 287);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(420, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 110);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lbl_Mensaje
            // 
            lbl_Mensaje.AutoSize = true;
            lbl_Mensaje.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Mensaje.ForeColor = SystemColors.HotTrack;
            lbl_Mensaje.Location = new Point(41, 23);
            lbl_Mensaje.Name = "lbl_Mensaje";
            lbl_Mensaje.Size = new Size(0, 24);
            lbl_Mensaje.TabIndex = 3;
            // 
            // btn_consultaboletos
            // 
            btn_consultaboletos.BackColor = Color.FromArgb(224, 224, 224);
            btn_consultaboletos.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultaboletos.Location = new Point(115, 171);
            btn_consultaboletos.Name = "btn_consultaboletos";
            btn_consultaboletos.Size = new Size(226, 40);
            btn_consultaboletos.TabIndex = 2;
            btn_consultaboletos.Text = "Consulta Boletos";
            btn_consultaboletos.UseVisualStyleBackColor = false;
            btn_consultaboletos.Click += btn_consultaboletos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(612, 235);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCompraboletos
            // 
            btnCompraboletos.BackColor = Color.FromArgb(224, 224, 224);
            btnCompraboletos.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompraboletos.Location = new Point(115, 102);
            btnCompraboletos.Name = "btnCompraboletos";
            btnCompraboletos.Size = new Size(226, 40);
            btnCompraboletos.TabIndex = 0;
            btnCompraboletos.Text = "Comprar Boletos";
            btnCompraboletos.UseVisualStyleBackColor = false;
            btnCompraboletos.Click += btnCompraboletos_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormCliente";
            Text = "FormCliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button btn_consultaboletos;
        private Button btnSalir;
        private Button btnCompraboletos;
        private Label lbl_Mensaje;
        private PictureBox pictureBox1;
    }
}