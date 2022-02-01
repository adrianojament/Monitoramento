using Microsoft.EntityFrameworkCore;
using Monitoramento.Domain.Entities;
using Monitoramento.Infra.Data.Mapping;

namespace Monitoramento.Infra.Data.Context
{
    public class MonitoramentoContexto : DbContext
    {

        public MonitoramentoContexto(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureMapContext.ConfigureMap(modelBuilder);
        }

        public DbSet<ServidorEntity> Servidores { get; set; }
        public DbSet<VideoEntity> Videos { get; set; }
    }
}
