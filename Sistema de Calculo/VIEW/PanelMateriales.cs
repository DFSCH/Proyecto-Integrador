using Sistema_de_Calculo.CONTROLADOR;
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
    }
}