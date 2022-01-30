using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monitoramento.Domain.Entities;

namespace Monitoramento.Infra.Data.Mapping
{
    public class VideoMapping : IEntityTypeConfiguration<VideoEntity>
    {
        public void Configure(EntityTypeBuilder<VideoEntity> builder)
        {
            builder.ToTable("videos");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Descricao).IsRequired().HasMaxLength(200);
            builder.HasOne(u => u.Servidor).WithMany(m => m.Videos);
        }
    }
}
