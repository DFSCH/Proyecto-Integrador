using Sistema_de_Calculo.DATOS;
using Sistema_de_Calculo.MODELOS;
using BCrypt.Net;

namespace Sistema_de_Calculo.CONTROLADOR
{
    /// <summary>
    /// Maneja RF01–RF08: registro, login, cambio de contraseña,
    /// activar/desactivar usuarios y control de roles.
    /// </summary>
    public class UserController
    {
        private const string ARCHIVO = "usuarios";

        // ─── Reglas de contraseña RF08 ───
        public static (bool ok, string mensaje) ValidarContrasena(string pw)
        {
            if (pw.Length < 8)
                return (false, "Mínimo 8 caracteres.");
            if (!pw.Any(char.IsUpper))
                return (false, "Debe incluir al menos una letra mayúscula.");
            if (!pw.Any(char.IsDigit))
                return (false, "Debe incluir al menos un número.");
            if (pw.All(c => char.IsLetterOrDigit(c)))
                return (false, "Debe incluir al menos un carácter especial (!@#$%…).");
            return (true, "");
        }

        // RF01: registrar usuario
        public (bool ok, string msg) RegistrarUsuario(
            string nombre, string correo, string password, string rol = "usuario")
        {
            var (valida, msgPw) = ValidarContrasena(password);
            if (!valida) return (false, msgPw);

            var lista = Repositorio.Cargar<User>(ARCHIVO);

            if (lista.Any(u => u.Correo.Equals(correo, StringComparison.OrdinalIgnoreCase)))
                return (false, "Ya existe un usuario con ese correo.");

            var nuevo = new User
            {
                Id = Repositorio.SiguienteId(lista, u => u.Id),
                Nombre = nombre,
                Correo = correo,
                // RNF03: hash con BCrypt.Net-Next
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password),
                Rol = rol,
                Activo = true,
                FechaCreacion = DateTime.Now
            };

            lista.Add(nuevo);
            Repositorio.Guardar(ARCHIVO, lista);
            return (true, "Usuario registrado correctamente.");
        }

        // RF02 + RF03: inicio de sesión con validación
        public (bool ok, User? usuario, string msg) IniciarSesion(string correo, string password)
        {
            var lista = Repositorio.Cargar<User>(ARCHIVO);
            var usuario = lista.FirstOrDefault(u =>
                u.Correo.Equals(correo, StringComparison.OrdinalIgnoreCase));

            if (usuario == null)
                return (false, null, "Correo no registrado.");

            // RF07: usuario inactivo no puede entrar
            if (!usuario.Activo)
                return (false, null, "Tu cuenta está inactiva. Contacta al administrador.");

            bool coincide;
            try
            {
                coincide = BCrypt.Net.BCrypt.Verify(password, usuario.PasswordHash);
            }
            catch
            {
                // compatibilidad con hashes legacy
                coincide = usuario.PasswordHash == password;
            }

            if (!coincide)
                return (false, null, "Contraseña incorrecta.");

            return (true, usuario, "");
        }

        // RF04 / RF05: cambiar contraseña
        public (bool ok, string msg) CambiarContrasena(int usuarioId, string nuevaPassword)
        {
            var (valida, msgPw) = ValidarContrasena(nuevaPassword);
            if (!valida) return (false, msgPw);

            var lista = Repositorio.Cargar<User>(ARCHIVO);
            var u = lista.FirstOrDefault(x => x.Id == usuarioId);
            if (u == null) return (false, "Usuario no encontrado.");

            u.PasswordHash = BCrypt.Net.BCrypt.HashPassword(nuevaPassword);
            Repositorio.Guardar(ARCHIVO, lista);
            return (true, "Contraseña actualizada correctamente.");
        }

        // RF06: activar / desactivar usuario
        public (bool ok, string msg) CambiarEstadoUsuario(int usuarioId)
        {
            var lista = Repositorio.Cargar<User>(ARCHIVO);
            var u = lista.FirstOrDefault(x => x.Id == usuarioId);
            if (u == null) return (false, "Usuario no encontrado.");

            u.Activo = !u.Activo;
            Repositorio.Guardar(ARCHIVO, lista);
            return (true, u.Activo ? "Usuario activado." : "Usuario desactivado.");
        }

        // RF08 (consulta): lista de usuarios
        public List<User> ObtenerTodos() =>
            Repositorio.Cargar<User>(ARCHIVO);

        // Seed inicial: crea admin si no hay usuarios
        public void InicializarAdmin()
        {
            var lista = Repositorio.Cargar<User>(ARCHIVO);
            if (lista.Count == 0)
            {
                lista.Add(new User
                {
                    Id = 1,
                    Nombre = "Administrador",
                    Correo = "admin@sistema.com",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin123!"),
                    Rol = "admin",
                    Activo = true,
                    FechaCreacion = DateTime.Now
                });
                Repositorio.Guardar(ARCHIVO, lista);
            }
        }
    }
}
