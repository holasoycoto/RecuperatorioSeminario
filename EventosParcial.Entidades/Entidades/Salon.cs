namespace EventoParcial.Entidades.Entidades
{
    public class Salon
    {

        public int SalonId { get; set; }
        public string? NombreSalon { get; set; } = null!;
        public int Capacidad { get; set; }
        public string? Direccion { get; set; } = null!;
        public int LocalidadId { get; set; }
        public Localidad? Localidad { get; set; }


    }
}
