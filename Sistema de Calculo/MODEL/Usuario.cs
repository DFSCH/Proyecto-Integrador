namespace Sistema_de_Calculo.MODELOS
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Correo { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string Rol { get; set; } = "usuario"; // "admin" | "usuario"
        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
