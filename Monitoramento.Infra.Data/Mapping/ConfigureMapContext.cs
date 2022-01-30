using Microsoft.EntityFrameworkCore;
using Monitoramento.Domain.Entities;

namespace Monitoramento.Infra.Data.Mapping
{
    public abstract class ConfigureMapContext
    {
        public static void ConfigureMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServidorEntity>(new ServidorMapping().Configure);
            modelBuilder.Entity<VideoEntity>(new VideoMapping().Configure);
        }
    }
}
