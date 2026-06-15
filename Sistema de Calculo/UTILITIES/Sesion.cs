using Sistema_de_Calculo.MODELOS;
using System.IO;

namespace Sistema_de_Calculo.UTILIDADES
{
    /// <summary>
    /// Sesión del usuario activo. Único punto de verdad para rol y permisos.
    /// </summary>
    public static class Sesion
    {
        public static User? UsuarioActivo { get; private set; }
        public static bool EsAdmin => UsuarioActivo?.Rol == "admin";

        public static void Iniciar(User u) => UsuarioActivo = u;
        public static void Cerrar() => UsuarioActivo = null;
    }
}
