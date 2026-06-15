using Sistema_de_Calculo.CONTROLADOR;
using Sistema_de_Calculo.UTILIDADES;
using Sistema_de_Calculo.VIEW;
using System.ComponentModel;

namespace Sistema_de_Calculo.VISTA
{
    public partial class FormMenu : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double VolumenCompartido { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CoordsCompartidas { get; set; } = "";

        public FormMenu()
        {
            InitializeComponent();
            lblUsuario.Text = Sesion.UsuarioActivo?.Nombre ?? "(usuario)";
            lblRol.Text = Sesion.EsAdmin ? "Administrador" : "Usuario";
            // Solo admin ve el botón de usuarios
            btnUsuario.Visible = Sesion.EsAdmin;
            // Cargar panel inicial
            // FIX #2: la clase se llama PanelVolumen, no PanelCalculoVolumen
            var panelVolInicial = new PanelVolume();
            panelVolInicial.VolumenListo += (s, volumen) =>
            {
                VolumenCompartido = volumen;
                using var frm = new Formnewquote();
                frm.PrecargarVolumen(volumen);
                frm.ShowDialog(this);
            };
            Navegar(panelVolInicial);
        }

        // ── Navegación ───────────────────────────────────────────────
        private void Navegar(UserControl panel)
        {
            pnlContent.SuspendLayout();
            pnlContent.Controls.Clear();
            panel.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(panel);
            pnlContent.ResumeLayout();
        }

        private void SetNavActivo(Button activo)
        {
            foreach (var btn in new[] { btnCalcularVolumen, btnCotizacion, btnFactura,
                                        btnCliente, btnMateriales, btnUsuario })
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(100, 100, 100);
                btn.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }
            activo.BackColor = Color.FromArgb(235, 242, 252);
            activo.ForeColor = Color.FromArgb(24, 95, 165);
            activo.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        }

        // ── Botones de navegación ────────────────────────────────────
       
        private void btnCalcularVolumen_Click(object sender, EventArgs e)
        {
            SetNavActivo(btnCalcularVolumen);

            var panelVol = new PanelVolume();

            panelVol.VolumenListo += (s, volumen) =>
            {
                VolumenCompartido = volumen;
                using var frm = new Formnewquote();
                frm.PrecargarVolumen(volumen);
                frm.ShowDialog(this);
            };

            Navegar(panelVol);
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            SetNavActivo(btnCotizacion);
            Navegar(new Panelquotation());
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            SetNavActivo(btnFactura);
            Navegar(new PanelFacturas());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            SetNavActivo(btnCliente);
            // FIX #9: la clase se llama PanelCliente (ver archivo corregido), no PanelNuevoCliente
            Navegar(new PanelClient());
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            SetNavActivo(btnMateriales);
            Navegar(new PanelMateriales());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            SetNavActivo(btnUsuario);
            // FIX #10: la clase se llama PanelUsuario, no PanelUsuarios
            Navegar(new PanelUser());
        }

        // ── Pie del sidebar ──────────────────────────────────────────
        private void btnCambiarPw_Click(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActivo == null) return;

            var ctrl = new UserController();
            int uid = Sesion.UsuarioActivo.Id;

            using var frm = new Formresetpassword(ctrl, uid);
            frm.ShowDialog(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Sesion.Cerrar();
            new FormLogin().Show();
            Close();
        }
    }
}