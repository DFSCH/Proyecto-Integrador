using Sistema_de_Calculo.CONTROLADOR;
using Sistema_de_Calculo.MODELOS;
using Sistema_de_Calculo.VIEW;

namespace Sistema_de_Calculo.VISTA
{
    public partial class PanelClient : UserControl
    {
        private readonly ClientController _ctrl = new();

        public PanelClient()
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
            using (var frm = new FormNewClient())
            {
                // 1. Suscribirse al evento que avisa que el cliente se guardó
                frm.ClienteGuardado += (s, ev) =>
                {
                    Cargar();    // Recarga la tabla en tu formulario principal
                    frm.Close(); // Cierra el formulario de registro
                };

                // 2. Mostrar el formulario como un diálogo modal
                frm.ShowDialog(this);
            }
        }
    }
}