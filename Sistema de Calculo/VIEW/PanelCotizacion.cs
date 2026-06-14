using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema_de_Calculo.CONTROLADOR;
using Sistema_de_Calculo.UTILIDADES;

namespace Sistema_de_Calculo.VISTA
{
    public partial class PanelCotizacion : UserControl
    {
        private readonly DocumentoController _docCtrl = new();
        private readonly ClienteController _cliCtrl = new();
        private readonly MaterialController _matCtrl = new();

        public PanelCotizacion()
        {
            InitializeComponent();
            btnEstado.Enabled = Sesion.EsAdmin;
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
            using var dlg = new PanelNuevaCotizacion();
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
    }
}