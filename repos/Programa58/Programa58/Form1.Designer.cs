namespace Programa58
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAbrirNotepad = new System.Windows.Forms.Button();
            this.btnCerrarNotepad = new System.Windows.Forms.Button();
            this.prcNotePad = new System.Diagnostics.Process();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esconderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(83, 112);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 13);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Esperando";
            // 
            // btnAbrirNotepad
            // 
            this.btnAbrirNotepad.Location = new System.Drawing.Point(225, 91);
            this.btnAbrirNotepad.Name = "btnAbrirNotepad";
            this.btnAbrirNotepad.Size = new System.Drawing.Size(93, 23);
            this.btnAbrirNotepad.TabIndex = 1;
            this.btnAbrirNotepad.Text = "Abrir Notepad";
            this.btnAbrirNotepad.UseVisualStyleBackColor = true;
            this.btnAbrirNotepad.Click += new System.EventHandler(this.btnAbrirNotepad_Click);
            // 
            // btnCerrarNotepad
            // 
            this.btnCerrarNotepad.Location = new System.Drawing.Point(225, 120);
            this.btnCerrarNotepad.Name = "btnCerrarNotepad";
            this.btnCerrarNotepad.Size = new System.Drawing.Size(93, 23);
            this.btnCerrarNotepad.TabIndex = 2;
            this.btnCerrarNotepad.Text = "Cerrar Notepad";
            this.btnCerrarNotepad.UseVisualStyleBackColor = true;
            this.btnCerrarNotepad.Click += new System.EventHandler(this.btnCerrarNotepad_Click);
            // 
            // prcNotePad
            // 
            this.prcNotePad.StartInfo.Domain = "";
            this.prcNotePad.StartInfo.FileName = "notepad.exe";
            this.prcNotePad.StartInfo.LoadUserProfile = false;
            this.prcNotePad.StartInfo.Password = null;
            this.prcNotePad.StartInfo.StandardErrorEncoding = null;
            this.prcNotePad.StartInfo.StandardOutputEncoding = null;
            this.prcNotePad.StartInfo.UserName = "";
            this.prcNotePad.StartInfo.WorkingDirectory = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs";
            this.prcNotePad.SynchronizingObject = this;
            this.prcNotePad.Exited += new System.EventHandler(this.prcNotePad_Exited);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.esconderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // esconderToolStripMenuItem
            // 
            this.esconderToolStripMenuItem.Name = "esconderToolStripMenuItem";
            this.esconderToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.esconderToolStripMenuItem.Text = "Esconder";
            this.esconderToolStripMenuItem.Click += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Abre Aplicaciones";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarNotepad);
            this.Controls.Add(this.btnAbrirNotepad);
            this.Controls.Add(this.lblEstado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnAbrirNotepad;
        private System.Windows.Forms.Button btnCerrarNotepad;
        private System.Diagnostics.Process prcNotePad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esconderToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

