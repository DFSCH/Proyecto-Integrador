using ProyectoFinal.DATOS;
using ProyectoFinal.MODELO;

namespace ProyectoFinal.CONTROLADOR
{
    public class AdminControlador
    {
        private readonly PersistenciaUsuario _datos;

        public AdminControlador()
        {
            _datos = new PersistenciaUsuario();
        }

        /// <summary>
        /// Devuelve la lista de usuarios formateada para mostrar en la tabla.
        /// El Estado se convierte a texto aquí, no en la Vista.
        /// </summary>
        public List<object> ObtenerUsuariosParaTabla()
        {
            return _datos.LeerTodos().Select(u => (object)new
            {
                u.Id,
                u.Nombre,
                u.Telefono,
                u.Correo,
                u.Cargo,
                Estado = u.Estado ? "Activo" : "Inactivo"
            }).ToList();
        }

        /// <summary>
        /// Filtra usuarios por nombre o ID.
        /// </summary>
        public List<object> BuscarUsuarios(string filtro)
        {
            var todos = _datos.LeerTodos();
            string f = filtro.ToLower();

            return todos
                .Where(u => u.Nombre.ToLower().Contains(f) || u.Id.Contains(f))
                .Select(u => (object)new
                {
                    u.Id,
                    u.Nombre,
                    u.Telefono,
                    u.Correo,
                    u.Cargo,
                    Estado = u.Estado ? "Activo" : "Inactivo"
                }).ToList();
        }

        /// <summary>
        /// Invierte el estado activo/inactivo de un usuario.
        /// </summary>
        public void CambiarEstado(string id, string estadoActualTexto)
        {
            bool nuevoEstado = (estadoActualTexto != "Activo");
            _datos.ActualizarEstado(id, nuevoEstado);
        }

        /// <summary>
        /// Restablece la contraseña de un usuario. Devuelve mensaje de error o null si fue bien.
        /// </summary>
        public string RestablecerContrasena(string id, string nuevaClave)
        {
            if (string.IsNullOrWhiteSpace(nuevaClave))
                return "La contraseña no puede estar vacía.";

            _datos.ActualizarContrasena(id, nuevaClave.Trim());
            return null; // null = éxito
        }

        /// <summary>
        /// Registra un nuevo usuario. Devuelve mensaje de error o null si fue bien.
        /// </summary>
        public string RegistrarUsuario(string id, string nombre, string telefono,
                                       string correo, string cargo,
                                       string contrasena, string confirmacion)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrasena))
                return "Complete todos los campos obligatorios.";

            if (contrasena != confirmacion)
                return "Las contraseñas no coinciden.";

            var nuevo = new Usuario
            {
                Id = id.Trim(),
                Nombre = nombre.Trim(),
                Telefono = telefono.Trim(),
                Correo = correo.Trim(),
                Cargo = cargo,
                Contrasena = BCrypt.Net.BCrypt.HashPassword(contrasena.Trim()),
                Estado = true
            };

            return _datos.Guardar(nuevo) ? null : "El ID ya está registrado en el sistema.";
        }
    }
}