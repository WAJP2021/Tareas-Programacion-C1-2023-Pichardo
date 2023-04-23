using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            bool error = false;

            foreach (char caracter in txtDato.Text)

            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            //Verificamos por la condicion de error
            if (error)
            {
                errorProvider1.SetError(txtDato, "No se adminten numeros");

            }
            else
                errorProvider1.Clear();
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {
            bool error = false;

            foreach (char caracter in txtDato.Text)

            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            //Verificamos por la condicion de error
            if (error)
            {
                errorProvider1.SetError(txtDato, "No se adminten numeros");

            }
            else
                errorProvider1.Clear();
        }
    }
}