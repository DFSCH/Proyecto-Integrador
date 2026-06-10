using ProyectoFinal.DATOS;
using ProyectoFinal.MODELO;
using ProyectoFinal.CONTROLADOR;
using BCrypt.Net;


namespace ProyectoFinal
{
    public partial class FormLogin : Form
    {
        private readonly Autenticador _auth = new Autenticador();

        public FormLogin()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !txtContraseña.UseSystemPasswordChar;
            btnVisible.Text = txtContraseña.UseSystemPasswordChar ? "👁️" : "🔍";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var usuario = _auth.Login(txtID.Text.Trim(), txtContraseña.Text.Trim());

            if (usuario == null)
            {
                MessageBox.Show("ID o Contraseña incorrectos.", "Error de Autenticación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;
            }

            if (!usuario.Estado)
            {
                MessageBox.Show("Su usuario está INACTIVO. Contacte al administrador.",
                    "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            MessageBox.Show($"Bienvenido: {usuario.Nombre}\nCargo: {usuario.Cargo}", "Inicio Exitoso");
            AbrirFormularioSegunRol(usuario);
        }

        private void AbrirFormularioSegunRol(MODELO.Usuario user)
        {
            Form siguiente = user.Cargo == "Administrador"
                ? new FormAdministractivos()
                : (Form)new FormUsuario(user);

            siguiente.FormClosed += (s, args) => Application.Exit();
            siguiente.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) =>
            new FormRegistrar().Show();

        private void lblOlvidoPass_Click(object sender, EventArgs e) =>
            MessageBox.Show("Hable con un administrador para recuperar su acceso.",
                "Recuperación", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}