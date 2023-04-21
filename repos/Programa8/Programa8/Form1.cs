using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa8
{
    public partial class Form1 : Form
    {
        Form2 miforma2 = new Form2("Saludos");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnvio1_Click(object sender, EventArgs e)
        {
            //Creamos la instancia de la forma 2
          

            miforma2.Comentario = txtMensaje.Text;

            //Mostramos la forma
            miforma2.Show();
        }

        private void btnEnvio2_Click(object sender, EventArgs e)
        {
            miforma2.Comentario = txtMensaje.Text;
        }
    }
}
