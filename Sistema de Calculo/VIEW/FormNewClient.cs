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
    public partial class FormNewClient : Form
    {
        private readonly ClientController _ctrl = new();

        // El panel padre (PanelCliente) se suscribe a este evento
        // para recargar la tabla cuando se guarda un cliente nuevo
        public event EventHandler? ClienteGuardado;

        // Label de error — se agrega por código porque no está en el designer
        private readonly Label lblError = new();

        public FormNewClient()
        {
            InitializeComponent();

            // Posición debajo de txtCorreo (y=215+27=242) y encima de btnGuardar (y=279)
            lblError.Location = new Point(81, 248);
            lblError.Size = new Size(300, 28);
            lblError.ForeColor = Color.FromArgb(163, 45, 45);
            lblError.Font = new Font("Segoe UI", 9f);
            lblError.Visible = false;
            Controls.Add(lblError);
        }

        // ── Guardar ───────────────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            var (ok, msg) = _ctrl.RegistrarCliente(
                txtNombre.Text.Trim(),
                txtId.Text.Trim(),
                txtTelefono.Text.Trim(),
                txtCorreo.Text.Trim());

            if (!ok)
            {
                lblError.Text = msg;
                lblError.Visible = true;
                return;
            }

            LimpiarCampos();

            // Notifica al padre para que recargue la tabla
            ClienteGuardado?.Invoke(this, EventArgs.Empty);

            MessageBox.Show(
                "Cliente registrado correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ── Eliminar = limpiar formulario ─────────────────────────────
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "¿Limpiar todos los campos?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
                LimpiarCampos();
        }

        // ── Utilidad ──────────────────────────────────────────────────
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtId.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            lblError.Visible = false;
            txtNombre.Focus();
        }
    }
}