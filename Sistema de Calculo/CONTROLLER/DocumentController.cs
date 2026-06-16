using Sistema_de_Calculo.MODELOS;
using Sistema_de_Calculo.DATOS;

namespace Sistema_de_Calculo.CONTROLADOR
{
    /// <summary>
    /// RF19–RF30: cotizaciones, facturas, estados y conversión.
    /// </summary>
    public class DocumentController
    {
        private const string ARCH_COT = "cotizaciones";
        private const string ARCH_FAC = "facturas";

        // ─── COTIZACIONES ───────────────────────────────────────────

        // RF19–RF21: generar cotización
        public (bool ok, string msg) CrearCotizacion(
            int clienteId, int materialId, double volumen,
            decimal costoTotal, string coordenadasJson)
        {
            var lista = Repositorio.Cargar<Cotizacion>(ARCH_COT);
            int num = lista.Count + 1;
            lista.Add(new Cotizacion
            {
                Id = Repositorio.SiguienteId(lista, c => c.Id),
                Numero = $"COT-{num:D4}",
                ClienteId = clienteId,
                MaterialId = materialId,
                Volumen = volumen,
                CostoTotal = costoTotal,
                Estado = "activa",
                Fecha = DateTime.Now,
                Coordenadas = coordenadasJson
            });
            Repositorio.Guardar(ARCH_COT, lista);
            return (true, $"Cotización COT-{num:D4} creada.");
        }

        // RF22: historial
        public List<Cotizacion> ObtenerCotizaciones() =>
            Repositorio.Cargar<Cotizacion>(ARCH_COT);

        public Cotizacion? ObtenerCotizacionPorId(int id) =>
            ObtenerCotizaciones().FirstOrDefault(c => c.Id == id);

        // RF23: cambiar estado (solo admin en la vista)
        public (bool ok, string msg) CambiarEstadoCotizacion(int id)
        {
            var lista = Repositorio.Cargar<Cotizacion>(ARCH_COT);
            var cot = lista.FirstOrDefault(c => c.Id == id);
            if (cot == null) return (false, "Cotización no encontrada.");
            cot.Estado = cot.Estado == "activa" ? "inactiva" : "activa";
            Repositorio.Guardar(ARCH_COT, lista);
            return (true, $"Estado cambiado a {cot.Estado}.");
        }

        // ─── FACTURAS ───────────────────────────────────────────────

        // RF25: convertir cotización en factura
        public (bool ok, string msg) ConvertirAFactura(int cotizacionId, int clienteId)
        {
            var facs = Repositorio.Cargar<Factura>(ARCH_FAC);
            if (facs.Any(f => f.CotizacionId == cotizacionId))
                return (false, "Ya existe una factura para esta cotización.");

            int num = facs.Count + 1;
            facs.Add(new Factura
            {
                Id = Repositorio.SiguienteId(facs, f => f.Id),
                Numero = $"FAC-{num:D4}",
                CotizacionId = cotizacionId,
                ClienteId = clienteId,
                Estado = "activa",
                Fecha = DateTime.Now
            });
            Repositorio.Guardar(ARCH_FAC, facs);
            return (true, $"Factura FAC-{num:D4} generada.");
        }

        // RF28: historial de facturas
        public List<Factura> ObtenerFacturas() =>
            Repositorio.Cargar<Factura>(ARCH_FAC);

        // RF29: filtrar facturas por cliente (nombre), estado y fechas
        public List<Factura> FiltrarFacturas(
            string? clienteNombre = null, string? estado = null, DateTime? desde = null, DateTime? hasta = null)
        {
            var lista = ObtenerFacturas();

            // Filtro por nombre de cliente: obtenemos los IDs que coincidan
            if (!string.IsNullOrWhiteSpace(clienteNombre))
            {
                var todosClientes = DATOS.Repositorio.Cargar<MODELOS.Client>("clientes");
                var ids = todosClientes
                    .Where(c => c.Nombre.Contains(clienteNombre, StringComparison.OrdinalIgnoreCase)
                             || c.Identificacion.Contains(clienteNombre, StringComparison.OrdinalIgnoreCase))
                    .Select(c => c.Id)
                    .ToHashSet();
                lista = lista.Where(f => ids.Contains(f.ClienteId)).ToList();
            }

            if (!string.IsNullOrEmpty(estado))
                lista = lista.Where(f => f.Estado == estado).ToList();
            if (desde.HasValue)
                lista = lista.Where(f => f.Fecha >= desde.Value).ToList();
            if (hasta.HasValue)
                lista = lista.Where(f => f.Fecha <= hasta.Value.AddDays(1)).ToList();
            return lista;
        }

        // RF27: cambiar estado factura (solo admin)
        public (bool ok, string msg) CambiarEstadoFactura(int id)
        {
            var lista = Repositorio.Cargar<Factura>(ARCH_FAC);
            var fac = lista.FirstOrDefault(f => f.Id == id);
            if (fac == null) return (false, "Factura no encontrada.");
            fac.Estado = fac.Estado == "activa" ? "inactiva" : "activa";
            Repositorio.Guardar(ARCH_FAC, lista);
            return (true, $"Estado cambiado a {fac.Estado}.");
        }
        public (bool ok, string msg) EliminarFactura(int id)
        {
            var lista = Repositorio.Cargar<Factura>(ARCH_FAC);
            var fac = lista.FirstOrDefault(f => f.Id == id);
            if (fac == null)
                return (false, "No se encontró la factura.");

            lista.Remove(fac);
            Repositorio.Guardar(ARCH_FAC, lista);
            return (true, "Factura eliminada correctamente.");
        }

        public (bool ok, string msg) EliminarCotizacion(int id)
        {
            var facs = Repositorio.Cargar<Factura>(ARCH_FAC);
            if (facs.Any(f => f.CotizacionId == id))
                return (false, "No se puede eliminar: la cotización ya tiene una factura asociada.");

            var lista = Repositorio.Cargar<Cotizacion>(ARCH_COT);
            var cot = lista.FirstOrDefault(c => c.Id == id);
            if (cot == null)
                return (false, "No se encontró la cotización.");

            lista.Remove(cot);
            Repositorio.Guardar(ARCH_COT, lista);
            return (true, "Cotización eliminada correctamente.");
        }
    }
}
