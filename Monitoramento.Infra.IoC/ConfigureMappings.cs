using Microsoft.Extensions.DependencyInjection;
using Monitoramento.Infra.IoC.Mappings;

namespace Monitoramento.Infra.IoC
{
    public abstract class ConfigureMappings
    {
        public static void Configure(IServiceCollection servicesCollection)
        {
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ModelToEntityProfile());
            });

            var mapper = config.CreateMapper();
            servicesCollection.AddSingleton(mapper);
        }
    }
}
