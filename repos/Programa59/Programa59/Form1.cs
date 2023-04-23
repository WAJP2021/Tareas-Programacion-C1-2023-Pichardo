using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa59.Properties;

namespace Programa59
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMensaje.Text = (string)Settings.Default["Mensaje"];

            chkImportado.Checked = (bool)Settings.Default["Importdo"];
            chkOrganico.Checked = (bool)Settings.Default["Organico"];

            this.Size = (Size)Settings.Default["Tamano"];

            switch ((int)Settings.Default["Frutas"])
            {
                case 0:
                    rbtManzana.Checked = true;
                    rbtCiruela.Checked = false;
                    rbtPera.Checked= false;
                    break;

                case 1:
                    rbtManzana.Checked = false;
                    rbtPera.Checked = true;
                    rbtCiruela.Checked= false;

                    break;
                    case 2:
                    rbtManzana.Checked= false;
                    rbtPera.Checked = false;
                    rbtCiruela.Checked = true;
                    break;


            }
        }

        private void txtMensaje_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["Mensaje"] = txtMensaje.Text;
            Settings.Default.Save();
        }

        private void chkImportado_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkImportado_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default["Importado"] = chkImportado.Checked;
            Settings.Default.Save();
        }

        private void chkOrganico_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default["Organico"] = chkOrganico.Checked;
            Settings.Default.Save();
        }

        private void rbtManzana_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtManzana.Checked==true)
            {
                Settings.Default["Frutas"] = 0; 
                Settings.Default.Save();
            }
        }

        private void rbtPera_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["Frutas"] = 1;
            Settings.Default.Save();
        }

        private void rbtCiruela_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["Frutas"] = 2;
            Settings.Default.Save();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Settings.Default["Tamano"] = this.Size;
            Settings.Default.Save();
        }
    }
    }
    
    

