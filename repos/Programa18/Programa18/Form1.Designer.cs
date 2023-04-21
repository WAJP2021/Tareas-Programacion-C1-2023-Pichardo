namespace Programa18
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
            this.dupFrutas = new System.Windows.Forms.DomainUpDown();
            this.txtFrutas = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dupFrutas
            // 
            this.dupFrutas.Location = new System.Drawing.Point(12, 215);
            this.dupFrutas.Name = "dupFrutas";
            this.dupFrutas.Size = new System.Drawing.Size(120, 20);
            this.dupFrutas.TabIndex = 0;
            this.dupFrutas.Text = "Frutas";
            this.dupFrutas.SelectedItemChanged += new System.EventHandler(this.dupFrutas_SelectedItemChanged);
            // 
            // txtFrutas
            // 
            this.txtFrutas.Location = new System.Drawing.Point(12, 57);
            this.txtFrutas.Name = "txtFrutas";
            this.txtFrutas.Size = new System.Drawing.Size(100, 20);
            this.txtFrutas.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(232, 57);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(9, 161);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "label1";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(232, 86);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 310);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtFrutas);
            this.Controls.Add(this.dupFrutas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dupFrutas;
        private System.Windows.Forms.TextBox txtFrutas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnBorrar;
    }
}

