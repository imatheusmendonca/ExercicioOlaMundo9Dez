namespace PROJETO09DEZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            primeiroTexto.Visible = false;
        }

        private void botao1_Click(object sender, EventArgs e)
        {
           primeiroTexto.Visible = true;
            primeiroTexto.Text = "Olá Mundo!";
        }
    }
}