using Sistema_de_Calculo.CONTROLADOR;
using Sistema_de_Calculo.UTILIDADES;
using Sistema_de_Calculo.VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Calculo.VISTA
{
    public partial class PanelUser : UserControl
    {

        private readonly UserController _ctrl = new();

        public PanelUser()
        {
            InitializeComponent();
            CargarTabla();
        }

        // ── Carga / refresco de la tabla ─────────────────────────────
        private void CargarTabla()
        {
            dgv.Rows.Clear();
            foreach (var u in _ctrl.ObtenerTodos())
            {
                dgv.Rows.Add(
                    u.Id,
                    u.Nombre,
                    u.Correo,
                    u.Rol,
                    u.Activo ? "Activo" : "Inactivo",
                    u.FechaCreacion.ToString("dd/MM/yyyy")
                );
            }
        }

        // ── Obtener ID de la fila seleccionada ───────────────────────
        private int? ObtenerIdSeleccionado()
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un usuario de la tabla.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            var celda = dgv.CurrentRow.Cells["Id"].Value;
            if (celda == null) return null;
            return Convert.ToInt32(celda);
        }

        // ── Nuevo usuario ────────────────────────────────────────────
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using var frm = new FormNewUser();

            frm.UsuarioGuardado += (s, ev) =>
            {
                CargarTabla();
                frm.DialogResult = DialogResult.OK;
            };

            frm.ShowDialog(this);
        }

        // ── Activar / Desactivar ─────────────────────────────────────
        private void btnToggle_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado();
            if (id == null) return;

            // Protección: el admin no puede desactivarse a sí mismo
            if (Sesion.UsuarioActivo?.Id == id.Value)
            {
                MessageBox.Show("No puedes desactivar tu propia cuenta.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (ok, msg) = _ctrl.CambiarEstadoUsuario(id.Value);
            MessageBox.Show(msg, ok ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok) CargarTabla();
        }

        // ── Resetear contraseña ──────────────────────────────────────
        private void btnReset_Click(object sender, EventArgs e)
        {
            var id = ObtenerIdSeleccionado();
            if (id == null) return;

            using var frm = new Formresetpassword(_ctrl, id.Value);
            frm.ShowDialog(this);
        }
    }
}