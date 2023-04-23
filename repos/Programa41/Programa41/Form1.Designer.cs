namespace Programa41
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarVentana1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarVentana2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarVentana1ToolStripMenuItem,
            this.adicionarVentana2ToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // adicionarVentana1ToolStripMenuItem
            // 
            this.adicionarVentana1ToolStripMenuItem.Name = "adicionarVentana1ToolStripMenuItem";
            this.adicionarVentana1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarVentana1ToolStripMenuItem.Text = "Adicionar Ventana 1";
            this.adicionarVentana1ToolStripMenuItem.Click += new System.EventHandler(this.adicionarVentana1ToolStripMenuItem_Click);
            // 
            // adicionarVentana2ToolStripMenuItem
            // 
            this.adicionarVentana2ToolStripMenuItem.Name = "adicionarVentana2ToolStripMenuItem";
            this.adicionarVentana2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarVentana2ToolStripMenuItem.Text = "Adicionar Ventana 2";
            this.adicionarVentana2ToolStripMenuItem.Click += new System.EventHandler(this.adicionarVentana2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarVentana1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarVentana2ToolStripMenuItem;
    }
}

