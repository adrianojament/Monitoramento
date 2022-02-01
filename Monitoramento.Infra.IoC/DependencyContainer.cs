using Microsoft.Extensions.DependencyInjection;
using Monitoramento.Application.Services;
using Monitoramento.Domain.Interfaces.Repositories;
using Monitoramento.Domain.Interfaces.Services;
using Monitoramento.Infra.Data.Repositories;

namespace Monitoramento.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Interfaces | Data Repositories
            services.AddScoped<IServidorRepository, ServidorRepository>();
            services.AddScoped<IVideoRepository, VideoRepository>();

            //Application
            services.AddScoped<IServidorService, ServidorService>();

            // AutoMapper
            ConfigureMappings.Configure(services);
        }
    }
}
