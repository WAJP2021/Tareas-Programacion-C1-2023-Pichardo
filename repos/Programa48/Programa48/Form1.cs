using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Xml.Linq;

namespace Programa48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Obtenemos el objeto graphics
            Graphics g = e.Graphics;

            //Creamos un color
            Color miColor = Color.FromArgb(120, 150, 30);

            //Creamos la brocha solida
            SolidBrush miBrocha = new SolidBrush(miColor);

            g.FillRectangle(miBrocha, new Rectangle(10, 10, 150, 50));

            //Seleccionamos el entramado
            HatchStyle entramado = HatchStyle.BackwardDiagonal;

            //Creamos una brocha con entramado
            miColor = Color.FromArgb(200, 0, 30);
            HatchBrush brochaEnt = new HatchBrush(entramado, miColor);

            g.FillRectangle(brochaEnt, new Rectangle(10,70,150,50));

            //Creamos una brocha con entramado a dos colores
            miColor = Color.FromArgb(200, 255, 150);
            Color miColor2 = Color.FromArgb(0, 200, 130);
            HatchBrush brochaEnt2 = new HatchBrush(entramado, miColor, miColor2);

            g.FillRectangle(brochaEnt2, new Rectangle(10, 130, 150, 50));

            //Creamos una brocha con imagen
            Image imagen = new Bitmap("Brush.png");
            Brush brochaIm = new TextureBrush(imagen);

            g.FillRectangle(brochaIm, new Rectangle(10,190,150,50));

            //Creamos una brocha con gradiente
            Point inicio = new Point(10, 10);
            Point final = new Point(50, 25);

            LinearGradientBrush brochaG= new LinearGradientBrush(inicio, final, miColor,miColor2);
            g.FillRectangle(brochaG, new Rectangle(10, 250, 150, 50));

            //Con Seleccion del tipo gradiente 
            LinearGradientMode gradiente = LinearGradientMode.Horizontal;

            LinearGradientBrush brochaG2 = new LinearGradientBrush(new Rectangle(0, 0, 100, 100), miColor, miColor2, gradiente);
            g.FillRectangle(brochaG2, new Rectangle(10,310,150,50));


        }
    }
}
