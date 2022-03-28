using AvaliacaoPratica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AvaliacaoPratica.Infra.Data.EntitiesConfiguration
{
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.HasIndex(x => x.Nome).IsUnique(true);
        }
    }
}
