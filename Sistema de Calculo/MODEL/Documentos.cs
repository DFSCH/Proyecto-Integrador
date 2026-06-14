namespace Sistema_de_Calculo.MODELOS
{
    public class Cotizacion
{
    public int Id { get; set; }
    public string Numero { get; set; } = "";
    public int ClienteId { get; set; }
    public int MaterialId { get; set; }
    public double Volumen { get; set; }          // m³
    public decimal CostoTotal { get; set; }
    public string Estado { get; set; } = "activa"; // "activa" | "inactiva"
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string Coordenadas { get; set; } = ""; // serializado
}

public class Factura
{
    public int Id { get; set; }
    public string Numero { get; set; } = "";
    public int CotizacionId { get; set; }
    public int ClienteId { get; set; }
    public string Estado { get; set; } = "activa"; // "activa" | "inactiva"
    public DateTime Fecha { get; set; } = DateTime.Now;
}
}
