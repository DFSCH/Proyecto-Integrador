namespace Sistema_de_Calculo.MODELOS;

public class Cliente
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Identificacion { get; set; } = "";
    public string Telefono { get; set; } = "";
    public string Correo { get; set; } = "";
    public DateTime FechaRegistro { get; set; } = DateTime.Now;
}
