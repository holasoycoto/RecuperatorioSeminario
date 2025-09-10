using EventoParcial.Entidades.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EventoParcial.Datos
{
    public class EventosDbContext : DbContext
    {
        public EventosDbContext(DbContextOptions options) : base(options)
        {
        }

        protected EventosDbContext()
        {
        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Salon> Salones { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<TipoEvento> TiposEventos { get; set; }


    }
}
