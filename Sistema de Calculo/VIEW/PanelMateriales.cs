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
    public partial class PanelMateriales : UserControl
    {
        private readonly MaterialController _ctrl = new();

        public PanelMateriales()
        {
            InitializeComponent();
            Cargar();
            btnEliminarMaterial.Visible = Sesion.EsAdmin;
        }

        // ── Carga de datos ────────────────────────────────────────────
        public void Cargar()
        {
            dataGridView1.Rows.Clear();
            foreach (var m in _ctrl.ObtenerTodos())
                dataGridView1.Rows.Add(m.Id, m.Nombre, $"{m.CostoPorM3:N0}");
        }

        // ── Botón nuevo material ──────────────────────────────────────
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using var ventana = new FormNewMaterial();

            ventana.MaterialGuardado += (s, ev) =>
            {
                Cargar();
                ventana.Close();
            };

            ventana.OperacionCancelada += (s, ev) => ventana.Close();
            ventana.ShowDialog(this);
        }

        //  ── Botón Eliminar Material ────────────────────────────────────

        private void btnEliminarMaterial_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un material.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            var confirm = MessageBox.Show(
                "¿Seguro que deseas eliminar este material? Esta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            var (ok, msg) = _ctrl.EliminarMaterial(id);
            MessageBox.Show(msg,
                ok ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok) Cargar();
        }
    }
}