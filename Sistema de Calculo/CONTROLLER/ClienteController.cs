using Sistema_de_Calculo.MODELOS;
using Sistema_de_Calculo.DATOS;

namespace Sistema_de_Calculo.CONTROLADOR
{
    /// <summary>
    /// RF09–RF11: registro, consulta y búsqueda de clientes.
    /// </summary>
    public class ClienteController
    {
        private const string ARCHIVO = "clientes";

        public (bool ok, string msg) RegistrarCliente(
            string nombre, string identificacion, string telefono, string correo)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return (false, "El nombre es requerido.");
            if (string.IsNullOrWhiteSpace(identificacion))
                return (false, "La identificación es requerida.");

            var lista = Repositorio.Cargar<Cliente>(ARCHIVO);

            if (lista.Any(c => c.Identificacion == identificacion))
                return (false, "Ya existe un cliente con esa identificación.");

            lista.Add(new Cliente
            {
                Id = Repositorio.SiguienteId(lista, c => c.Id),
                Nombre = nombre,
                Identificacion = identificacion,
                Telefono = telefono,
                Correo = correo,
                FechaRegistro = DateTime.Now
            });

            Repositorio.Guardar(ARCHIVO, lista);
            return (true, "Cliente registrado correctamente.");
        }

        public List<Cliente> ObtenerTodos() =>
            Repositorio.Cargar<Cliente>(ARCHIVO);

        public List<Cliente> Buscar(string termino)
        {
            if (string.IsNullOrWhiteSpace(termino))
                return ObtenerTodos();
            return ObtenerTodos().Where(c =>
                c.Nombre.Contains(termino, StringComparison.OrdinalIgnoreCase) ||
                c.Identificacion.Contains(termino)).ToList();
        }

        public Cliente? ObtenerPorId(int id) =>
            ObtenerTodos().FirstOrDefault(c => c.Id == id);
    }
}
