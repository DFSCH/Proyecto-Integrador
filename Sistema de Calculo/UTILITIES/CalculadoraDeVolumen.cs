using Sistema_de_Calculo.MODELOS;

namespace Sistema_de_Calculo.UTILIDADES

{
    /// <summary>
    /// Calcula el volumen de un terreno usando integrales dobles.
    /// Método principal: Simpson 1/3 compuesto en 2D.
    /// La superficie z = f(x,y) se construye con interpolación IDW
    /// a partir de los puntos de control ingresados.
    /// </summary>
    public class CalculadoraDeVolumen
    {
        private readonly List<PuntoTerreno> _puntos;

        public CalculadoraDeVolumen(List<PuntoTerreno> puntos)
        {
            _puntos = puntos;
        }

        // ─── Interpolación inversa ponderada por distancia (IDW) ───
        private double InterpolarZ(double x, double y)
        {
            double pesoTotal = 0, zPonderado = 0;
            foreach (var p in _puntos)
            {
                double dist = Math.Sqrt(Math.Pow(x - p.X, 2) + Math.Pow(y - p.Y, 2)) + 1e-10;
                double peso = 1.0 / (dist * dist);
                zPonderado += peso * p.Z;
                pesoTotal += peso;
            }
            return zPonderado / pesoTotal;
        }

        // ─── Coeficientes de Simpson ───
        private static double CoefSimpson(int i, int n)
        {
            if (i == 0 || i == n) return 1;
            return i % 2 == 0 ? 2 : 4;
        }

        /// <summary>
        /// Integración doble por Simpson 1/3 compuesto.
        /// V = (hx·hy/9) · ΣᵢΣⱼ c(i)·c(j)·f(xᵢ,yⱼ)
        /// </summary>
        public double CalcularVolumenSimpson(int nx = 20, int ny = 20)
        {
            if (_puntos.Count < 3) return 0;

            double xMin = _puntos.Min(p => p.X), xMax = _puntos.Max(p => p.X);
            double yMin = _puntos.Min(p => p.Y), yMax = _puntos.Max(p => p.Y);

            if (xMax == xMin || yMax == yMin) return 0;

            // n debe ser par para Simpson
            if (nx % 2 != 0) nx++;
            if (ny % 2 != 0) ny++;

            double hx = (xMax - xMin) / nx;
            double hy = (yMax - yMin) / ny;
            double suma = 0;

            for (int i = 0; i <= nx; i++)
            {
                double xi = xMin + i * hx;
                for (int j = 0; j <= ny; j++)
                {
                    double yj = yMin + j * hy;
                    double z = InterpolarZ(xi, yj);
                    if (z > 0)
                        suma += CoefSimpson(i, nx) * CoefSimpson(j, ny) * z;
                }
            }

            return Math.Max(0, (hx * hy / 9.0) * suma);
        }

        /// <summary>
        /// Integración doble por regla trapezoidal compuesta.
        /// V ≈ (hx·hy/4) · ΣᵢΣⱼ [f(i,j)+f(i+1,j)+f(i,j+1)+f(i+1,j+1)]
        /// </summary>
        public double CalcularVolumenTrapezoidal(int nx = 20, int ny = 20)
        {
            if (_puntos.Count < 3) return 0;

            double xMin = _puntos.Min(p => p.X), xMax = _puntos.Max(p => p.X);
            double yMin = _puntos.Min(p => p.Y), yMax = _puntos.Max(p => p.Y);
            if (xMax == xMin || yMax == yMin) return 0;

            double hx = (xMax - xMin) / nx;
            double hy = (yMax - yMin) / ny;
            double suma = 0;

            for (int i = 0; i < nx; i++)
            {
                for (int j = 0; j < ny; j++)
                {
                    double z00 = InterpolarZ(xMin + i * hx, yMin + j * hy);
                    double z10 = InterpolarZ(xMin + (i + 1) * hx, yMin + j * hy);
                    double z01 = InterpolarZ(xMin + i * hx, yMin + (j + 1) * hy);
                    double z11 = InterpolarZ(xMin + (i + 1) * hx, yMin + (j + 1) * hy);
                    suma += (z00 + z10 + z01 + z11);
                }
            }

            return Math.Max(0, (hx * hy / 4.0) * suma);
        }

        /// <summary>
        /// Suma de Riemann (punto medio de cada celda).
        /// </summary>
        public double CalcularVolumenRiemann(int nx = 20, int ny = 20)
        {
            if (_puntos.Count < 3) return 0;

            double xMin = _puntos.Min(p => p.X), xMax = _puntos.Max(p => p.X);
            double yMin = _puntos.Min(p => p.Y), yMax = _puntos.Max(p => p.Y);
            if (xMax == xMin || yMax == yMin) return 0;

            double hx = (xMax - xMin) / nx;
            double hy = (yMax - yMin) / ny;
            double suma = 0;

            for (int i = 0; i < nx; i++)
                for (int j = 0; j < ny; j++)
                    suma += InterpolarZ(xMin + (i + 0.5) * hx, yMin + (j + 0.5) * hy);

            return Math.Max(0, hx * hy * suma);
        }

        /// <summary>
        /// Genera la matriz Z para renderizar la gráfica 3D.
        /// </summary>
        public (double[,] MatrizZ, double xMin, double xMax, double yMin, double yMax)
            GenerarMatrizZ(int nx = 30, int ny = 30)
        {
            double xMin = _puntos.Min(p => p.X), xMax = _puntos.Max(p => p.X);
            double yMin = _puntos.Min(p => p.Y), yMax = _puntos.Max(p => p.Y);
            double hx = (xMax - xMin) / nx;
            double hy = (yMax - yMin) / ny;
            var matriz = new double[nx + 1, ny + 1];

            for (int i = 0; i <= nx; i++)
                for (int j = 0; j <= ny; j++)
                    matriz[i, j] = InterpolarZ(xMin + i * hx, yMin + j * hy);

            return (matriz, xMin, xMax, yMin, yMax);
        }
    }
}
