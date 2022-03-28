using AvaliacaoPratica.Domain.Entities;
using AvaliacaoPratica.Domain.Interfaces;
using AvaliacaoPratica.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Infra.Data.Repositories
{
    public class ProprietarioRepository : IProprietarioRepository
    {
        ApplicationDbContext _proprietarioContext;

        public ProprietarioRepository(ApplicationDbContext context)
        {
            _proprietarioContext = context;
        }

        public async Task<Proprietario> CreateAsync(Proprietario proprietario)
        {
            _proprietarioContext.Add(proprietario);
            await _proprietarioContext.SaveChangesAsync();
            return proprietario;
        }

        public async Task<Proprietario> GetByDocumentoAsync(string documento)
        {
            return await _proprietarioContext.Proprietarios.FirstOrDefaultAsync(x => x.Documento.Equals(documento));
        }

        public async Task<Proprietario> GetByIdAsync(int? id)
        {
            return await _proprietarioContext.Proprietarios.FindAsync(id);
        }

        public async Task<IEnumerable<Proprietario>> GetProprietaiosAsync()
        {
            return await _proprietarioContext.Proprietarios.ToListAsync();
        }

        public async Task<IEnumerable<Proprietario>> GetProprietaiosAtivosAsync()
        {
            return await _proprietarioContext.Proprietarios.Where(x => x.Status).ToListAsync();
        }

        public async Task<Proprietario> RemoveAsync(int? id)
        {
            Proprietario proprietario = await _proprietarioContext.Proprietarios.FindAsync(id);
            proprietario.Update(proprietario.Nome, proprietario.Documento, proprietario.Email, proprietario.Cep, false);
            _proprietarioContext.Update(proprietario);
            await _proprietarioContext.SaveChangesAsync();
            return proprietario;
        }

        public async Task<Proprietario> UpdateAsync(Proprietario proprietario)
        {
            _proprietarioContext.Update(proprietario);
            _proprietarioContext.SaveChanges();
            return proprietario;
        }
    }
}
