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

            if(pbrTrabajo.Value<100)
            pbrTrabajo.Value++;
            if (pbrTrabajo.Value == 100)
                tmrPrueba.Enabled = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = true;
            pbrTrabajo.Value = 0;
            
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = false;
            tbrIntervalo.Value = tbrIntervalo.Minimum;
            lblTValor.Text = tbrIntervalo.Value.ToString();
            tmrPrueba.Interval = tbrIntervalo.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrPrueba.Enabled=false;
        }

        private void tbrIntervalo_Scroll(object sender, EventArgs e)
        {
            lblTValor.Text= tbrIntervalo.Value.ToString();
            tmrPrueba.Interval = tbrIntervalo.Value;
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < 100000; n++)
            {
                //aqui algun proceso

                if (n % 1000 == 0)
                    pbrTrabajo.PerformStep();
            }
        }
    }
}
