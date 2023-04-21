using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa13
{
    public partial class Form1 : Form
    {
        private int conteo;
        public Form1()
        {
            InitializeComponent();
            conteo = 0;
        }

        private void tmrPrueba_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblValor.Text = conteo.ToString();  
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = true;
            
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrPrueba.Enabled=false;
        }
    }
}
