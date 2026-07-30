namespace Presentaciones
{
    partial class FormServidor
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
            panel1 = new Panel();
            button1 = new Button();
            lblEstado = new Label();
            label = new Label();
            btnDetener = new Button();
            btnIniciar = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            listConectados = new ListBox();
            Bitácora = new GroupBox();
            txtBitacora = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            Bitácora.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblEstado);
            panel1.Controls.Add(label);
            panel1.Controls.Add(btnDetener);
            panel1.Controls.Add(btnIniciar);
            panel1.Location = new Point(49, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 125);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(436, 57);
            button1.Name = "button1";
            button1.Size = new Size(168, 29);
            button1.TabIndex = 5;
            button1.Text = "Administrador";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(79, 13);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(73, 20);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Sin iniciar";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(16, 13);
            label.Name = "label";
            label.Size = new Size(57, 20);
            label.TabIndex = 3;
            label.Text = "Estado:";
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(178, 57);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(94, 29);
            btnDetener.TabIndex = 1;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(46, 57);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 12);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 0;
            label1.Text = "Información del Servidor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listConectados);
            groupBox1.Location = new Point(49, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 332);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clientes Conectados";
            // 
            // listConectados
            // 
            listConectados.FormattingEnabled = true;
            listConectados.Location = new Point(6, 22);
            listConectados.Name = "listConectados";
            listConectados.Size = new Size(266, 304);
            listConectados.TabIndex = 0;
            // 
            // Bitácora
            // 
            Bitácora.Controls.Add(txtBitacora);
            Bitácora.Location = new Point(384, 199);
            Bitácora.Name = "Bitácora";
            Bitácora.Size = new Size(250, 326);
            Bitácora.TabIndex = 3;
            Bitácora.TabStop = false;
            Bitácora.Text = "Bitácora";
            // 
            // txtBitacora
            // 
            txtBitacora.Location = new Point(0, 22);
            txtBitacora.Multiline = true;
            txtBitacora.Name = "txtBitacora";
            txtBitacora.Size = new Size(250, 304);
            txtBitacora.TabIndex = 0;
            // 
            // Servidor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 543);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Bitácora);
            Name = "Servidor";
            Text = "Servidor";
            Load += Servidor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            Bitácora.ResumeLayout(false);
            Bitácora.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnDetener;
        private Button btnIniciar;
        private Label label;
        private GroupBox groupBox1;
        private Label lblEstado;
        private ListBox listConectados;
        private GroupBox Bitácora;
        private TextBox txtBitacora;
        private Button button1;
    }
}