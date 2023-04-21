namespace Programa20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCargar = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(593, 67);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // picImagen
            // 
            this.picImagen.Image = ((System.Drawing.Image)(resources.GetObject("picImagen.Image")));
            this.picImagen.Location = new System.Drawing.Point(52, 80);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(391, 374);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImagen.TabIndex = 2;
            this.picImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 522);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.btnCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.PictureBox picImagen;
    }
}

