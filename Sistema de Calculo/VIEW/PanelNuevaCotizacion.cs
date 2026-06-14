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
    public partial class PanelNuevaCotizacion : UserControl
    {
        private readonly DocumentoController _docCtrl = new();
        private readonly ClienteController _cliCtrl = new();
        private readonly MaterialController _matCtrl = new();


        // Para usarlo como diálogo desde PanelCotizacion
        private Form? _ventana;
        public void PrecargarVolumen(double volumen)
        {
            if (volumen > 0)
                txtVolumen.Text = volumen.ToString("F2",
                    System.Globalization.CultureInfo.InvariantCulture);
        }

        public PanelNuevaCotizacion()
        {
            InitializeComponent();
            CargarCombos();
            txtVolumen.TextChanged += ActualizarCosto;
            cmbMaterial.SelectedIndexChanged += ActualizarCosto;
        }

        private void CargarCombos()
        {
            cmbCliente.DisplayMember = "Nombre";
            cmbMaterial.DisplayMember = "Nombre";

            foreach (var c in _cliCtrl.ObtenerTodos())
                cmbCliente.Items.Add(c);

            foreach (var m in _matCtrl.ObtenerTodos())
                cmbMaterial.Items.Add(m);
        }

        // Método para abrirlo como diálogo modal
        public new DialogResult ShowDialog()
        {
            _ventana = new Form
            {
                Text = "Nueva Cotización",
                Size = new Size(410, 400),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };
            Dock = DockStyle.Fill;
            _ventana.Controls.Add(this);
            return _ventana.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem is not MODELOS.Cliente cliente)
            { MessageBox.Show("Selecciona un cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (cmbMaterial.SelectedItem is not MODELOS.Material material)
            { MessageBox.Show("Selecciona un material.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!double.TryParse(txtVolumen.Text.Replace(',', '.'),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out double vol) || vol <= 0)
            { MessageBox.Show("Ingresa un volumen válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            decimal costo = (decimal)vol * material.CostoPorM3;
            var (ok, msg) = _docCtrl.CrearCotizacion(cliente.Id, material.Id, vol, costo, "");

            MessageBox.Show(msg,
                ok ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok)
            {
                if (_ventana != null) _ventana.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_ventana != null) _ventana.DialogResult = DialogResult.Cancel;
        }


        private void ActualizarCosto(object? s, EventArgs e)
        {
            if (cmbMaterial.SelectedItem is MODELOS.Material mat &&
                double.TryParse(txtVolumen.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out double vol))
            {
                decimal costo = (decimal)vol * mat.CostoPorM3;
                lblCostoEstimado.Text = $"Costo estimado: {costo:C0}";
            }
            else
            {
                lblCostoEstimado.Text = "";
            }
        }
    }
}