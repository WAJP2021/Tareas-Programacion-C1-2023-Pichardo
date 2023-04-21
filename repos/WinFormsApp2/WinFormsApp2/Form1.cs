namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Hola a todos!";
        }
    }
}