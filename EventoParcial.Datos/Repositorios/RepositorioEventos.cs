using EventoParcial.Datos.Interfaces;
using EventoParcial.Entidades.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EventoParcial.Datos.Repositorios
{
    public class RepositorioEventos : IRepositorioEventos
    {

        private readonly EventosDbContext _dbContext;

        public RepositorioEventos(EventosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Evento> Obtener()
        {
            return _dbContext.Eventos
                .Include(e => e.Salon)
                .AsNoTracking()
                .ToList();
        }

    }
}
