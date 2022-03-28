using AvaliacaoPratica.Application.Interfaces;
using AvaliacaoPratica.Application.Mappings;
using AvaliacaoPratica.Application.Services;
using AvaliacaoPratica.Domain.Interfaces;
using AvaliacaoPratica.Infra.Data.Context;
using AvaliacaoPratica.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AvaliacaoPratica.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IMarcaRepository, MarcaRepository>();
            services.AddScoped<IProprietarioRepository, ProprietarioRepository>();
            services.AddScoped<IVeiculoRepository, VeiculoRepository>();
            services.AddScoped<IStatusRepository, StatusRepository>();

            services.AddScoped<IMarcaService, MarcaService>();
            services.AddScoped<IProprietarioService, ProprietarioService>();
            services.AddScoped<IVeiculoService, VeiculoService>();
            services.AddScoped<IStatusService, StatusService>();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}
