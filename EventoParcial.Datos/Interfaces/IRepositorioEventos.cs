using EventoParcial.Entidades.Entidades;


namespace EventoParcial.Datos.Interfaces
{
    public interface IRepositorioEventos
    {
        List<Evento> Obtener();
    }
}
