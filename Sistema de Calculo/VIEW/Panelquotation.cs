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
    public partial class Panelquotation : UserControl
    {
        private readonly DocumentController _docCtrl = new();
        private readonly ClientController _cliCtrl = new();
        private readonly MaterialController _matCtrl = new();

        public Panelquotation()
        {
            InitializeComponent();
            btnEstado.Visible = Sesion.EsAdmin;    // antes era .Enabled → ahora desaparece para usuario
            btnFactura.Enabled = Sesion.EsAdmin;

            Cargar();
        }

        public void Cargar()
        {
            dgv.Rows.Clear();
            var cots = _docCtrl.ObtenerCotizaciones();
            var clientes = _cliCtrl.ObtenerTodos();
            var mats = _matCtrl.ObtenerTodos();

            foreach (var c in cots)
            {
                var cl = clientes.FirstOrDefault(x => x.Id == c.ClienteId);
                var mat = mats.FirstOrDefault(x => x.Id == c.MaterialId);
                dgv.Rows.Add(
                    c.Id,
                    c.Numero,
                    cl?.Nombre ?? "N/A",
                    mat?.Nombre ?? "N/A",
                    $"{c.Volumen:F2}",
                    $"{c.CostoTotal:N0} COP",
                    c.Estado,
                    c.Fecha.ToString("dd/MM/yyyy")
                );
            }
        }

        private int? IdSeleccionado()
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una cotización.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return (int)dgv.CurrentRow.Cells["Id"].Value!;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            using var dlg = new Formnewquote();
            if (dlg.ShowDialog() == DialogResult.OK)
                Cargar();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            var id = IdSeleccionado();
            if (id == null) return;

            var (ok, msg) = _docCtrl.CambiarEstadoCotizacion(id.Value);
            MessageBox.Show(msg,
                ok ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok) Cargar();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            var id = IdSeleccionado();
            if (id == null) return;

            var cot = _docCtrl.ObtenerCotizacionPorId(id.Value);
            if (cot == null) return;

            var (ok, msg) = _docCtrl.ConvertirAFactura(cot.Id, cot.ClienteId);
            MessageBox.Show(msg,
                ok ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            var id = IdSeleccionado();
            if (id == null) return;

            var cot = _docCtrl.ObtenerCotizacionPorId(id.Value);
            if (cot == null) return;

            Impresora.ImprimirCotizacion(
                cot,
                _cliCtrl.ObtenerPorId(cot.ClienteId),
                _matCtrl.ObtenerPorId(cot.MaterialId));
        }

        private void btnEliminarCot_Click(object sender, EventArgs e)
        {
            var id = IdSeleccionado();
            if (id == null) return;

            var confirm = MessageBox.Show(
                "¿Seguro que deseas eliminar esta cotización? Esta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            var (ok, msg) = _docCtrl.EliminarCotizacion(id.Value);
            MessageBox.Show(msg,
                ok ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok) Cargar();
        }
    }
}