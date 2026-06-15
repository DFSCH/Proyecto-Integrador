using Sistema_de_Calculo.CONTROLADOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Calculo.VIEW
{
    public partial class FormNewUser : Form
    {
        private readonly UserController _ctrl = new();
        // Evento para notificar al PanelUsuario que recargue la tabla
        public event EventHandler? UsuarioGuardado;
        public FormNewUser()
        {

            InitializeComponent();

            // Limpiar y preparar combo de roles
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.SelectedIndex = 0;

            // Ocultar contraseña
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string password = txtContraseña.Text;
            string rol = cmbCargo.SelectedItem?.ToString()?.ToLower() ?? "usuario";

            // Validaciones básicas en vista
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre es requerido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("El correo es requerido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("La contraseña es requerida.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return;
            }

            // Delegar al controlador
            var (ok, msg) = _ctrl.RegistrarUsuario(nombre, correo, password, rol);

            if (!ok)
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos
            txtNombre.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            cmbCargo.SelectedIndex = 0;

            // Notificar al panel padre para que recargue la tabla
            UsuarioGuardado?.Invoke(this, EventArgs.Empty);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar campos al cancelar
            txtNombre.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            cmbCargo.SelectedIndex = 0;
        }

        private void btnVerClave_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !txtContraseña.UseSystemPasswordChar;
            btnVerClave.Text = txtContraseña.UseSystemPasswordChar ? "👁" : "🙈";
        }
    }
}
