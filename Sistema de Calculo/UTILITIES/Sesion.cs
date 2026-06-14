using Sistema_de_Calculo.MODELOS;

using System.Drawing.Printing;
using System.IO;

namespace Sistema_de_Calculo.UTILIDADES
{
    /// <summary>
    /// Sesión del usuario activo. Único punto de verdad para rol y permisos.
    /// </summary>
    public static class Sesion
    {
        public static Usuario? UsuarioActivo { get; private set; }
        public static bool EsAdmin => UsuarioActivo?.Rol == "admin";

        public static void Iniciar(Usuario u) => UsuarioActivo = u;
        public static void Cerrar() => UsuarioActivo = null;
    }

    /// <summary>
    /// RF24 / RF30: genera e imprime cotizaciones y facturas como PDF.
    /// Usa PrintDocument (WinForms nativo, sin librerías externas).
    /// El usuario ve el diálogo estándar de impresión de Windows y puede
    /// seleccionar "Microsoft Print to PDF" para guardar como archivo PDF.
    /// </summary>
    public static class Impresora
    {
        // ── Cotización ────────────────────────────────────────────────
        public static void ImprimirCotizacion(
            Cotizacion cot, Cliente? cliente, Material? material)
        {
            var lineas = ArmarCotizacion(cot, cliente, material);
            MostrarDialogoImpresion(lineas, $"Cotización {cot.Numero}");
        }

        // ── Factura ───────────────────────────────────────────────────
        public static void ImprimirFactura(
            Factura fac, Cotizacion? cot,
            Cliente? cliente, Material? material)
        {
            var lineas = ArmarFactura(fac, cot, cliente, material);
            MostrarDialogoImpresion(lineas, $"Factura {fac.Numero}");
        }

        // ── Contenido de cotización ───────────────────────────────────
        private static List<(string texto, bool esNegrita, bool esSeparador, int tamFuente)>
            ArmarCotizacion(Cotizacion cot, Cliente? cliente, Material? material)
        {
            decimal iva = 0m;
            decimal total = cot.CostoTotal;

            return new()
            {
                ("GeoVolumen Pro", true, false, 18),
                ("Sistema de Cotización para Movimiento de Tierra", false, false, 10),
                ("", false, true, 0),
                ($"COTIZACIÓN N° {cot.Numero}", true, false, 14),
                ($"Fecha: {cot.Fecha:dd/MM/yyyy}     Estado: {cot.Estado.ToUpper()}", false, false, 10),
                ("", false, true, 0),
                ("DATOS DEL CLIENTE", true, false, 11),
                ($"Nombre:           {cliente?.Nombre ?? "N/A"}", false, false, 10),
                ($"Identificación:   {cliente?.Identificacion ?? "—"}", false, false, 10),
                ($"Teléfono:         {cliente?.Telefono ?? "—"}", false, false, 10),
                ($"Correo:           {cliente?.Correo ?? "—"}", false, false, 10),
                ("", false, true, 0),
                ("DETALLE DEL TRABAJO", true, false, 11),
                ($"Material:         {material?.Nombre ?? "N/A"}", false, false, 10),
                ($"Volumen excavado: {cot.Volumen:F2} m³", false, false, 10),
                ($"Costo por m³:     {material?.CostoPorM3:N0} COP", false, false, 10),
                ("", false, true, 0),
                ($"TOTAL:            {total:N0} COP", true, false, 13),
                ("", false, true, 0),
                ("Método de cálculo: Integrales dobles (Simpson 1/3 compuesto)", false, false, 9),
                ("", false, true, 0),
                ("", false, true, 0),
                ($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}  —  GeoVolumen Pro", false, false, 8),
            };
        }

