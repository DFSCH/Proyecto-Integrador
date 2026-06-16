using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;
using System.Windows.Forms.Integration;   // ElementHost
using HelixToolkit.Wpf;                   // HelixViewport3D, SphereVisual3D, DefaultLights
using HelixToolkit.Geometry;              // MeshBuilder
using Sistema_de_Calculo.MODELOS;         // PuntoTerreno
using Sistema_de_Calculo.UTILIDADES;      // CalculadoraDeVolumen

namespace Sistema_de_Calculo.VISTA
{
    public partial class PanelVolume : UserControl
    {
        // ── Helix WPF embebido en card4 via ElementHost ──────────────
        private readonly ElementHost _helixHost = new();
        private readonly HelixViewport3D _viewport = new();

        // ── Resolución de la malla 3D ─────────────────────────────────
        // Número de divisiones por eje al generar matrizZ.
        // 28 = original (escalón grande). 90 es un buen punto medio.
        private const int RESOLUCION_MALLA = 90;

        // ── Resultado compartible con el formulario padre ─────────────
        public double VolumenObtenido { get; private set; }

        /// <summary>
        /// Se dispara cuando el usuario pulsa "Usar en cotización →".
        /// El padre puede suscribirse para recibir el volumen calculado.
        /// </summary>
        public event EventHandler<double>? VolumenListo;

