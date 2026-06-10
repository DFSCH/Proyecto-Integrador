using ProyectoFinal.CONTROLADOR;
using ProyectoFinal.DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormAdministractivos : Form
    {
        private readonly AdminControlador _ctrl = new AdminControlador();

        public FormAdministractivos()
        {
            InitializeComponent();
            ConfigurarTabla();
            CargarDatos();
        }

        private void ConfigurarTabla()
        {
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.Columns["ID"].DataPropertyName = "Id";
            dgvUsuarios.Columns["NOMBRE"].DataPropertyName = "Nombre";
            dgvUsuarios.Columns["TELEFONO"].DataPropertyName = "Telefono";
            dgvUsuarios.Columns["CORREO"].DataPropertyName = "Correo";
            dgvUsuarios.Columns["CARGO"].DataPropertyName = "Cargo";
            dgvUsuarios.Columns["ESTADO"].DataPropertyName = "Estado";
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.ReadOnly = true;
        }

        private void CargarDatos() =>
            dgvUsuarios.DataSource = _ctrl.ObtenerUsuariosParaTabla();

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            MessageBox.Show("Tabla actualizada.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e) =>
            dgvUsuarios.DataSource = _ctrl.BuscarUsuarios(txtBuscar.Text);

        private void btnCambiarestado_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0) return;

            string id = dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();
            string estado = dgvUsuarios.CurrentRow.Cells["ESTADO"].Value.ToString();

            _ctrl.CambiarEstado(id, estado);
            MessageBox.Show($"Estado del usuario {id} actualizado.");
            CargarDatos();
        }

        private void btnRestablecerClave_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario de la tabla.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();
            string nombre = dgvUsuarios.CurrentRow.Cells["NOMBRE"].Value.ToString();

            // Buscamos el usuario completo para pasárselo al formulario
            var usuario = new MODELO.Usuario
            {
                Id = id,
                Nombre = nombre
            };

            // Abrimos FormCambiarContrasena en modo admin (esAdmin = true)
            // Así no pide la contraseña anterior
            var frmClave = new FormCambiarClave(usuario, esAdmin: true);
            frmClave.ShowDialog(); // Modal para que no cierre sin confirmar

            CargarDatos(); // Refrescamos la tabla por si algo cambió
        }
    }
}
