using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monitoramento.Domain.Entities;

namespace Monitoramento.Infra.Data.Mapping
{
    public class ServidorMapping : IEntityTypeConfiguration<ServidorEntity>
    {
        public void Configure(EntityTypeBuilder<ServidorEntity> builder)
        {
            builder.ToTable("servidores");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome).IsRequired().HasMaxLength(100);
            builder.Property(u => u.IP_Endereco).IsRequired().HasMaxLength(100);
            builder.Property(u => u.IP_Porta).IsRequired();
        }
    }
}
