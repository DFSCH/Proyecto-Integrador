using ProyectoFinal.DATOS;
using ProyectoFinal.MODELO;

namespace ProyectoFinal.CONTROLADOR
{
    public class UsuarioControlador
    {
        private readonly PersistenciaUsuario _datos;

        public UsuarioControlador()
        {
            _datos = new PersistenciaUsuario();
        }

        /// <summary>
        /// Cambia la contraseña del usuario después de verificar la actual.
        /// Devuelve un mensaje descriptivo del resultado.
        /// </summary>
        public string CambiarContrasena(string idUsuario, string claveActual, string nuevaClave, string confirmacion)
        {
            var usuario = _datos.LeerTodos().Find(u => u.Id == idUsuario);

            if (usuario == null)
                return "Usuario no encontrado.";

            if (!BCrypt.Net.BCrypt.Verify(claveActual, usuario.Contrasena))
                return "La contraseña actual es incorrecta.";

            if (string.IsNullOrWhiteSpace(nuevaClave))
                return "La nueva contraseña no puede estar vacía.";

            if (nuevaClave != confirmacion)
                return "Las contraseñas no coinciden.";

            _datos.ActualizarContrasena(idUsuario, nuevaClave.Trim());
            return null; // null = éxito, sin error
        }

        public string RestablecerContrasena(string id, string nuevaClave)
        {
            if (string.IsNullOrWhiteSpace(nuevaClave))
                return "La contraseña no puede estar vacía.";

            _datos.ActualizarContrasena(id, nuevaClave.Trim());
            return null;
        }
    }
}