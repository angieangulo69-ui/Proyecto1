namespace Servidor
{
    partial class ServidorForm
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
            btnIniciar = new Button();
            panel1 = new Panel();
            listBoxBitacora = new ListBox();
            btnDetener = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(51, 176);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(listBoxBitacora);
            panel1.Controls.Add(btnDetener);
            panel1.Controls.Add(btnIniciar);
            panel1.Location = new Point(45, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 257);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // listBoxBitacora
            // 
            listBoxBitacora.FormattingEnabled = true;
            listBoxBitacora.Location = new Point(360, 20);
            listBoxBitacora.Name = "listBoxBitacora";
            listBoxBitacora.Size = new Size(304, 224);
            listBoxBitacora.TabIndex = 3;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(172, 176);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(94, 29);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            // 
            // ServidorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ServidorForm";
            Text = "ServidorForm";
            Load += ServidorForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private Panel panel1;
        private ListBox listBoxBitacora;
        private Button btnDetener;
    }
}