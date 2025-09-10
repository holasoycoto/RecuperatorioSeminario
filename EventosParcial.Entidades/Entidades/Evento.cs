namespace EventoParcial.Entidades.Entidades
{
    public class Evento
    {

        public int EventoId { get; set; }
        public string? NombreEvento { get; set; } = null!;
        public int CantidadPersonas { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoEventoId { get; set; }
        public int SalonId { get; set; }
        public TipoEvento? TipoEvento { get; set; }
        public Salon? Salon { get; set; }
        public bool Suspendido { get; set; }

    }
}
