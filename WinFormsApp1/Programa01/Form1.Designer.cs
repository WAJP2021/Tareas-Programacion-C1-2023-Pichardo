namespace Programa01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSaludo = new Button();
            lbMensaje = new Label();
            SuspendLayout();
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(51, 116);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(75, 23);
            btnSaludo.TabIndex = 0;
            btnSaludo.Text = "Saludo";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // lbMensaje
            // 
            lbMensaje.AutoSize = true;
            lbMensaje.Location = new Point(51, 51);
            lbMensaje.Name = "lbMensaje";
            lbMensaje.Size = new Size(38, 15);
            lbMensaje.TabIndex = 1;
            lbMensaje.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbMensaje);
            Controls.Add(btnSaludo);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaludo;
        private Label lbMensaje;
    }
}