using Sistema_de_Calculo.CONTROLADOR;
using Sistema_de_Calculo.UTILIDADES;

namespace Sistema_de_Calculo
{
    public partial class FormLogin : Form
    {
        private readonly UsuarioController _ctrl = new();

        public FormLogin()
        {
            InitializeComponent();
            // Seed: crea admin y materiales por defecto si no existen
            _ctrl.InicializarAdmin();
            new MaterialController().InicializarMateriales();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            string correo = txtCorreo.Text.Trim();
            string password = txtPw.Text;

            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Completa todos los campos.";
                lblError.Visible = true;
                return;
            }

            var (ok, usuario, msg) = _ctrl.IniciarSesion(correo, password);

            if (!ok)
            {
                lblError.Text = msg;
                lblError.Visible = true;
                return;
            }

            Sesion.Iniciar(usuario!);
            new VISTA.FormMenu().Show();
            Hide();
        }

        private void btnVerClave_Click(object sender, EventArgs e)
        {
            txtPw.UseSystemPasswordChar = !txtPw.UseSystemPasswordChar;
            btnVerClave.Text = txtPw.UseSystemPasswordChar ? "👁" : "🙈";
        }

        
    }
}