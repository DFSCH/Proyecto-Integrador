using Sistema_de_Calculo.CONTROLADOR;
using Sistema_de_Calculo.MODELOS;

namespace Sistema_de_Calculo.VISTA
{
    public partial class PanelCliente : UserControl
    {
        private readonly ClienteController _ctrl = new();

        public PanelCliente()
        {
            InitializeComponent();
            Cargar();

            // Enter en el buscador dispara búsqueda
            txtBuscar.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) Cargar(txtBuscar.Text);
            };
        }

        // ── Carga / recarga de la tabla ───────────────────────────────
        public void Cargar(string? termino = null)
        {
            dataGridView1.Rows.Clear();

            var lista = string.IsNullOrWhiteSpace(termino)
                ? _ctrl.ObtenerTodos()
                : _ctrl.Buscar(termino);

            foreach (var c in lista)
                dataGridView1.Rows.Add(
                    c.Id,
                    c.Nombre,
                    c.Identificacion,
                    c.Telefono,
                    c.Correo,
                    c.FechaRegistro.ToString("dd/MM/yyyy"));
        }

        // ── Eventos de botones ────────────────────────────────────────
        private void btnBuscar_Click(object sender, EventArgs e)
            => Cargar(txtBuscar.Text);

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var pnl = new PanelNuevoCliente();
            var frm = new Form
            {
                Text = "Registrar cliente",
                Size = new Size(460, 430),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            pnl.Dock = DockStyle.Fill;
            pnl.ClienteGuardado += (s, ev) =>
            {
                Cargar();    // recarga la tabla
                frm.Close(); // cierra el formulario
            };

            frm.Controls.Add(pnl);
            frm.ShowDialog(this);
        }
    }
}