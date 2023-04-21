using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            Console.Beep();

            if (((Button)sender).Name == "btnUno")
                MessageBox.Show("Es el boton uno");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            Console.Beep();
            if (((Button)sender).Name == "btnDos")
                lblMensaje.Text = "Se oprimio el boton dos";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            Console.Beep();
            if (((Button)sender).Name == "btnTres")
            {
                lblMensaje.Text = ((Button)sender).Text;
                ((Button)sender).Text = "Oprimido";
            }
        }
    }
}