        // ── Constructor ───────────────────────────────────────────────
        public PanelVolume()
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
        // Externos (perímetro): 4 esquinas; Interno: punto central
        // ─────────────────────────────────────────────────────────────
        private void CargarPuntosPrueba()
        {
            var pts = new (double x, double y, double z, string tipo)[]
            {
                (0.0,  0.0, 2.0,  "Externo"),
                (10.0, 0.0, 3.0,  "Externo"),
                (10.0, 8.0, 4.0,  "Externo"),
                (0.0,  8.0, 2.5,  "Externo"),
                (5.0,  4.0, 5.0,  "Interno"),
            };
            foreach (var (x, y, z, tipo) in pts)
                dgvPuntos.Rows.Add(x, y, z, tipo);
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
                    var tipoStr = row.Cells["colTipo"].Value?.ToString() ?? "Interno";
                    var tipo = tipoStr == "Externo" ? TipoPunto.Externo : TipoPunto.Interno;
                    lista.Add(new PuntoTerreno(x, y, z, tipo));
                }
            }
            return lista;
        }

        private static bool TryLeerCelda(object? valor, out double resultado)
        {
            resultado = 0;
            if (valor == null) return false;

            if (valor is double d) { resultado = d; return true; }
            if (valor is float f) { resultado = f; return true; }
            if (valor is int n) { resultado = n; return true; }

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

            string tipo = cmbTipo.SelectedItem?.ToString() ?? "Interno";
            dgvPuntos.Rows.Add(x, y, z, tipo);
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

            // Validar que si hay externos, sean al menos 3
            var externos = pts.Where(p => p.Tipo == TipoPunto.Externo).ToList();
            if (externos.Count > 0 && externos.Count < 3)
            {
                MessageBox.Show("Si defines puntos externos, necesitas al menos 3 para formar el perímetro.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var calc = new CalculadoraDeVolumen(pts);

            double vol = cmbMetodo.SelectedIndex switch
            {
                0 => calc.CalcularVolumenSimpson(),
                1 => calc.CalcularVolumenTrapezoidal(),
               
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
        //
        // FIX: ya no se decide qué celdas dibujar con "matrizZ > 0".
        // En su lugar se usa una máscara geométrica (punto-en-polígono)
        // sobre el perímetro real. Esto:
        //   1) Elimina los "dientes de sierra": las celdas de borde con
        //      una esquina fuera del perímetro (que caía a Z=0) ya no se
        //      dibujan, así que la superficie no baja en picos al cero.
        //   2) Hace que funcionen las cotas negativas: antes, con Z<0
        //      ninguna celda cumplía "> 0" y no se generaba nada.
        // ─────────────────────────────────────────────────────────────
        private void DibujarTerreno3D(List<PuntoTerreno> pts, CalculadoraDeVolumen calc)
        {
            _viewport.Children.Clear();
            _viewport.Children.Add(new DefaultLights());

            var (matrizZ, xMin, xMax, yMin, yMax) = calc.GenerarMatrizZ(RESOLUCION_MALLA, RESOLUCION_MALLA);

            int filas = matrizZ.GetLength(0);
            int cols = matrizZ.GetLength(1);
            int nx = filas - 1;
            int ny = cols - 1;
            double hx = (xMax - xMin) / nx;
            double hy = (yMax - yMin) / ny;

            // Perímetro (polígono en XY) a partir de los puntos externos, en orden.
            var externos = pts.Where(p => p.Tipo == TipoPunto.Externo).ToList();
            List<PuntoTerreno> poligono = externos.Count >= 3
                ? calc.ObtenerPerimetroOrdenado()
                : new List<PuntoTerreno>();   // sin perímetro definido -> se dibuja todo el bounding box

            bool usarMascara = poligono.Count >= 3;

            // Máscara: ¿cada NODO de la malla cae dentro del perímetro?
            bool[,] dentro = new bool[filas, cols];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!usarMascara)
                    {
                        dentro[i, j] = true;
                        continue;
                    }
                    double nodoX = xMin + i * hx;
                    double nodoY = yMin + j * hy;
                    dentro[i, j] = PuntoEnPoligono(nodoX, nodoY, poligono);
                }
            }

            var meshBuilder = new MeshBuilder();

            for (int i = 0; i < nx; i++)
            {
                for (int j = 0; j < ny; j++)
                {
                    // Solo se dibuja la celda si sus 4 esquinas están dentro del
                    // perímetro. Las celdas a medio camino del borde (que antes
                    // producían los dientes) quedan fuera. Se usa el valor real
                    // de matrizZ (positivo, cero o negativo) sin filtrar por signo.
                    if (!(dentro[i, j] && dentro[i + 1, j] &&
                          dentro[i, j + 1] && dentro[i + 1, j + 1]))
                        continue;

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

            // Malla de terreno (azul)
            if (meshBuilder.Positions.Count > 0)
            {
                var helixMesh = meshBuilder.ToMesh();
                var wpfMesh = new System.Windows.Media.Media3D.MeshGeometry3D();
                var positions = new System.Windows.Media.Media3D.Point3DCollection();
                foreach (var pos in helixMesh.Positions)
                    positions.Add(new System.Windows.Media.Media3D.Point3D(pos.X, pos.Y, pos.Z));

                wpfMesh.Positions = positions;
                wpfMesh.TriangleIndices = new System.Windows.Media.Int32Collection(helixMesh.TriangleIndices);

                var material = new System.Windows.Media.Media3D.DiffuseMaterial(
                    new System.Windows.Media.SolidColorBrush(
                        System.Windows.Media.Color.FromRgb(30, 120, 180)));

                // Material por las dos caras: con cotas negativas la malla se ve
                // desde "abajo" según la cámara, evitando que se vea hueca.
                _viewport.Children.Add(new System.Windows.Media.Media3D.ModelVisual3D
                {
                    Content = new System.Windows.Media.Media3D.GeometryModel3D(wpfMesh, material)
                    {
                        BackMaterial = material
                    }
                });
            }

            // Esferas: verde para externos (perímetro), naranja para internos
            foreach (var p in pts)
            {
                bool esExterno = p.Tipo == TipoPunto.Externo;
                _viewport.Children.Add(new SphereVisual3D
                {
                    Center = new System.Windows.Media.Media3D.Point3D(p.X, p.Y, p.Z),
                    Radius = 0.3,
                    Fill = esExterno
                        ? System.Windows.Media.Brushes.LimeGreen
                        : System.Windows.Media.Brushes.OrangeRed
                });
            }

            // Líneas del perímetro conectando puntos externos en orden
            if (poligono.Count >= 3)
            {
                var lineBuilder = new MeshBuilder();
                for (int i = 0; i < poligono.Count; i++)
                {
                    var a = poligono[i];
                    var b = poligono[(i + 1) % poligono.Count];
                    lineBuilder.AddCylinder(
                        new Vector3((float)a.X, (float)a.Y, (float)a.Z),
                        new Vector3((float)b.X, (float)b.Y, (float)b.Z),
                        0.12f, 6);
                }

                var lineMesh = lineBuilder.ToMesh();
                var wpfLine = new System.Windows.Media.Media3D.MeshGeometry3D();
                var linePos = new System.Windows.Media.Media3D.Point3DCollection();
                foreach (var pos in lineMesh.Positions)
                    linePos.Add(new System.Windows.Media.Media3D.Point3D(pos.X, pos.Y, pos.Z));
                wpfLine.Positions = linePos;
                wpfLine.TriangleIndices = new System.Windows.Media.Int32Collection(lineMesh.TriangleIndices);

                var lineMat = new System.Windows.Media.Media3D.DiffuseMaterial(
                    new System.Windows.Media.SolidColorBrush(
                        System.Windows.Media.Color.FromRgb(50, 220, 50)));

                _viewport.Children.Add(new System.Windows.Media.Media3D.ModelVisual3D
                {
                    Content = new System.Windows.Media.Media3D.GeometryModel3D(wpfLine, lineMat)
                });
            }

            _viewport.ZoomExtents(500);
        }

        // ─────────────────────────────────────────────────────────────
        // Punto-en-polígono (ray casting) en el plano XY.
        // Devuelve true si (px, py) está dentro del polígono dado.
        // ─────────────────────────────────────────────────────────────
        private static bool PuntoEnPoligono(double px, double py, List<PuntoTerreno> poly)
        {
            bool dentro = false;
            int n = poly.Count;
            for (int i = 0, j = n - 1; i < n; j = i++)
            {
                double xi = poly[i].X, yi = poly[i].Y;
                double xj = poly[j].X, yj = poly[j].Y;

                bool cruzaEnY = (yi > py) != (yj > py);
                if (cruzaEnY)
                {
                    double xInterseccion = (xj - xi) * (py - yi) / (yj - yi) + xi;
                    if (px < xInterseccion)
                        dentro = !dentro;
                }
            }
            return dentro;
        }

        // Convierte Point3D (WPF) → Vector3 (System.Numerics) para MeshBuilder
        private static Vector3 ToVector3(System.Windows.Media.Media3D.Point3D p) =>
            new((float)p.X, (float)p.Y, (float)p.Z);
    }
}