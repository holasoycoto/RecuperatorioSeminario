using EventoParcial.Datos.Interfaces;
using EventoParcial.Servicios.DTOs.Evento;
using EventoParcial.Servicios.Interfaces;
using EventoParcial.Servicios.Mappers;

namespace EventoParcial.Servicios.Servicios
{

    public class ServicioEvento : IServicioEvento
    {

        private readonly IRepositorioEventos _repositorio;

        public ServicioEvento(IRepositorioEventos repositorio)
        {
            this._repositorio = repositorio;
        }

        public List<EventoListDto> ObtenerEventos()
        {
            var lista = _repositorio.Obtener();
            return EventoMapper.MapearLista(lista);
        }
    }
}
