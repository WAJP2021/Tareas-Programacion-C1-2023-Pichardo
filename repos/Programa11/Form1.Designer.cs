namespace Programa11
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuTxtA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstOperaciones = new System.Windows.Forms.ToolStrip();
            this.tstbSuma = new System.Windows.Forms.ToolStripButton();
            this.tstbResta = new System.Windows.Forms.ToolStripButton();
            this.tstbMulti = new System.Windows.Forms.ToolStripButton();
            this.tstbDiv = new System.Windows.Forms.ToolStripButton();
            this.stsInformacion = new System.Windows.Forms.StatusStrip();
            this.slblValores = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblOperacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblResultado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.cmnuTxtA.SuspendLayout();
            this.tstOperaciones.SuspendLayout();
            this.stsInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.AutoToolTip = true;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.ToolTipText = "Quitar la aplicacion";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiToolStripMenuItem,
            this.divToolStripMenuItem,
            this.toolStripSeparator1,
            this.habilitarToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaToolStripMenuItem.Text = "Resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // multiToolStripMenuItem
            // 
            this.multiToolStripMenuItem.Name = "multiToolStripMenuItem";
            this.multiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.multiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multiToolStripMenuItem.Text = "Multi";
            this.multiToolStripMenuItem.Click += new System.EventHandler(this.multiToolStripMenuItem_Click);
            // 
            // divToolStripMenuItem
            // 
            this.divToolStripMenuItem.Name = "divToolStripMenuItem";
            this.divToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.divToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.divToolStripMenuItem.Text = "Div";
            this.divToolStripMenuItem.Click += new System.EventHandler(this.divToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acerdaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.acerdaDeToolStripMenuItem.Text = "Acerda de...";
            this.acerdaDeToolStripMenuItem.Click += new System.EventHandler(this.acerdaDeToolStripMenuItem_Click);
            // 
            // txtA
            // 
            this.txtA.ContextMenuStrip = this.cmnuTxtA;
            this.txtA.Location = new System.Drawing.Point(12, 63);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(12, 89);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 2;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(231, 63);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(35, 13);
            this.lblResultados.TabIndex = 3;
            this.lblResultados.Text = "label1";
            this.lblResultados.Click += new System.EventHandler(this.lblResultados_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Checked = true;
            this.habilitarToolStripMenuItem.CheckOnClick = true;
            this.habilitarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.habilitarToolStripMenuItem.Text = "Habilitar";
            this.habilitarToolStripMenuItem.Click += new System.EventHandler(this.habilitarToolStripMenuItem_Click);
            // 
            // cmnuTxtA
            // 
            this.cmnuTxtA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarToolStripMenuItem,
            this.aleatorioToolStripMenuItem});
            this.cmnuTxtA.Name = "cmnuTxtA";
            this.cmnuTxtA.Size = new System.Drawing.Size(123, 48);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // aleatorioToolStripMenuItem
            // 
            this.aleatorioToolStripMenuItem.Name = "aleatorioToolStripMenuItem";
            this.aleatorioToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aleatorioToolStripMenuItem.Text = "Aleatorio";
            this.aleatorioToolStripMenuItem.Click += new System.EventHandler(this.aleatorioToolStripMenuItem_Click);
            // 
            // tstOperaciones
            // 
            this.tstOperaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbSuma,
            this.tstbResta,
            this.tstbMulti,
            this.tstbDiv});
            this.tstOperaciones.Location = new System.Drawing.Point(0, 24);
            this.tstOperaciones.Name = "tstOperaciones";
            this.tstOperaciones.Size = new System.Drawing.Size(358, 25);
            this.tstOperaciones.TabIndex = 5;
            this.tstOperaciones.Text = "toolStrip1";
            // 
            // tstbSuma
            // 
            this.tstbSuma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbSuma.Image = ((System.Drawing.Image)(resources.GetObject("tstbSuma.Image")));
            this.tstbSuma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbSuma.Name = "tstbSuma";
            this.tstbSuma.Size = new System.Drawing.Size(23, 22);
            this.tstbSuma.Text = "Suma";
            this.tstbSuma.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // tstbResta
            // 
            this.tstbResta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbResta.Image = ((System.Drawing.Image)(resources.GetObject("tstbResta.Image")));
            this.tstbResta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbResta.Name = "tstbResta";
            this.tstbResta.Size = new System.Drawing.Size(23, 22);
            this.tstbResta.Text = "Resta";
            this.tstbResta.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // tstbMulti
            // 
            this.tstbMulti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbMulti.Image = ((System.Drawing.Image)(resources.GetObject("tstbMulti.Image")));
            this.tstbMulti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbMulti.Name = "tstbMulti";
            this.tstbMulti.Size = new System.Drawing.Size(23, 22);
            this.tstbMulti.Text = "Multiplicar";
            this.tstbMulti.Click += new System.EventHandler(this.multiToolStripMenuItem_Click);
            // 
            // tstbDiv
            // 
            this.tstbDiv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbDiv.Image = ((System.Drawing.Image)(resources.GetObject("tstbDiv.Image")));
            this.tstbDiv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbDiv.Name = "tstbDiv";
            this.tstbDiv.Size = new System.Drawing.Size(23, 22);
            this.tstbDiv.Text = "Division";
            this.tstbDiv.Click += new System.EventHandler(this.divToolStripMenuItem_Click);
            // 
            // stsInformacion
            // 
            this.stsInformacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblValores,
            this.slblOperacion,
            this.slblResultado});
            this.stsInformacion.Location = new System.Drawing.Point(0, 200);
            this.stsInformacion.Name = "stsInformacion";
            this.stsInformacion.Size = new System.Drawing.Size(358, 24);
            this.stsInformacion.TabIndex = 6;
            this.stsInformacion.Text = "statusStrip1";
            // 
            // slblValores
            // 
            this.slblValores.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.slblValores.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.slblValores.Name = "slblValores";
            this.slblValores.Size = new System.Drawing.Size(66, 19);
            this.slblValores.Text = "A= 0, B= 0";
            // 
            // slblOperacion
            // 
            this.slblOperacion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.slblOperacion.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.slblOperacion.Name = "slblOperacion";
            this.slblOperacion.Size = new System.Drawing.Size(89, 19);
            this.slblOperacion.Text = "Sin seleccionar";
            // 
            // slblResultado
            // 
            this.slblResultado.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.slblResultado.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.slblResultado.Name = "slblResultado";
            this.slblResultado.Size = new System.Drawing.Size(35, 19);
            this.slblResultado.Text = "R= 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 224);
            this.Controls.Add(this.stsInformacion);
            this.Controls.Add(this.tstOperaciones);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmnuTxtA.ResumeLayout(false);
            this.tstOperaciones.ResumeLayout(false);
            this.tstOperaciones.PerformLayout();
            this.stsInformacion.ResumeLayout(false);
            this.stsInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acerdaDeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmnuTxtA;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tstOperaciones;
        private System.Windows.Forms.ToolStripButton tstbSuma;
        private System.Windows.Forms.ToolStripButton tstbResta;
        private System.Windows.Forms.ToolStripButton tstbMulti;
        private System.Windows.Forms.ToolStripButton tstbDiv;
        private System.Windows.Forms.StatusStrip stsInformacion;
        private System.Windows.Forms.ToolStripStatusLabel slblValores;
        private System.Windows.Forms.ToolStripStatusLabel slblOperacion;
        private System.Windows.Forms.ToolStripStatusLabel slblResultado;
    }
}

