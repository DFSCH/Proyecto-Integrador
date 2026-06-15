using Sistema_de_Calculo.CONTROLADOR;
using System;
using System.Windows.Forms;

namespace Sistema_de_Calculo.VIEW
{
    public partial class Formresetpassword : Form
    {
        private readonly UserController _ctrl;
        private readonly int _idUsuario;

        // Constructor vacío — para el diseñador de VS
        public Formresetpassword()
        {
            InitializeComponent();
        }

        // Constructor real — llamado desde donde abras el form
        public Formresetpassword(UserController ctrl, int idUsuario)
        {
            InitializeComponent();
            _ctrl = ctrl;
            _idUsuario = idUsuario;
            lblError.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var (ok, msg) = _ctrl.CambiarContrasena(_idUsuario, txtNuevaContra.Text);

            if (!ok)
            {
                lblError.Text = msg;
                lblError.Visible = true;
                return;
            }

            MessageBox.Show("Contraseña actualizada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // En un Form se usa DialogResult en vez de un evento
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void btnVerClave_Click_1(object sender, EventArgs e)
        {
            txtNuevaContra.UseSystemPasswordChar = !txtNuevaContra.UseSystemPasswordChar;
            btnVerClave.Text = txtNuevaContra.UseSystemPasswordChar ? "🙈" : "👁";
        }
    }
}