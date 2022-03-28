using AvaliacaoPratica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AvaliacaoPratica.Infra.Data.EntitiesConfiguration
{
    public class ProprietarioConfiguration : IEntityTypeConfiguration<Proprietario>
    {
        public void Configure(EntityTypeBuilder<Proprietario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Documento).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Cep).HasMaxLength(9).IsRequired();

            builder.HasIndex(x => x.Documento).IsUnique(true);
        }
    }
}
