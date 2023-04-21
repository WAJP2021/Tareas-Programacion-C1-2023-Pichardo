namespace Programa33
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.btnFechas = new System.Windows.Forms.Button();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BoldedDates = new System.DateTime[] {
        new System.DateTime(2023, 4, 19, 15, 45, 53, 0)};
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.MonthlyBoldedDates = new System.DateTime[] {
        new System.DateTime(2023, 4, 18, 0, 0, 0, 0)};
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(35, 191);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(35, 13);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "label1";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(35, 216);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(35, 13);
            this.lblFinal.TabIndex = 2;
            this.lblFinal.Text = "label1";
            // 
            // btnFechas
            // 
            this.btnFechas.Location = new System.Drawing.Point(239, 12);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.Size = new System.Drawing.Size(155, 23);
            this.btnFechas.TabIndex = 3;
            this.btnFechas.Text = "Seleccionar Fechas";
            this.btnFechas.UseVisualStyleBackColor = true;
            this.btnFechas.Click += new System.EventHandler(this.btnFechas_Click);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(35, 248);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(35, 13);
            this.lblSeleccion.TabIndex = 4;
            this.lblSeleccion.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.btnFechas);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Button btnFechas;
        private System.Windows.Forms.Label lblSeleccion;
    }
}

