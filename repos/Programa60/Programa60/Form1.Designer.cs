namespace Programa60
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnBeep = new System.Windows.Forms.Button();
            this.btnTono = new System.Windows.Forms.Button();
            this.btnSistema = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnTocar = new System.Windows.Forms.Button();
            this.txtFreq = new System.Windows.Forms.TextBox();
            this.txtDura = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Freq";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dura";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(101, 277);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(35, 13);
            this.lblRuta.TabIndex = 2;
            this.lblRuta.Text = "label3";
            // 
            // btnBeep
            // 
            this.btnBeep.Location = new System.Drawing.Point(501, 12);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(75, 23);
            this.btnBeep.TabIndex = 3;
            this.btnBeep.Text = "Beep";
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // btnTono
            // 
            this.btnTono.Location = new System.Drawing.Point(501, 118);
            this.btnTono.Name = "btnTono";
            this.btnTono.Size = new System.Drawing.Size(75, 23);
            this.btnTono.TabIndex = 4;
            this.btnTono.Text = "Tono";
            this.btnTono.UseVisualStyleBackColor = true;
            this.btnTono.Click += new System.EventHandler(this.btnTono_Click);
            // 
            // btnSistema
            // 
            this.btnSistema.Location = new System.Drawing.Point(501, 147);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(75, 23);
            this.btnSistema.TabIndex = 5;
            this.btnSistema.Text = "Sistema";
            this.btnSistema.UseVisualStyleBackColor = true;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(104, 302);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnTocar
            // 
            this.btnTocar.Location = new System.Drawing.Point(501, 302);
            this.btnTocar.Name = "btnTocar";
            this.btnTocar.Size = new System.Drawing.Size(75, 23);
            this.btnTocar.TabIndex = 7;
            this.btnTocar.Text = "Tocar";
            this.btnTocar.UseVisualStyleBackColor = true;
            this.btnTocar.Click += new System.EventHandler(this.btnTocar_Click);
            // 
            // txtFreq
            // 
            this.txtFreq.Location = new System.Drawing.Point(41, 9);
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(100, 20);
            this.txtFreq.TabIndex = 8;
            this.txtFreq.Text = "3000";
            // 
            // txtDura
            // 
            this.txtDura.Location = new System.Drawing.Point(41, 35);
            this.txtDura.Name = "txtDura";
            this.txtDura.Size = new System.Drawing.Size(100, 20);
            this.txtDura.TabIndex = 9;
            this.txtDura.Text = "200";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Wav|*.wav";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDura);
            this.Controls.Add(this.txtFreq);
            this.Controls.Add(this.btnTocar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnSistema);
            this.Controls.Add(this.btnTono);
            this.Controls.Add(this.btnBeep);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.Button btnTono;
        private System.Windows.Forms.Button btnSistema;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnTocar;
        private System.Windows.Forms.TextBox txtFreq;
        private System.Windows.Forms.TextBox txtDura;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

