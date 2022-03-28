using AvaliacaoPratica.Domain.Entities;
using AvaliacaoPratica.Domain.Interfaces;
using AvaliacaoPratica.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Infra.Data.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        ApplicationDbContext _veiculoContext;

        public VeiculoRepository(ApplicationDbContext context)
        {
            _veiculoContext = context;
        }

        public async Task<Veiculo> CreateAsync(Veiculo veiculo)
        {
            _veiculoContext.Add(veiculo);
            await _veiculoContext.SaveChangesAsync();
            return veiculo;
        }

        public async Task<Veiculo> GetByIdAsync(int? id)
        {
            return await _veiculoContext.Veiculos.Include(x => x.Marca).Include(x => x.Proprietario).Include(x => x.Status).FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task<Veiculo> GetByRenavamAsync(string renavam)
        {
            return await _veiculoContext.Veiculos.FirstOrDefaultAsync(x=>x.Renavam.Equals(renavam));
        }

        public async Task<IEnumerable<Veiculo>> GetVeiculosAsync()
        {
            return await _veiculoContext.Veiculos.Include(x=>x.Marca).Include(x=>x.Proprietario).Include(x=>x.Status).ToListAsync();
        }

        public async Task<Veiculo> UpdateAsync(Veiculo veiculo)
        {
            _veiculoContext.Update(veiculo);
            await _veiculoContext.SaveChangesAsync();
            return veiculo;
        }

    }
}
