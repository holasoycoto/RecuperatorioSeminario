using EventoParcial.Servicios.DTOs.Evento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoParcial.Servicios.DTOs.Evento
{
    public class EventoListDto
    {
        public int EventoId { get; set; }
        public string? NombreEvento { get; set; } = null!;
        public int CantidadPersonas { get; set; }
        public DateTime Fecha { get; set; }
        public string? Salon { get; set; } = null!;
        public bool Suspendido { get; set; }

    }
}
