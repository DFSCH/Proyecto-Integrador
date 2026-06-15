using Sistema_de_Calculo.MODELOS;

namespace Sistema_de_Calculo.UTILIDADES
{
    /// <summary>
    /// Calcula el volumen de material a remover resolviendo una INTEGRAL DOBLE.
    ///
    /// El volumen bajo la superficie del terreno z = f(x,y) es:
    ///
    ///     V = ∬_R f(x,y) dA = ∫_xMin^xMax ( ∫_yMin^yMax f(x,y) dy ) dx
    ///
    /// Por el TEOREMA DE FUBINI, esa integral doble se resuelve como INTEGRAL
    /// ITERADA: primero la integral interna (sobre y) y luego la externa (sobre x).
    /// Cada método de esta clase aplica exactamente esa estructura — una integral
    /// simple anidada dentro de otra — usando la regla numérica correspondiente
    /// (Simpson 1/3, Trapezoidal o Riemann).
    ///
    /// Como el terreno son puntos dispersos sin fórmula analítica, la superficie
    /// continua f(x,y) se reconstruye con interpolación IDW.
    /// </summary>
    public class CalculadoraDeVolumen
    {
        private readonly List<PuntoTerreno> _puntos;

        public CalculadoraDeVolumen(List<PuntoTerreno> puntos)
        {
            _puntos = puntos;
        }

        // ─── Función a integrar: z = f(x,y) reconstruida con IDW ───
        // Se acota a >= 0 porque un volumen de material no puede ser negativo.
        private double F(double x, double y) => Math.Max(0, InterpolarZ(x, y));

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

        // ═══════════════════════════════════════════════════════════════
        //  INTEGRALES SIMPLES (1D) — los "ladrillos" de la integral doble
        //  Cada una resuelve  ∫_a^b g(t) dt  para una función g cualquiera.
        // ═══════════════════════════════════════════════════════════════

        // ─── Simpson 1/3 compuesto en 1D ───
        private static double IntegrarSimpson(Func<double, double> g, double a, double b, int n)
        {
            if (n % 2 != 0) n++;                 // Simpson exige n par
            double h = (b - a) / n;
            double suma = g(a) + g(b);           // extremos → coeficiente 1
            for (int i = 1; i < n; i++)
            {
                double t = a + i * h;
                double coef = (i % 2 == 0) ? 2 : 4;   // pares → 2, impares → 4
                suma += coef * g(t);
            }
            return (h / 3.0) * suma;
        }

        // ─── Trapezoidal compuesto en 1D ───
        private static double IntegrarTrapezoidal(Func<double, double> g, double a, double b, int n)
        {
            double h = (b - a) / n;
            double suma = (g(a) + g(b)) / 2.0;   // extremos → peso 1/2
            for (int i = 1; i < n; i++)
                suma += g(a + i * h);            // interiores → peso 1
            return h * suma;
        }

        // ─── Suma de Riemann (punto medio) en 1D ───
        private static double IntegrarRiemann(Func<double, double> g, double a, double b, int n)
        {
            double h = (b - a) / n;
            double suma = 0;
            for (int i = 0; i < n; i++)
                suma += g(a + (i + 0.5) * h);    // centro de cada subintervalo
            return h * suma;
        }

        // ═══════════════════════════════════════════════════════════════
        //  INTEGRALES DOBLES — integral externa(x) de [ integral interna(y) ]
        // ═══════════════════════════════════════════════════════════════

        /// <summary>
        /// INTEGRAL DOBLE por Simpson 1/3 (método principal).
        ///   V = ∫_xMin^xMax [ ∫_yMin^yMax f(x,y) dy ] dx
        /// Ambas integrales se resuelven por Simpson 1/3 compuesto.
        /// </summary>
        public double CalcularVolumenSimpson(int nx = 20, int ny = 20)
        {
            if (!Dominio(out double xMin, out double xMax, out double yMin, out double yMax))
                return 0;

            // Integral EXTERNA sobre x; su integrando es la integral INTERNA sobre y.
            double volumen = IntegrarSimpson(
                x => IntegrarSimpson(y => F(x, y), yMin, yMax, ny),   // ∫ f dy
                xMin, xMax, nx);                                       // ∫ (...) dx

            return Math.Max(0, volumen);
        }

        /// <summary>
        /// INTEGRAL DOBLE por regla Trapezoidal compuesta.
        ///   V = ∫_xMin^xMax [ ∫_yMin^yMax f(x,y) dy ] dx
        /// </summary>
        public double CalcularVolumenTrapezoidal(int nx = 20, int ny = 20)
        {
            if (!Dominio(out double xMin, out double xMax, out double yMin, out double yMax))
                return 0;

            double volumen = IntegrarTrapezoidal(
                x => IntegrarTrapezoidal(y => F(x, y), yMin, yMax, ny),
                xMin, xMax, nx);

            return Math.Max(0, volumen);
        }

        /// <summary>
        /// INTEGRAL DOBLE por suma de Riemann (punto medio).
        ///   V = ∫_xMin^xMax [ ∫_yMin^yMax f(x,y) dy ] dx
        /// </summary>
        public double CalcularVolumenRiemann(int nx = 20, int ny = 20)
        {
            if (!Dominio(out double xMin, out double xMax, out double yMin, out double yMax))
                return 0;

            double volumen = IntegrarRiemann(
                x => IntegrarRiemann(y => F(x, y), yMin, yMax, ny),
                xMin, xMax, nx);

            return Math.Max(0, volumen);
        }

        /// <summary>
        /// Calcula el dominio de integración [xMin,xMax] × [yMin,yMax].
        /// Devuelve false si no hay puntos suficientes o el área es nula.
        /// </summary>
        private bool Dominio(out double xMin, out double xMax, out double yMin, out double yMax)
        {
            xMin = xMax = yMin = yMax = 0;
            if (_puntos.Count < 3) return false;

            xMin = _puntos.Min(p => p.X); xMax = _puntos.Max(p => p.X);
            yMin = _puntos.Min(p => p.Y); yMax = _puntos.Max(p => p.Y);

            return xMax != xMin && yMax != yMin;
        }

        // ═══════════════════════════════════════════════════════════════
        //  Apoyo para mostrar el proceso paso a paso en la sustentación:
        //  resultado de la integral interna ∫ f(x,y) dy para un x fijo.
        // ═══════════════════════════════════════════════════════════════
        public double IntegralInternaEn(double x, int ny = 20)
        {
            if (!Dominio(out _, out _, out double yMin, out double yMax)) return 0;
            return IntegrarSimpson(y => F(x, y), yMin, yMax, ny);
        }

        /// <summary>
        /// Genera la matriz Z para renderizar la gráfica 3D del terreno.
        /// (No calcula volumen; solo construye la malla de alturas.)
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