namespace Sistema_de_Calculo.MODELOS
{
    public class PuntoTerreno
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public PuntoTerreno() { }
        public PuntoTerreno(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
        public override string ToString() => $"{X};{Y};{Z}";
    }

    public class Terreno
    {
        public int Id { get; set; }
        public List<PuntoTerreno> Coordenadas { get; set; } = new();
        public double VolumenCalculado { get; set; }
        public string MetodoUsado { get; set; } = "Simpson 1/3 doble";
        public DateTime FechaCalculo { get; set; } = DateTime.Now;
    }
}
