using BCrypt.Net; 
using ProyectoFinal.MODELO;
using ProyectoFinal.CONTROLADOR;

namespace ProyectoFinal
{
    public partial class FormRegistrar : Form
    {
        private readonly AdminControlador _ctrl = new AdminControlador();

        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string error = _ctrl.RegistrarUsuario(
                txtID.Text, txtNombre.Text, txtTelefono.Text,
                txtCorreo.Text, cmbCargo.Text,
                txtContraseña.Text, txtConfirmarContraseña.Text);

            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Usuario registrado con éxito.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (MessageBox.Show("¿Registrar otro usuario?", "Confirmación",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                LimpiarCampos();
            else
                this.Close();
        }

        private void LimpiarCampos()
        {
            txtID.Clear(); txtNombre.Clear(); txtTelefono.Clear();
            txtCorreo.Clear(); txtContraseña.Clear(); txtConfirmarContraseña.Clear();
            if (cmbCargo?.Items.Count > 0) cmbCargo.SelectedIndex = -1;
            txtID.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();
    }
}