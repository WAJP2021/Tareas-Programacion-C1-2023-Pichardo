using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void miboton1_Click(object sender, EventArgs e)
        {
            miboton1.Activado= !miboton1.Activado;
        }

        private void ncControl1_Click(object sender, EventArgs e)
        {
            miboton1.Activado = !miboton1.Activado;
        }
    }
}
