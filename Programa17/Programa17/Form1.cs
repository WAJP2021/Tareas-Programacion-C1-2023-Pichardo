using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa17
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Adicionamos nuev renglon
            int n = dtgvProductos.Rows.Add();

            //Colocamos la informacion
            dtgvProductos.Rows[n].Cells[0].Value = txtCodigo.Text;
            dtgvProductos.Rows[n].Cells[1].Value = txtNombre.Text;
            dtgvProductos.Rows[n].Cells[2].Value = txtPrecio.Text;

            //Limpiamos los txt
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";

        }

        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             n = e.RowIndex;

            if (n!= -1)
            {
                lblInformacion.Text= (string) dtgvProductos.Rows[n].Cells[1].Value;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n!= -1)
            {
                dtgvProductos.Rows.RemoveAt(n);
            }    
        }
    }
}
