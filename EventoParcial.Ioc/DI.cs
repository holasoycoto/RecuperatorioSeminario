using EventoParcial.Datos;
using EventoParcial.Datos.Interfaces;
using EventoParcial.Datos.Repositorios;
using EventoParcial.Servicios.Interfaces;
using EventoParcial.Servicios.Servicios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoParcial.Ioc
{
    public static class DI
    {

        public static IServiceProvider ConfigurarDI()
        {

            var services = new ServiceCollection();

            services.AddDbContext<EventosDbContext>(options =>
            {
                options.UseSqlServer(ConfigurationManager
                    .ConnectionStrings["ConexionSQL"].ConnectionString);
            });

            //Repositorios
            services.AddScoped<IRepositorioEventos, RepositorioEventos>();

            //Servicios
            services.AddScoped<IServicioEvento, ServicioEvento>();

            return services.BuildServiceProvider();

        }

    }
}
