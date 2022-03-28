using AvaliacaoPratica.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AvaliacaoPratica.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
