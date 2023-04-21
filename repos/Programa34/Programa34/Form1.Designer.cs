namespace Programa34
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lblAbrir = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "miArchivo.png";
            this.openFileDialog1.Filter = "Archivos PNG (*.png)|*.png|Archivos de texto (*.txt)|*.txt";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(11, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblAbrir
            // 
            this.lblAbrir.AutoSize = true;
            this.lblAbrir.Location = new System.Drawing.Point(8, 54);
            this.lblAbrir.Name = "lblAbrir";
            this.lblAbrir.Size = new System.Drawing.Size(35, 13);
            this.lblAbrir.TabIndex = 1;
            this.lblAbrir.Text = "label1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(157, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblSalvar
            // 
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Location = new System.Drawing.Point(8, 87);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(35, 13);
            this.lblSalvar.TabIndex = 3;
            this.lblSalvar.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblAbrir);
            this.Controls.Add(this.btnAbrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblAbrir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

