using EventoParcial.Servicios.DTOs.Evento;
using EventoParcial.Servicios.Interfaces;
using EventoParcial.Windows.Helpers;

namespace EventoParcial.Windows
{
    public partial class frmEventos : Form
    {

        private readonly IServicioEvento _eventosServicio;
        private List<EventoListDto> _listaEventos;

        public frmEventos(IServicioEvento eventosServicio)
        {
            _eventosServicio = eventosServicio;
            InitializeComponent();
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {

                _listaEventos = _eventosServicio.ObtenerEventos();
                GridHelper.MostrarDatosEnGrilla<EventoListDto>(_listaEventos, dgvDatos);

                txtCantidad.Text = _listaEventos.Count.ToString();


            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
