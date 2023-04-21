namespace Programa53
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnAlto = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnIr = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 450);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(26, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(23, 23);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(55, 12);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(23, 23);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(84, 12);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(23, 23);
            this.btnRecargar.TabIndex = 3;
            this.btnRecargar.Text = "R";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnAlto
            // 
            this.btnAlto.Location = new System.Drawing.Point(113, 12);
            this.btnAlto.Name = "btnAlto";
            this.btnAlto.Size = new System.Drawing.Size(23, 23);
            this.btnAlto.TabIndex = 4;
            this.btnAlto.Text = "S";
            this.btnAlto.UseVisualStyleBackColor = true;
            this.btnAlto.Click += new System.EventHandler(this.btnAlto_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(142, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(23, 23);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "H";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(638, 12);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(23, 23);
            this.btnIr.TabIndex = 6;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(171, 15);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(461, 20);
            this.txtURL.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAlto);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnAlto;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.TextBox txtURL;
    }
}

