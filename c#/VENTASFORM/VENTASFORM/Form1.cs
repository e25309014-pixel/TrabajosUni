namespace VENTASFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String producto = cmbProducto.SelectedItem.ToString();
            int cantidad = Convert.ToInt32(nupCantidad.Text);
            int precio = 0;
            int subtotal = 0;
            int Total= Convert.ToInt32(lblTotal.Text);
            switch (producto)
            {
                case "Pizza":
                    precio = 10;
                    break;
                case "Hamburguesa":
                    precio = 8;
                    break;
                case "Hot Dog":
                    precio = 5;
                    break;
            }
            subtotal = cantidad * precio;
            dgvCarrito.Rows.Add(producto, cantidad, precio, subtotal);
            Total += subtotal;
            lblTotal.Text = Total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Productos del combobox
            1- Pizza -> $10
            2- Hamburguesa -> $8
            3- Hot Dog -> $5

             */
            cmbProducto.Items.Add("Pizza");
            cmbProducto.Items.Add("Hamburguesa");
            cmbProducto.Items.Add("Hot Dog");
        }
    }
}
