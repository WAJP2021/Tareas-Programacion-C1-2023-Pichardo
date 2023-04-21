using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtContenidos_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void txtContenidos_DragDrop(object sender, DragEventArgs e)
        {
            //Obtenemos el arreglo con los archivos
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            string linea = "";

            lblArchivo.Text = archivos[0];

            //Leemos el archivo
            StreamReader lector = File.OpenText(archivos[0]);

            while((linea= lector.ReadLine()) != null)
            {
                txtContenidos.Text = linea + "\r\n";
            }
            lector.Close();
        }
    }
}
