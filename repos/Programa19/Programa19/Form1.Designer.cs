namespace Programa19
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
            this.lstFrutas = new System.Windows.Forms.ListBox();
            this.txtFrutas = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblFrutas = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFrutas
            // 
            this.lstFrutas.FormattingEnabled = true;
            this.lstFrutas.Items.AddRange(new object[] {
            "Manzana",
            "Aguacate",
            "Pera"});
            this.lstFrutas.Location = new System.Drawing.Point(12, 190);
            this.lstFrutas.Name = "lstFrutas";
            this.lstFrutas.Size = new System.Drawing.Size(120, 95);
            this.lstFrutas.TabIndex = 0;
            this.lstFrutas.SelectedIndexChanged += new System.EventHandler(this.lstFrutas_SelectedIndexChanged);
            // 
            // txtFrutas
            // 
            this.txtFrutas.Location = new System.Drawing.Point(12, 101);
            this.txtFrutas.Name = "txtFrutas";
            this.txtFrutas.Size = new System.Drawing.Size(100, 20);
            this.txtFrutas.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(159, 101);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblFrutas
            // 
            this.lblFrutas.AutoSize = true;
            this.lblFrutas.Location = new System.Drawing.Point(12, 157);
            this.lblFrutas.Name = "lblFrutas";
            this.lblFrutas.Size = new System.Drawing.Size(35, 13);
            this.lblFrutas.TabIndex = 3;
            this.lblFrutas.Text = "label1";
            this.lblFrutas.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(159, 130);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 394);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblFrutas);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtFrutas);
            this.Controls.Add(this.lstFrutas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFrutas;
        private System.Windows.Forms.TextBox txtFrutas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblFrutas;
        private System.Windows.Forms.Button btnEliminar;
    }
}

