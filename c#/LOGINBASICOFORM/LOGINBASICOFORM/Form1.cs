namespace LOGINBASICOFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String contrasena = txtContraseña.Text;
            if (usuario == "admin" && contrasena == "1234")
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            lblSesion.Text = "Usuario: " + usuario;
        }
    }
}
