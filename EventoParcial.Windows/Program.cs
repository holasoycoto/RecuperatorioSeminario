using EventoParcial.Ioc;
using EventoParcial.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EventoParcial.Windows
{
    internal static class Program
    {
        public static IServiceProvider serviceProvider = null!;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            serviceProvider = DI.ConfigurarDI();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmEventos(serviceProvider.GetRequiredService<IServicioEvento>()));
        }
    }
}