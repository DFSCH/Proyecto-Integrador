using Sistema_de_Calculo.MODELOS;
using Sistema_de_Calculo.DATOS;

namespace Sistema_de_Calculo.CONTROLADOR
{
    /// <summary>
    /// RF17–RF18: tipos de material y costo por unidad.
    /// </summary>
    public class MaterialController
    {
        private const string ARCHIVO = "materiales";

        public (bool ok, string msg) RegistrarMaterial(string nombre, decimal costoPorM3)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return (false, "El nombre es requerido.");
            if (costoPorM3 <= 0)
                return (false, "El costo debe ser mayor a cero.");

            var lista = Repositorio.Cargar<Material>(ARCHIVO);
            lista.Add(new Material
            {
                Id = Repositorio.SiguienteId(lista, m => m.Id),
                Nombre = nombre,
                CostoPorM3 = costoPorM3
            });

            Repositorio.Guardar(ARCHIVO, lista);
            return (true, "Material registrado correctamente.");
        }

        // RF: eliminar material (borrado físico del CSV)
        public (bool ok, string msg) EliminarMaterial(int id)
        {
            // Evita dejar cotizaciones huérfanas
            var cots = Repositorio.Cargar<Cotizacion>("cotizaciones");
            if (cots.Any(c => c.MaterialId == id))
                return (false, "No se puede eliminar: el material está usado en una o más cotizaciones.");

            var lista = Repositorio.Cargar<Material>(ARCHIVO);
            var mat = lista.FirstOrDefault(m => m.Id == id);
            if (mat == null)
                return (false, "No se encontró el material.");

            lista.Remove(mat);
            Repositorio.Guardar(ARCHIVO, lista);
            return (true, "Material eliminado correctamente.");
        }

        public List<Material> ObtenerTodos() =>
            Repositorio.Cargar<Material>(ARCHIVO);

        public Material? ObtenerPorId(int id) =>
            ObtenerTodos().FirstOrDefault(m => m.Id == id);

        public void InicializarMateriales()
        {
            var lista = Repositorio.Cargar<Material>(ARCHIVO);
            if (lista.Count == 0)
            {
                lista.AddRange(new[]
                {
                    new Material { Id=1, Nombre="Arena",    CostoPorM3=45000 },
                    new Material { Id=2, Nombre="Tierra",   CostoPorM3=25000 },
                    new Material { Id=3, Nombre="Roca",     CostoPorM3=85000 },
                    new Material { Id=4, Nombre="Gravilla", CostoPorM3=60000 },
                });
                Repositorio.Guardar(ARCHIVO, lista);
            }
        }
    }
}