namespace Sistema_de_Calculo.MODELOS
{
    public enum TipoPunto { Interno, Externo }

    public class PuntoTerreno
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public TipoPunto Tipo { get; set; } = TipoPunto.Interno;

        public PuntoTerreno() { }
        public PuntoTerreno(double x, double y, double z, TipoPunto tipo = TipoPunto.Interno)
        {
            X = x; Y = y; Z = z; Tipo = tipo;
        }
        public override string ToString() => $"{X};{Y};{Z};{Tipo}";
    }

    public class Terrain
    {
        public int Id { get; set; }
        public List<PuntoTerreno> Coordenadas { get; set; } = new();
        public double VolumenCalculado { get; set; }
        public string MetodoUsado { get; set; } = "Simpson 1/3 doble";
        public DateTime FechaCalculo { get; set; } = DateTime.Now;
    }
}
