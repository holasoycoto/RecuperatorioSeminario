using EventoParcial.Entidades.Entidades;
using EventoParcial.Servicios.DTOs.Evento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoParcial.Servicios.Mappers
{
    public static class EventoMapper
    {

        public static EventoListDto MapearListDTO(Evento evento)
        {
            return new EventoListDto
            {
                EventoId = evento.EventoId,
                NombreEvento = evento.NombreEvento,
                CantidadPersonas = evento.CantidadPersonas,
                Fecha = evento.Fecha,
                Salon = evento.Salon?.NombreSalon ?? "Desconocido",
                Suspendido = evento.Suspendido
            };
        }

        public static List<EventoListDto> MapearLista(List<Evento> eventos)
        {
            return eventos.Select(MapearListDTO).ToList();
        }

    }
}
