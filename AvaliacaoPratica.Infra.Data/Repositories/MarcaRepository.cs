using AvaliacaoPratica.Domain.Entities;
using AvaliacaoPratica.Domain.Interfaces;
using AvaliacaoPratica.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Infra.Data.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        private ApplicationDbContext _marcaContext;
        public MarcaRepository(ApplicationDbContext context)
        {
            _marcaContext = context;
        }

        public async Task<Marca> CreateAsync(Marca marca)
        {
            _marcaContext.Add(marca);
            await _marcaContext.SaveChangesAsync();
            return marca;
        }

        public async Task<Marca> GetByIdAsync(int? id)
        {
            return await _marcaContext.Marcas.FindAsync(id);
        }

        public async Task<Marca> GetByNomeAsync(string nome)
        {
            return await _marcaContext.Marcas.FirstOrDefaultAsync(x=>x.Nome.Equals(nome));
        }

        public async Task<IEnumerable<Marca>> GetMarcasAsync()
        {
            return await _marcaContext.Marcas.ToListAsync();
        }

        public async Task<IEnumerable<Marca>> GetMarcasAtivasAsync()
        {
            return await _marcaContext.Marcas.Where(x => x.Status).ToListAsync();
        }

        public async Task<Marca> RemoveAsync(int? id)
        {
            Marca marca = await _marcaContext.Marcas.FindAsync(id);
            marca.Update(marca.Nome, false);
            _marcaContext.Update(marca);
            await _marcaContext.SaveChangesAsync();
            return marca;
        }

        public async Task<Marca> UpdateAsync(Marca marca)
        {
            _marcaContext.Update(marca);
            await _marcaContext.SaveChangesAsync();
            return marca;
        }
    }
}
