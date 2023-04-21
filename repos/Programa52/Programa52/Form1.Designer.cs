namespace Programa52
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
            this.lblArchivo = new System.Windows.Forms.Label();
            this.txtContenidos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(0, 0);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(35, 13);
            this.lblArchivo.TabIndex = 0;
            this.lblArchivo.Text = "label1";
            // 
            // txtContenidos
            // 
            this.txtContenidos.AllowDrop = true;
            this.txtContenidos.Location = new System.Drawing.Point(12, 16);
            this.txtContenidos.Multiline = true;
            this.txtContenidos.Name = "txtContenidos";
            this.txtContenidos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContenidos.Size = new System.Drawing.Size(425, 422);
            this.txtContenidos.TabIndex = 1;
            this.txtContenidos.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtContenidos_DragDrop);
            this.txtContenidos.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtContenidos_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.txtContenidos);
            this.Controls.Add(this.lblArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.TextBox txtContenidos;
    }
}

