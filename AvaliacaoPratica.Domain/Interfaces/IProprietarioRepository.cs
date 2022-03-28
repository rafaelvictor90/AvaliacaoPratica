using AvaliacaoPratica.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Domain.Interfaces
{
    public interface IProprietarioRepository
    {
        Task<IEnumerable<Proprietario>> GetProprietaiosAsync();
        Task<IEnumerable<Proprietario>> GetProprietaiosAtivosAsync();
        Task<Proprietario> GetByIdAsync(int? id);
        Task<Proprietario> GetByDocumentoAsync(string documento);

        Task<Proprietario> CreateAsync(Proprietario proprietario);
        Task<Proprietario> UpdateAsync(Proprietario proprietario);
        Task<Proprietario> RemoveAsync(int? id);
    }
}
