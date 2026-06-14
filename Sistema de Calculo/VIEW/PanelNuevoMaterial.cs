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
    public partial class PanelNuevoMaterial : UserControl
    {
        // Instancia del controlador para interactuar con la base de datos o lista
        private readonly MaterialController _ctrl = new();

        // Eventos para comunicar el resultado al formulario contenedor
        public event EventHandler? MaterialGuardado;
        public event EventHandler? OperacionCancelada;

        public PanelNuevoMaterial()
        {
            InitializeComponent();
        }

        // ── Botón Guardar ─────────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            // 1. Validar que el nombre no esté vacío
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingresa el tipo de material.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            // 2. Validar que el costo sea un número válido (soporta '.' y ',')
            if (!decimal.TryParse(
                    txtCosto.Text.Replace(',', '.'),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out decimal costo))
            {
                MessageBox.Show("Ingresa un costo numérico válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCosto.Focus();
                return;
            }

            // 3. Enviar datos al controlador
            var (ok, msg) = _ctrl.RegistrarMaterial(nombre, costo);

            if (!ok)
            {
                // Si el controlador deniega el registro (ej. nombre duplicado)
                MessageBox.Show(msg, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Si todo sale bien, notificar al panel/formulario padre y limpiar
            MessageBox.Show("Material guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MaterialGuardado?.Invoke(this, EventArgs.Empty);
            LimpiarCampos();
        }

        // ── Botón Eliminar / Cancelar ─────────────────────────────────
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            // Avisa al formulario padre por si desea cerrar la ventana al cancelar
            OperacionCancelada?.Invoke(this, EventArgs.Empty);
        }

        // ── Métodos Auxiliares ─────────────────────────────────────────
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCosto.Clear();
            txtNombre.Focus();
        }
    }
}
