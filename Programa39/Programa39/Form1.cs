using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionaNodo_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(txtNodo.Text);
            txtNodo.Text = "";

        }

        private void btnAdicionaElemento_Click(object sender, EventArgs e)
        {
treeView1.SelectedNode.Nodes.Add(txtElemento.Text);
            txtElemento.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
treeView1.Nodes.Clear();
        }

        private void btnEliminaNodo_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }
    }
}
