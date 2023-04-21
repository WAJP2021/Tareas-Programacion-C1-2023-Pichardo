using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Programa23
{
    public partial class Form1 : Form
    {
        private ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Center);
        private ListViewGroup carnes = new ListViewGroup("Carnes", HorizontalAlignment.Right);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creamos un imagelist
            ImageList misImagenes = new ImageList();
            misImagenes.ImageSize = new Size(100,100);


            //Obtener listado de imagenes
            string[] archivos = Directory.GetFiles("Imagenes");

            //Cargamos los archivos
            try
            {
                foreach (string archivo in archivos)
                    misImagenes.Images.Add(Image.FromFile(archivo));
            }
            catch
            {
                MessageBox.Show("Algo salio mal al cargar");
            }

         
            lstvAlimentos.SmallImageList = misImagenes;

            lstvAlimentos.Items.Add(new ListViewItem("Manzana",0, frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Pera",1, frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Sandia",2, frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Banana",3, frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Melon",4, frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Ciruela",5, frutas));

            ListViewItem miElemento = new ListViewItem("Pollo", carnes);
            lstvAlimentos.Items.Add(miElemento);

            lstvAlimentos.Items.Add ( new ListViewItem("Res", carnes));
            lstvAlimentos.Items.Add ( new ListViewItem("Pescado", carnes));
            lstvAlimentos.Items.Add ( new ListViewItem("Cerdo", carnes));
            lstvAlimentos.Items.Add ( new ListViewItem("Codorniz", carnes));

            lstvAlimentos.Groups.Add(frutas);
            lstvAlimentos.Groups.Add(carnes);



        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (rbtFrutas.Checked == true)
            {
                lstvAlimentos.Items.Add(new ListViewItem(txtElemento.Text, frutas));
            }
            if (rbtCarnes.Checked == true)
            {
                lstvAlimentos.Items.Add(new ListViewItem(txtElemento.Text, carnes));
            }
        }

        private void lstvAlimentos_MouseClick(object sender, MouseEventArgs e)
        {
            lblSelecionado.Text = lstvAlimentos.SelectedItems[0].SubItems[0].Text;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstvAlimentos.Items.Clear();
            lblSelecionado.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lstvAlimentos.SelectedItems[0].SubItems[0].Text= txtElemento.Text;
            lstvAlimentos.SelectedItems[0].ImageIndex = Convert.ToInt32(txtImagen.Text);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lstvAlimentos.Items.RemoveAt(lstvAlimentos.SelectedIndices[0]);
        }
    }
    }
    
