namespace TABLAMULTIPLICARFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();
            int numero = Convert.ToInt32(nupNumero.Text);
            for (int i = 1; i <= 10; i++)
            {
                lstTabla.Items.Add(numero + " x " + i + " = " + (numero * i));
            }
        }
    }
}
