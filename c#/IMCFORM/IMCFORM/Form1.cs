using System;
using System.Drawing;
using System.Windows.Forms;
namespace IMCFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = peso / (altura * altura);
            lblResultado.Text = imc.ToString();
            if (imc < 18.5)
            {
                lblAnalisis.Text = "Bajo peso";
                lblAnalisis.ForeColor = Color.Blue;
            }
            else if (imc >= 18.5 && imc < 25)
            {
                lblAnalisis.Text = "Peso normal";
                lblAnalisis.ForeColor = Color.Green;
            }
            else if (imc >= 25 && imc < 30)
            {
                lblAnalisis.Text = "Sobrepeso";
                lblAnalisis.ForeColor = Color.Orange;
            }
            else
            {
                lblAnalisis.Text = "Obesidad";
                lblAnalisis.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
