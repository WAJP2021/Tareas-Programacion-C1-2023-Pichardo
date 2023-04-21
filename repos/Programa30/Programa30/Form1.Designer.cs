namespace Programa30
{
    partial class Form1
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnFuente = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 23);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(67, 13);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Hola a todos";
            // 
            // btnFuente
            // 
            this.btnFuente.Location = new System.Drawing.Point(401, 23);
            this.btnFuente.Name = "btnFuente";
            this.btnFuente.Size = new System.Drawing.Size(75, 23);
            this.btnFuente.TabIndex = 1;
            this.btnFuente.Text = "Fuente";
            this.btnFuente.UseVisualStyleBackColor = true;
            this.btnFuente.Click += new System.EventHandler(this.btnFuente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFuente);
            this.Controls.Add(this.lblMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnFuente;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

