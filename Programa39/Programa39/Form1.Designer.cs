namespace Programa39
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAdicionaNodo = new System.Windows.Forms.Button();
            this.btnAdicionaElemento = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminaNodo = new System.Windows.Forms.Button();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(35, 34);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 321);
            this.treeView1.TabIndex = 0;
            // 
            // btnAdicionaNodo
            // 
            this.btnAdicionaNodo.Location = new System.Drawing.Point(318, 32);
            this.btnAdicionaNodo.Name = "btnAdicionaNodo";
            this.btnAdicionaNodo.Size = new System.Drawing.Size(136, 23);
            this.btnAdicionaNodo.TabIndex = 1;
            this.btnAdicionaNodo.Text = "Adiciona Nodo";
            this.btnAdicionaNodo.UseVisualStyleBackColor = true;
            this.btnAdicionaNodo.Click += new System.EventHandler(this.btnAdicionaNodo_Click);
            // 
            // btnAdicionaElemento
            // 
            this.btnAdicionaElemento.Location = new System.Drawing.Point(318, 61);
            this.btnAdicionaElemento.Name = "btnAdicionaElemento";
            this.btnAdicionaElemento.Size = new System.Drawing.Size(136, 23);
            this.btnAdicionaElemento.TabIndex = 2;
            this.btnAdicionaElemento.Text = "Adiciona Elemento";
            this.btnAdicionaElemento.UseVisualStyleBackColor = true;
            this.btnAdicionaElemento.Click += new System.EventHandler(this.btnAdicionaElemento_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(318, 90);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar Arbol";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminaNodo
            // 
            this.btnEliminaNodo.Location = new System.Drawing.Point(318, 119);
            this.btnEliminaNodo.Name = "btnEliminaNodo";
            this.btnEliminaNodo.Size = new System.Drawing.Size(136, 25);
            this.btnEliminaNodo.TabIndex = 4;
            this.btnEliminaNodo.Text = "Elimina nodo";
            this.btnEliminaNodo.UseVisualStyleBackColor = true;
            this.btnEliminaNodo.Click += new System.EventHandler(this.btnEliminaNodo_Click);
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(192, 34);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNodo.TabIndex = 5;
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(192, 60);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 20);
            this.txtElemento.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.btnEliminaNodo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAdicionaElemento);
            this.Controls.Add(this.btnAdicionaNodo);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Adiciona Elemento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAdicionaNodo;
        private System.Windows.Forms.Button btnAdicionaElemento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminaNodo;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.TextBox txtElemento;
    }
}

