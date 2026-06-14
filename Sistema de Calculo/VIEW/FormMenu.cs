using Sistema_de_Calculo.CONTROLADOR;
using Sistema_de_Calculo.UTILIDADES;
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
            var panelVolInicial = new PanelVolumen();
            panelVolInicial.VolumenListo += (s, volumen) =>
            {
                VolumenCompartido = volumen;
                var panelCot = new PanelNuevaCotizacion();
                panelCot.PrecargarVolumen(volumen);     // ← método, igual que en btnCalcularVolumen_Click
                SetNavActivo(btnCotizacion);
                Navegar(panelCot);
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

            var panelVol = new PanelVolumen();

           
            panelVol.VolumenListo += (s, volumen) =>
            {
                VolumenCompartido = volumen;   // guarda en FormMenu para uso global

                // Navega a cotizaciones con el volumen precargado
                
                var panelCot = new PanelNuevaCotizacion();
                panelCot.PrecargarVolumen(volumen);   // ← método en vez de propiedad
                SetNavActivo(btnCotizacion);
                Navegar(panelCot);
              
            };

            Navegar(panelVol);
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            SetNavActivo(btnCotizacion);
            Navegar(new PanelCotizacion());
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
            Navegar(new PanelCliente());
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            SetNavActivo(btnMateriales);
            Navegar(new PanelMateriales_Usuario());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            SetNavActivo(btnUsuario);
            // FIX #10: la clase se llama PanelUsuario, no PanelUsuarios
            Navegar(new PanelUsuario());
        }

        // ── Pie del sidebar ──────────────────────────────────────────
        private void btnCambiarPw_Click(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActivo == null) return;

            // FIX #8: 
            // diálogo inline idéntico al que usa PanelUsuario para resetear pw.
            var ctrl = new UsuarioController();
            int uid = Sesion.UsuarioActivo.Id;

            using var frm = new Form
            {
                Text = "Cambiar contraseña",
                Size = new Size(380, 230),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                Font = new Font("Segoe UI", 9.5f)
            };

            var lblNueva = new Label { Text = "Nueva contraseña:", AutoSize = true, Location = new Point(16, 16) };
            var txtNueva = new TextBox
            {
                Location = new Point(16, 36),
                Size = new Size(334, 26),
                UseSystemPasswordChar = true,
                BorderStyle = BorderStyle.FixedSingle
            };
            var lblHint = new Label
            {
                Text = "Mín. 8 caracteres, mayúscula, número y carácter especial.",
                AutoSize = true,
                Location = new Point(16, 68),
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 8f)
            };
            var lblErr = new Label
            {
                Location = new Point(16, 92),
                Size = new Size(334, 20),
                ForeColor = Color.FromArgb(163, 45, 45),
                Visible = false
            };
            var btnOk = new Button
            {
                Text = "Guardar",
                Location = new Point(130, 130),
                Size = new Size(90, 28),
                BackColor = Color.FromArgb(24, 95, 165),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnOk.FlatAppearance.BorderSize = 0;
            var btnCancel = new Button
            {
                Text = "Cancelar",
                Location = new Point(230, 130),
                Size = new Size(90, 28),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            btnOk.Click += (s, ev) => {
                var (ok, msg) = ctrl.CambiarContrasena(uid, txtNueva.Text);
                if (!ok) { lblErr.Text = msg; lblErr.Visible = true; return; }
                MessageBox.Show("Contraseña actualizada.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm.Close();
            };
            btnCancel.Click += (s, ev) => frm.Close();

            frm.Controls.AddRange(new Control[] { lblNueva, txtNueva, lblHint, lblErr, btnOk, btnCancel });
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