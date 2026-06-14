using Sistema_de_Calculo.CONTROLADOR;
using Sistema_de_Calculo.UTILIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Calculo.VISTA
{
    public partial class PanelFacturas : UserControl
    {
        private readonly DocumentoController _docCtrl = new();
        private readonly ClienteController _cliCtrl = new();
        private readonly MaterialController _matCtrl = new();

        public PanelFacturas()
        {
            InitializeComponent();
            // Conectar checkboxes con datepickers
            chkDesde.CheckedChanged += (s, e) => dtpDesde.Enabled = chkDesde.Checked;
            chkHasta.CheckedChanged += (s, e) => dtpHasta.Enabled = chkHasta.Checked;
            // Selección inicial del combo
            cmbFiltroEstado.SelectedIndex = 0;
            btnEstado.Enabled = Sesion.EsAdmin;
            Cargar();
        }

        private void Cargar()
        {
            dgv.Rows.Clear();

            string? estado = cmbFiltroEstado.SelectedItem?.ToString() == "Todos"
                ? null : cmbFiltroEstado.SelectedItem?.ToString();
            DateTime? desde = chkDesde.Checked ? dtpDesde.Value : null;
            DateTime? hasta = chkHasta.Checked ? dtpHasta.Value : null;

            var facs = _docCtrl.FiltrarFacturas(txtFiltroCliente.Text, estado, desde, hasta);
            var clientes = _cliCtrl.ObtenerTodos();
            var cots = _docCtrl.ObtenerCotizaciones();

            foreach (var f in facs)
            {
                var cl = clientes.FirstOrDefault(c => c.Id == f.ClienteId);
                var cot = cots.FirstOrDefault(c => c.Id == f.CotizacionId);
                decimal total = cot != null ? cot.CostoTotal * 1.19m : 0m;

                dgv.Rows.Add(
                    f.Id,
                    f.Numero,
                    cot?.Numero ?? "—",
                    cl?.Nombre ?? "N/A",
                    $"{total:N0} COP",
                    f.Estado,
                    f.Fecha.ToString("dd/MM/yyyy")
                );
            }
        }

        private int? IdSeleccionado()
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una factura.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return (int)dgv.CurrentRow.Cells["Id"].Value!;
        }

        private void btnFiltrar_Click(object sender, EventArgs e) => Cargar();

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltroCliente.Clear();
            cmbFiltroEstado.SelectedIndex = 0;
            chkDesde.Checked = false;
            chkHasta.Checked = false;
            Cargar();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            var id = IdSeleccionado();
            if (id == null) return;

            var (ok, msg) = _docCtrl.CambiarEstadoFactura(id.Value);
            MessageBox.Show(msg,
                ok ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok) Cargar();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            var id = IdSeleccionado();
            if (id == null) return;

            var fac = _docCtrl.ObtenerFacturas().FirstOrDefault(f => f.Id == id.Value);
            if (fac == null) return;

            var cot = _docCtrl.ObtenerCotizacionPorId(fac.CotizacionId);
            var cl = _cliCtrl.ObtenerPorId(fac.ClienteId);
            var mat = cot != null ? _matCtrl.ObtenerPorId(cot.MaterialId) : null;

            Impresora.ImprimirFactura(fac, cot, cl, mat);
        }
    }
}
