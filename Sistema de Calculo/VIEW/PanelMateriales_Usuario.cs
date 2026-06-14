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
    public partial class PanelMateriales_Usuario : UserControl
    {
        private readonly MaterialController _ctrl = new();

        public PanelMateriales_Usuario()
        {
            InitializeComponent();
            Cargar();
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
            var ctrl = new PanelNuevoMaterial();
            ctrl.Dock = DockStyle.Fill;

            var ventana = new Form
            {
                Text = "Nuevo Material",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = ctrl.Size      // ajusta el tamaño al del control
            };
            ventana.Controls.Add(ctrl);

            // Cierra la ventana cuando se guarda o se cancela
            ctrl.MaterialGuardado += (s, ev) => { Cargar(); ventana.Close(); };
            ctrl.OperacionCancelada += (s, ev) => ventana.Close();

            ventana.ShowDialog(this);
        }
    }
}