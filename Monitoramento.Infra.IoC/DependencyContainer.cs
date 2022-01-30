using Microsoft.Extensions.DependencyInjection;
using Monitoramento.Application.Interfaces;
using Monitoramento.Application.Services;
using Monitoramento.Domain.Interfaces;
using Monitoramento.Infra.Data.Repositories;

namespace Monitoramento.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application
            services.AddScoped<IServidorService, ServidorService>();

            // Domain Interfaces | Data Repositories
            services.AddScoped<IServidorRepository, ServidorRepository>();

            // AutoMapper
            ConfigureMappings.Configure(services);
        }
    }
}
