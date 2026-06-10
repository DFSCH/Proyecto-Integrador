using ProyectoFinal.DATOS;
using ProyectoFinal.MODELO;

namespace ProyectoFinal.CONTROLADOR
{
    public class Autenticador
    {
        private readonly PersistenciaUsuario _datos;

        public Autenticador()
        {
            _datos = new PersistenciaUsuario();
        }

        /// <summary>
        /// Validamos credenciales y devuelve el usuario si son correctas, null si no.
        /// </summary>
        /// 
        public Usuario Login(string id, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(contrasena))
                return null;

            var usuario = _datos.LeerTodos().FirstOrDefault(u => u.Id == id);

            if (usuario == null) return null;
            if (!BCrypt.Net.BCrypt.Verify(contrasena, usuario.Contrasena)) return null;

            return usuario; // El Form decide qué hacer según Estado y Cargo
        }
    }
}