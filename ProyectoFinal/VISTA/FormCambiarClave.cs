using ProyectoFinal.CONTROLADOR;
using ProyectoFinal.MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormCambiarClave : Form
    {
        private readonly Usuario _usuario;
        private readonly UsuarioControlador _ctrl = new UsuarioControlador();
        private readonly bool _esAdmin;
        public FormCambiarClave(Usuario usuario, bool esAdmin = false)
        {
            InitializeComponent();
            _usuario = usuario;
            _esAdmin = esAdmin;

            // Si es admin, ocultamos el campo de contraseña anterior
            lblActual.Visible = !esAdmin;
            txtActual.Visible = !esAdmin;

            lblTitulo.Text = esAdmin
                ? $"Restablecer contraseña de: {usuario.Nombre}"
                : "Cambiar mi contraseña";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string error;

            if (_esAdmin)
            {
                // Admin no necesita contraseña anterior
                if (txtNueva.Text != txtConfirmar.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNueva.Text))
                {
                    MessageBox.Show("La contraseña no puede estar vacía.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                error = _ctrl.RestablecerContrasena(_usuario.Id, txtNueva.Text);
            }
            else
            {
                // Usuario normal: necesita verificar la anterior
                error = _ctrl.CambiarContrasena(
                    _usuario.Id,
                    txtActual.Text,
                    txtNueva.Text,
                    txtConfirmar.Text);
            }

            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("✅ Contraseña actualizada con éxito.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            txtActual.Clear();
            txtNueva.Clear();
            txtConfirmar.Clear();
        }

    }
}
