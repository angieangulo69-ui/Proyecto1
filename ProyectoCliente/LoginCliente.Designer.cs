namespace ProyectoCliente
{
    partial class LoginCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCliente));
            btn_login = new Button();
            label1 = new Label();
            panel1 = new Panel();
            btnSalir = new Button();
            panel2 = new Panel();
            lbl_Mensaje = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txt_identificacion = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.MistyRose;
            btn_login.Location = new Point(259, 120);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(93, 29);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(129, 26);
            label1.Name = "label1";
            label1.Size = new Size(486, 35);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE VENTA DE BOLETOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 82);
            panel1.TabIndex = 5;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(612, 235);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_Mensaje);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(txt_identificacion);
            panel2.Controls.Add(btn_login);
            panel2.Controls.Add(btnSalir);
            panel2.Location = new Point(41, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 287);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // lbl_Mensaje
            // 
            lbl_Mensaje.AutoSize = true;
            lbl_Mensaje.Location = new Point(63, 89);
            lbl_Mensaje.Name = "lbl_Mensaje";
            lbl_Mensaje.Size = new Size(0, 20);
            lbl_Mensaje.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(41, 41);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 7;
            label2.Text = "Identificación:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(455, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 122);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txt_identificacion
            // 
            txt_identificacion.Location = new Point(193, 41);
            txt_identificacion.Name = "txt_identificacion";
            txt_identificacion.Size = new Size(211, 27);
            txt_identificacion.TabIndex = 5;
            // 
            // LoginCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "LoginCliente";
            Text = "LoginCliente";
            Load += LoginCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_login;
        private Label label1;
        private Panel panel1;
        private Button btnSalir;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txt_identificacion;
        private Label lbl_Mensaje;
    }
}