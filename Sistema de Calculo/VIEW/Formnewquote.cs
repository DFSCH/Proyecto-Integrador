using Sistema_de_Calculo.CONTROLADOR;
using Sistema_de_Calculo.UTILIDADES;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_de_Calculo.VIEW
{
    public partial class Formnewquote : Form
    {
        private readonly DocumentController _docCtrl = new();
        private readonly ClientController _cliCtrl = new();
        private readonly MaterialController _matCtrl = new();

        public Formnewquote()
        {
            InitializeComponent();
            CargarCombos();
            txtVolumen.TextChanged += ActualizarCosto;
            cmbMaterial.SelectedIndexChanged += ActualizarCosto;
        }

        // Llamar ANTES de ShowDialog() para precargar el volumen calculado
        public void PrecargarVolumen(double volumen)
        {
            if (volumen > 0)
                txtVolumen.Text = volumen.ToString("F2",
                    System.Globalization.CultureInfo.InvariantCulture);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem is not MODELOS.Client cliente)
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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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