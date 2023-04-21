using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa58
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirNotepad_Click(object sender, EventArgs e)
        {
            //Nos permitimos recibir eventos del notepad
            prcNotePad.EnableRaisingEvents = true;

            //Arrancamos el proceso
            prcNotePad.Start();

            lblEstado.Text = "Notepad arrancado";
        }

        private void btnCerrarNotepad_Click(object sender, EventArgs e)
        {
            prcNotePad.Kill();
        }

        private void prcNotePad_Exited(object sender, EventArgs e)
        {
            //Este evento sucede cuando se cierra el proceso
            lblEstado.Text = "Notepad Cerrado";

            notifyIcon1.ShowBalloonTip(100, "Alerta", "Notepad Cerrado", ToolTipIcon.Info);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostramos la forma
            this.Show();
        }

        private void esconderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Escondemos la forma
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
