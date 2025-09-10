using EventoParcial.Entidades.Entidades;
using EventoParcial.Servicios.DTOs.Evento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoParcial.Servicios.Interfaces
{
    public interface IServicioEvento
    {
        List<EventoListDto> ObtenerEventos();
    }
}
