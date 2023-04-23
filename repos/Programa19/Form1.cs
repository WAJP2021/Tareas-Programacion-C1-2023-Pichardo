using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adicionar elementos
            lstFrutas.Items.Add("Banana");
            lstFrutas.Items.Add("Durazno");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            lstFrutas.Items.Add(txtFrutas.Text);

            txtFrutas.Text = string.Empty;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {   if(lstFrutas.SelectedIndex!= -1)

            lblFrutas.Text = (string) lstFrutas.Items[lstFrutas.SelectedIndex];
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int indice = lstFrutas.SelectedIndex;

            if(indice == -1)
            {
                lstFrutas.Items.RemoveAt(indice);
            }
        }
    }
}
