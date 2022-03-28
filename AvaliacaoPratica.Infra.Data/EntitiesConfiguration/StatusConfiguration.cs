using AvaliacaoPratica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AvaliacaoPratica.Infra.Data.EntitiesConfiguration
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();

            builder.HasData(
                new Status(1, "Disponível"),
                new Status(2, "Indisponível"),
                new Status(3, "Vendido")
            );
        }
    }
}