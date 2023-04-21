namespace Programa01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = "Hola a todos!";
        }
    }
}