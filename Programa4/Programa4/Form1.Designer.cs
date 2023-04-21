namespace Programa4
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
            this.chkMonitor = new System.Windows.Forms.CheckBox();
            this.chkTeclado = new System.Windows.Forms.CheckBox();
            this.chkMouse = new System.Windows.Forms.CheckBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkMonitor
            // 
            this.chkMonitor.AutoSize = true;
            this.chkMonitor.Location = new System.Drawing.Point(183, 125);
            this.chkMonitor.Name = "chkMonitor";
            this.chkMonitor.Size = new System.Drawing.Size(91, 17);
            this.chkMonitor.TabIndex = 0;
            this.chkMonitor.Text = "Monitor $250 ";
            this.chkMonitor.UseVisualStyleBackColor = true;
            this.chkMonitor.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
            // 
            // chkTeclado
            // 
            this.chkTeclado.AutoSize = true;
            this.chkTeclado.Location = new System.Drawing.Point(183, 148);
            this.chkTeclado.Name = "chkTeclado";
            this.chkTeclado.Size = new System.Drawing.Size(86, 17);
            this.chkTeclado.TabIndex = 1;
            this.chkTeclado.Text = "Teclado $15";
            this.chkTeclado.UseVisualStyleBackColor = true;
            this.chkTeclado.CheckedChanged += new System.EventHandler(this.chkTeclado_CheckedChanged);
            // 
            // chkMouse
            // 
            this.chkMouse.AutoSize = true;
            this.chkMouse.Location = new System.Drawing.Point(183, 171);
            this.chkMouse.Name = "chkMouse";
            this.chkMouse.Size = new System.Drawing.Size(79, 17);
            this.chkMouse.TabIndex = 2;
            this.chkMouse.Text = "Mouse $20";
            this.chkMouse.UseVisualStyleBackColor = true;
            this.chkMouse.CheckedChanged += new System.EventHandler(this.chkMouse_CheckedChanged);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(180, 236);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "label1";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(419, 121);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.chkMouse);
            this.Controls.Add(this.chkTeclado);
            this.Controls.Add(this.chkMonitor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMonitor;
        private System.Windows.Forms.CheckBox chkTeclado;
        private System.Windows.Forms.CheckBox chkMouse;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnCalcular;
    }
}

