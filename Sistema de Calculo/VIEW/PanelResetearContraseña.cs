using Sistema_de_Calculo.CONTROLADOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Calculo.VISTA
{
    public partial class PanelResetearContraseña : UserControl
    {  // Evento que avisa a PanelUsuario cuando se guardó con éxito
        public event EventHandler ContraseñaActualizada;

        private readonly UsuarioController _ctrl;
        private readonly int _idUsuario;

        // Constructor vacío — para el diseñador de VS
        public PanelResetearContraseña()
        {
            InitializeComponent();
        }

        // Constructor real — llamado desde PanelUsuario
        public PanelResetearContraseña(UsuarioController ctrl, int idUsuario)
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

            ContraseñaActualizada?.Invoke(this, EventArgs.Empty);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void btnVerClave_Click(object sender, EventArgs e)
        {
            txtNuevaContra.UseSystemPasswordChar = !txtNuevaContra.UseSystemPasswordChar;
            btnVerClave.Text = txtNuevaContra.UseSystemPasswordChar ? "👁" : "🙈";
        }
    }
}
