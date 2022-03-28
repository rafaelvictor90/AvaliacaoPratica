using AvaliacaoPratica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AvaliacaoPratica.Infra.Data.EntitiesConfiguration
{
    public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Renavam).HasMaxLength(11).IsRequired();
            builder.HasIndex(x => x.Renavam).IsUnique(true);
            builder.Property(x => x.Modelo).HasMaxLength(100).IsRequired();
            builder.Property(x => x.AnoFabricacao).IsRequired();
            builder.Property(x => x.AnoModelo).IsRequired();
            builder.Property(x => x.Quilometragem).IsRequired();
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.Quilometragem).IsRequired();
            builder.Property(x => x.StatusId).IsRequired();
            builder.Property(x => x.MarcaId).IsRequired();
            builder.Property(x => x.ProprietarioId).IsRequired();

            //builder.HasOne(x => x.Marca).WithMany(x => x.Veiculos).HasForeignKey(x => x.MarcaId);
            builder.HasOne(x => x.Proprietario).WithMany(x => x.Veiculos).HasForeignKey(x => x.ProprietarioId);
        }
    }
}
