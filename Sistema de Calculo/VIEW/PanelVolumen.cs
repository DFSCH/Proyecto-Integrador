using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Windows.Forms;
using System.Windows.Forms.Integration;   // ElementHost
using HelixToolkit.Wpf;                   // HelixViewport3D, SphereVisual3D, DefaultLights
using HelixToolkit.Geometry;              // MeshBuilder
using Sistema_de_Calculo.MODELOS;         // PuntoTerreno
using Sistema_de_Calculo.UTILIDADES;      // CalculadoraDeVolumen

namespace Sistema_de_Calculo.VISTA
{
    public partial class PanelVolumen : UserControl
    {
        // ── Helix WPF embebido en card4 via ElementHost ──────────────
        private readonly ElementHost _helixHost = new();
        private readonly HelixViewport3D _viewport = new();

        // ── Resultado compartible con el formulario padre ─────────────
        public double VolumenObtenido { get; private set; }

        /// <summary>
        /// Se dispara cuando el usuario pulsa "Usar en cotización →".
        /// El padre puede suscribirse para recibir el volumen calculado.
        /// </summary>
        
        public event EventHandler<double>? VolumenListo;

        // ── Constructor ───────────────────────────────────────────────
        public PanelVolumen()
        {
            InitializeComponent();
            InicializarHelixEnCard4();
            cmbMetodo.SelectedIndex = 0;
            CargarPuntosPrueba();
        }

        // ─────────────────────────────────────────────────────────────
        // HELIX: montar el viewport WPF dentro del Panel card4
        // ─────────────────────────────────────────────────────────────
        private void InicializarHelixEnCard4()
        {
            _viewport.ShowCoordinateSystem = true;
            _viewport.ShowFrameRate = false;
            _viewport.ZoomExtentsWhenLoaded = true;
            _viewport.Background = System.Windows.Media.Brushes.Black;

            _helixHost.Location = new System.Drawing.Point(8, 36);
            _helixHost.Size = new System.Drawing.Size(card4.Width - 16, card4.Height - 44);
            _helixHost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                                | AnchorStyles.Left | AnchorStyles.Right;
            _helixHost.Child = _viewport;

            card4.Controls.Add(_helixHost);
        }

        // ─────────────────────────────────────────────────────────────
        // PUNTOS DE PRUEBA (precarga al abrir)
        // ─────────────────────────────────────────────────────────────
        private void CargarPuntosPrueba()
        {
            var pts = new[]
            {
                (0.0, 0.0, 2.0), (10.0, 0.0, 3.0), (10.0, 8.0, 4.0),
                (0.0, 8.0, 2.5), (5.0,  4.0, 5.0)
            };
            foreach (var (x, y, z) in pts)
                dgvPuntos.Rows.Add(x, y, z);
        }

        // ─────────────────────────────────────────────────────────────
        // LEER PUNTOS DEL GRID
        // ─────────────────────────────────────────────────────────────
        private List<PuntoTerreno> ObtenerPuntos()
        {
            var lista = new List<PuntoTerreno>();
            foreach (DataGridViewRow row in dgvPuntos.Rows)
            {
                if (row.IsNewRow) continue;
                if (TryLeerCelda(row.Cells["colX"].Value, out double x) &&
                    TryLeerCelda(row.Cells["colY"].Value, out double y) &&
                    TryLeerCelda(row.Cells["colZ"].Value, out double z))
                {
                    lista.Add(new PuntoTerreno(x, y, z));
                }
            }
            return lista;
        }

        private static bool TryLeerCelda(object? valor, out double resultado)
        {
            resultado = 0;
            if (valor == null) return false;

            // Si ya es número (que es el caso al usar Rows.Add con doubles), úsalo tal cual
            if (valor is double d) { resultado = d; return true; }
            if (valor is float f) { resultado = f; return true; }
            if (valor is int n) { resultado = n; return true; }

            // Si viene como texto, normaliza la coma a punto y parsea invariante
            string s = valor.ToString()!.Trim().Replace(',', '.');
            return double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out resultado);
        }

