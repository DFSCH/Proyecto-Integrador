using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace Sistema_de_Calculo.DATOS
{
    /// <summary>
    /// Persistencia en archivos CSV reales (cabecera + filas separadas por coma).
    /// RF31: sin base de datos – solo archivos planos .csv.
    /// Soporta: bool, int, decimal, double, DateTime, string.
    /// Campos con comas o comillas se encierran entre comillas dobles (RFC 4180).
    /// </summary>
    public static class Repositorio
    {
        private static readonly string _dataDir =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        private static readonly CultureInfo _ci = CultureInfo.InvariantCulture;
        private const string DATE_FMT = "yyyy-MM-dd HH:mm:ss";

        static Repositorio()
        {
            if (!Directory.Exists(_dataDir))
                Directory.CreateDirectory(_dataDir);
        }

        private static string Ruta(string archivo) =>
            Path.Combine(_dataDir, archivo + ".csv");

        // ── Escritura ────────────────────────────────────────────────
        public static void Guardar<T>(string archivo, List<T> datos)
        {
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var sb = new StringBuilder();

            // Cabecera
            sb.AppendLine(string.Join(",", props.Select(p => EscaparCsv(p.Name))));

            // Filas
            foreach (var item in datos)
            {
                var valores = props.Select(p => SerializarValor(p.GetValue(item)));
                sb.AppendLine(string.Join(",", valores));
            }

            File.WriteAllText(Ruta(archivo), sb.ToString(), Encoding.UTF8);
        }

        // ── Lectura ──────────────────────────────────────────────────
        public static List<T> Cargar<T>(string archivo) where T : new()
        {
            string ruta = Ruta(archivo);
            if (!File.Exists(ruta)) return new List<T>();

            try
            {
                var lineas = File.ReadAllLines(ruta, Encoding.UTF8)
                                 .Where(l => !string.IsNullOrWhiteSpace(l))
                                 .ToArray();
                if (lineas.Length < 2) return new List<T>();

                var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                var cabecera = ParsearLinea(lineas[0]);

                // Mapa nombre-columna → PropertyInfo (case-insensitive)
                var mapa = cabecera
                    .Select((nombre, idx) => (nombre.Trim(), idx))
                    .ToDictionary(x => x.Item1, x => x.idx,
                                  StringComparer.OrdinalIgnoreCase);

                var lista = new List<T>();
                for (int i = 1; i < lineas.Length; i++)
                {
                    var campos = ParsearLinea(lineas[i]);
                    var obj = new T();
                    foreach (var prop in props)
                    {
                        if (!mapa.TryGetValue(prop.Name, out int col)) continue;
                        if (col >= campos.Length) continue;
                        string raw = campos[col];
                        prop.SetValue(obj, DeserializarValor(raw, prop.PropertyType));
                    }
                    lista.Add(obj);
                }
                return lista;
            }
            catch
            {
                // RF33: archivo corrupto → lista vacía
                return new List<T>();
            }
        }

        public static int SiguienteId<T>(List<T> lista, Func<T, int> getId) =>
            lista.Count == 0 ? 1 : lista.Max(getId) + 1;

        // ── Serialización de valores ─────────────────────────────────
        private static string SerializarValor(object? valor)
        {
            if (valor == null) return "";
            return valor switch
            {
                bool b => b ? "true" : "false",
                DateTime dt => EscaparCsv(dt.ToString(DATE_FMT, _ci)),
                decimal d => d.ToString(_ci),
                double dbl => dbl.ToString("G17", _ci),
                float f => f.ToString("G9", _ci),
                _ => EscaparCsv(valor.ToString() ?? "")
            };
        }

        private static object? DeserializarValor(string raw, Type tipo)
        {
            // Manejar tipos nullable
            Type efectivo = Nullable.GetUnderlyingType(tipo) ?? tipo;

            if (string.IsNullOrEmpty(raw))
            {
                if (efectivo == typeof(string)) return "";
                return efectivo.IsValueType ? Activator.CreateInstance(efectivo) : null;
            }

            if (efectivo == typeof(string))  return raw;
            if (efectivo == typeof(int))     return int.TryParse(raw, out int vi) ? vi : 0;
            if (efectivo == typeof(double))  return double.TryParse(raw, NumberStyles.Any, _ci, out double vd) ? vd : 0.0;
            if (efectivo == typeof(decimal)) return decimal.TryParse(raw, NumberStyles.Any, _ci, out decimal vm) ? vm : 0m;
            if (efectivo == typeof(bool))    return raw.Equals("true", StringComparison.OrdinalIgnoreCase);
            if (efectivo == typeof(DateTime))
                return DateTime.TryParseExact(raw, DATE_FMT, _ci, DateTimeStyles.None, out DateTime ddt)
                    ? ddt : DateTime.Now;

            return raw;
        }

        // ── CSV RFC 4180 ─────────────────────────────────────────────
        private static string EscaparCsv(string valor)
        {
            if (valor.Contains(',') || valor.Contains('"') || valor.Contains('\n'))
                return "\"" + valor.Replace("\"", "\"\"") + "\"";
            return valor;
        }

        private static string[] ParsearLinea(string linea)
        {
            var campos = new List<string>();
            var sb = new StringBuilder();
            bool dentroComillas = false;

            for (int i = 0; i < linea.Length; i++)
            {
                char c = linea[i];
                if (dentroComillas)
                {
                    if (c == '"')
                    {
                        if (i + 1 < linea.Length && linea[i + 1] == '"')
                        { sb.Append('"'); i++; }
                        else
                            dentroComillas = false;
                    }
                    else sb.Append(c);
                }
                else
                {
                    if (c == '"') dentroComillas = true;
                    else if (c == ',') { campos.Add(sb.ToString()); sb.Clear(); }
                    else sb.Append(c);
                }
            }
            campos.Add(sb.ToString());
            return campos.ToArray();
        }

       
        }
    }
}
