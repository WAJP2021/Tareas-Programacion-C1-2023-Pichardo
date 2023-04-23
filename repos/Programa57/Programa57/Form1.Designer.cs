namespace Programa57
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
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.ncControl2 = new Programa57.NcControl();
            this.ncControl1 = new Programa57.NcControl();
            this.miboton1 = new Programa57.Miboton();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ncControl2
            // 
            this.ncControl2.Location = new System.Drawing.Point(104, 130);
            this.ncControl2.Name = "ncControl2";
            this.ncControl2.Size = new System.Drawing.Size(8, 8);
            this.ncControl2.TabIndex = 1;
            this.ncControl2.Text = "ncControl2";
            this.ncControl2.UseVisualStyleBackColor = true;
            // 
            // ncControl1
            // 
            this.ncControl1.Location = new System.Drawing.Point(12, 12);
            this.ncControl1.Name = "ncControl1";
            this.ncControl1.Size = new System.Drawing.Size(75, 23);
            this.ncControl1.TabIndex = 0;
            this.ncControl1.Text = "ncControl1";
            this.ncControl1.UseVisualStyleBackColor = true;
            this.ncControl1.Click += new System.EventHandler(this.ncControl1_Click);
            // 
            // miboton1
            // 
            this.miboton1.Activado = false;
            this.miboton1.Location = new System.Drawing.Point(67, 447);
            this.miboton1.Name = "miboton1";
            this.miboton1.Size = new System.Drawing.Size(706, 29);
            this.miboton1.TabIndex = 2;
            this.miboton1.Text = "Dame click, gracias por su esfuerzo maestro ha sido un placer!!!";
            this.miboton1.Click += new System.EventHandler(this.miboton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 662);
            this.Controls.Add(this.miboton1);
            this.Controls.Add(this.ncControl2);
            this.Controls.Add(this.ncControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NcControl ncControl1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private NcControl ncControl2;
        private Miboton miboton1;
    }
}

