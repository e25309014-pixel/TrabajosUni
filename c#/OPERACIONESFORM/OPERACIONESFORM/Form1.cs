namespace OPERACIONESFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNum1.Text);
            double numero2 = Convert.ToDouble(txtNum2.Text);
            string operacion = cmbOperaciones.SelectedItem.ToString();
            double resultado = 0;
            switch (operacion)
            {
                case "Suma":
                    resultado = numero1 + numero2;
                    break;
                case "Resta":
                    resultado = numero1 - numero2;
                    break;
                case "Multiplicación":
                    resultado = numero1 * numero2;
                    break;
                case "División":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero.");
                        return;
                    }
                    break;
            }
            lblResultado.Text = resultado.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperaciones.Items.Add("Suma");
            cmbOperaciones.Items.Add("Resta");
            cmbOperaciones.Items.Add("Multiplicación");
            cmbOperaciones.Items.Add("División");
        }
    }
}