        // ─────────────────────────────────────────────────────────────
        // BOTÓN: + Agregar
        // ─────────────────────────────────────────────────────────────
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!TryLeerCelda(txtX.Text, out double x) ||
            !TryLeerCelda(txtY.Text, out double y) ||
            !TryLeerCelda(txtZ.Text, out double z))
            {
                MessageBox.Show("Ingresa valores numéricos válidos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvPuntos.Rows.Add(x, y, z);
            txtX.Clear(); txtY.Clear(); txtZ.Clear();
            txtX.Focus();
        }

        // ─────────────────────────────────────────────────────────────
        // BOTÓN: Eliminar seleccionado
        // ─────────────────────────────────────────────────────────────
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPuntos.CurrentRow != null && !dgvPuntos.CurrentRow.IsNewRow)
                dgvPuntos.Rows.Remove(dgvPuntos.CurrentRow);
        }

        // ─────────────────────────────────────────────────────────────
        // BOTÓN: Calcular volumen
        // ─────────────────────────────────────────────────────────────
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            var pts = ObtenerPuntos();
            if (pts.Count < 3)
            {
                MessageBox.Show("Necesitas al menos 3 puntos para calcular.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var calc = new CalculadoraDeVolumen(pts);

            double vol = cmbMetodo.SelectedIndex switch
            {
                0 => calc.CalcularVolumenSimpson(),
                1 => calc.CalcularVolumenTrapezoidal(),
                2 => calc.CalcularVolumenRiemann(),
                _ => calc.CalcularVolumenSimpson()
            };

            VolumenObtenido = vol;
            lblResultado.Text = $"{vol:F2} m³";
            btnUsarEnCot.Enabled = true;

            DibujarTerreno3D(pts, calc);
        }

        // ─────────────────────────────────────────────────────────────
        // BOTÓN: Usar en cotización →
        // ─────────────────────────────────────────────────────────────
        private void btnUsarEnCot_Click(object sender, EventArgs e)
        {
            VolumenListo?.Invoke(this, VolumenObtenido);
        }

        // ─────────────────────────────────────────────────────────────
        // GRÁFICA 3D con HelixToolkit
        // ─────────────────────────────────────────────────────────────
        private void DibujarTerreno3D(List<PuntoTerreno> pts, CalculadoraDeVolumen calc)
        {
            _viewport.Children.Clear();
            _viewport.Children.Add(new DefaultLights());

            var (matrizZ, xMin, xMax, yMin, yMax) = calc.GenerarMatrizZ(28, 28);
            int nx = matrizZ.GetLength(0) - 1;
            int ny = matrizZ.GetLength(1) - 1;
            double hx = (xMax - xMin) / nx;
            double hy = (yMax - yMin) / ny;

            var meshBuilder = new MeshBuilder();

            for (int i = 0; i < nx; i++)
            {
                for (int j = 0; j < ny; j++)
                {
                    var p00 = new System.Windows.Media.Media3D.Point3D(
                        xMin + i * hx, yMin + j * hy, matrizZ[i, j]);
                    var p10 = new System.Windows.Media.Media3D.Point3D(
                        xMin + (i + 1) * hx, yMin + j * hy, matrizZ[i + 1, j]);
                    var p01 = new System.Windows.Media.Media3D.Point3D(
                        xMin + i * hx, yMin + (j + 1) * hy, matrizZ[i, j + 1]);
                    var p11 = new System.Windows.Media.Media3D.Point3D(
                        xMin + (i + 1) * hx, yMin + (j + 1) * hy, matrizZ[i + 1, j + 1]);

                    meshBuilder.AddQuad(
                        ToVector3(p00), ToVector3(p10),
                        ToVector3(p11), ToVector3(p01));
                }
            }

            // MeshBuilder (Helix) → MeshGeometry3D (WPF nativo)
            var helixMesh = meshBuilder.ToMesh();
            var wpfMesh = new System.Windows.Media.Media3D.MeshGeometry3D();

            var positions = new System.Windows.Media.Media3D.Point3DCollection();
            foreach (var pos in helixMesh.Positions)
                positions.Add(new System.Windows.Media.Media3D.Point3D(pos.X, pos.Y, pos.Z));

            wpfMesh.Positions = positions;
            wpfMesh.TriangleIndices = new System.Windows.Media.Int32Collection(helixMesh.TriangleIndices);

            // Material: azul sólido
            var material = new System.Windows.Media.Media3D.DiffuseMaterial(
                new System.Windows.Media.SolidColorBrush(
                    System.Windows.Media.Color.FromRgb(30, 120, 180)));

            _viewport.Children.Add(new System.Windows.Media.Media3D.ModelVisual3D
            {
                Content = new System.Windows.Media.Media3D.GeometryModel3D(wpfMesh, material)
            });

            // Esferas naranjas en los puntos de control
            foreach (var p in pts)
            {
                _viewport.Children.Add(new SphereVisual3D
                {
                    Center = new System.Windows.Media.Media3D.Point3D(p.X, p.Y, p.Z),
                    Radius = 0.25,
                    Fill = System.Windows.Media.Brushes.OrangeRed
                });
            }

            _viewport.ZoomExtents(500);
        }

        // Convierte Point3D (WPF) → Vector3 (System.Numerics) para MeshBuilder
        private static Vector3 ToVector3(System.Windows.Media.Media3D.Point3D p) =>
            new((float)p.X, (float)p.Y, (float)p.Z);
    }
}