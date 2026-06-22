namespace NUMEROSALEATORIOSFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            lstNumeros.Items.Clear();
            int menor = 0;
            int mayor = 0;
            float promedio = 0;
            for (int i = 0; i < 10; i++)
            {
                int numero = rand.Next(1, 101);
                lstNumeros.Items.Add(numero);
                if (i == 0)
                {
                    menor = numero;
                    mayor = numero;
                }
                else
                {
                    if (numero < menor)
                        menor = numero;
                    if (numero > mayor)
                        mayor = numero;
                }
                promedio += numero;
            }
            promedio /= 10;
            lblMayor.Text = "Mayor: " + mayor;
            lblMenor.Text = "Menor: " + menor;
            lblPromedio.Text = "Promedio: " + promedio.ToString("F2");
        }
    }
}