        // ── Contenido de factura ──────────────────────────────────────
        private static List<(string texto, bool esNegrita, bool esSeparador, int tamFuente)>
            ArmarFactura(Factura fac, Cotizacion? cot, Cliente? cliente, Material? material)
        {
            decimal subtotal = cot?.CostoTotal ?? 0m;
            decimal iva = subtotal * 0.19m;
            decimal total = subtotal + iva;

            return new()
            {
                ("GeoVolumen Pro", true, false, 18),
                ("Sistema de Cotización para Movimiento de Tierra", false, false, 10),
                ("", false, true, 0),
                ($"FACTURA N° {fac.Numero}", true, false, 14),
                ($"Fecha emisión: {fac.Fecha:dd/MM/yyyy}     Estado: {fac.Estado.ToUpper()}", false, false, 10),
                ($"Cotización base:  {cot?.Numero ?? "—"}", false, false, 10),
                ("", false, true, 0),
                ("DATOS DEL CLIENTE", true, false, 11),
                ($"Nombre:           {cliente?.Nombre ?? "N/A"}", false, false, 10),
                ($"Identificación:   {cliente?.Identificacion ?? "—"}", false, false, 10),
                ($"Teléfono:         {cliente?.Telefono ?? "—"}", false, false, 10),
                ($"Correo:           {cliente?.Correo ?? "—"}", false, false, 10),
                ("", false, true, 0),
                ("DETALLE DE LA FACTURA", true, false, 11),
                ($"Material:         {material?.Nombre ?? "N/A"}", false, false, 10),
                ($"Volumen:          {cot?.Volumen:F2} m³", false, false, 10),
                ($"Subtotal:         {subtotal:N0} COP", false, false, 10),
                ($"IVA (19 %):       {iva:N0} COP", false, false, 10),
                ("", false, true, 0),
                ($"TOTAL A PAGAR:    {total:N0} COP", true, false, 13),
                ("", false, true, 0),
                ("", false, true, 0),
                ($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}  —  GeoVolumen Pro", false, false, 8),
            };
        }

        // ── Motor de impresión con PrintDocument ──────────────────────
        private static void MostrarDialogoImpresion(
            List<(string texto, bool esNegrita, bool esSeparador, int tamFuente)> lineas,
            string titulo)
        {
            int lineaActual = 0;
            const int MARGEN = 60;
            const int ALTO_LINEA_BASE = 18;
            const int SEP_GROSOR = 1;

            var doc = new PrintDocument();
            doc.DocumentName = titulo;

            doc.PrintPage += (sender, e) =>
            {
                if (e.Graphics == null) return;

                float y = MARGEN;
                float anchoUtil = e.PageBounds.Width - MARGEN * 2;

                // Logo / banda superior
                using var brushAzul = new SolidBrush(Color.FromArgb(24, 95, 165));
                e.Graphics.FillRectangle(brushAzul, MARGEN, y - 10, anchoUtil, 4);
                y += 6;

                while (lineaActual < lineas.Count)
                {
                    var (texto, esNegrita, esSeparador, tamFuente) = lineas[lineaActual];

                    if (esSeparador)
                    {
                        y += 4;
                        if (texto == "")
                        {
                            // línea horizontal fina
                            using var penSep = new Pen(Color.FromArgb(200, 200, 200), SEP_GROSOR);
                            e.Graphics.DrawLine(penSep, MARGEN, y, MARGEN + anchoUtil, y);
                            y += 6;
                        }
                        lineaActual++;
                        continue;
                    }

                    int tam = tamFuente > 0 ? tamFuente : 10;
                    var estilo = esNegrita ? FontStyle.Bold : FontStyle.Regular;
                    using var font = new Font("Segoe UI", tam, estilo);
                    float altoLinea = font.GetHeight(e.Graphics) + 4;

                    // ¿Quedan hojas? (salto de página)
                    if (y + altoLinea > e.PageBounds.Height - MARGEN)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    Color colorTexto = esNegrita && tam >= 13
                        ? Color.FromArgb(24, 95, 165)
                        : Color.FromArgb(30, 30, 30);

                    using var brush = new SolidBrush(colorTexto);
                    e.Graphics.DrawString(texto, font, brush, MARGEN, y);
                    y += altoLinea;

                    lineaActual++;
                }

                // Banda inferior
                float yPie = e.PageBounds.Height - MARGEN + 10;
                e.Graphics.FillRectangle(brushAzul, MARGEN, yPie, anchoUtil, 4);
                e.HasMorePages = false;
            };

            // Resetear puntero para si se llama varias veces
            lineaActual = 0;

            using var dialogo = new PrintDialog
            {
                Document = doc,
                UseEXDialog = true,
                AllowSomePages = false,
                AllowSelection = false
            };

            // Nota: en Windows, "Microsoft Print to PDF" aparece como
            // impresora en el diálogo — el usuario la selecciona para
            // guardar como PDF.
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    doc.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error al imprimir: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
