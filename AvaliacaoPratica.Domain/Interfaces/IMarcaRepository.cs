using AvaliacaoPratica.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Domain.Interfaces
{
    public interface IMarcaRepository
    {
        Task<IEnumerable<Marca>> GetMarcasAsync();
        Task<IEnumerable<Marca>> GetMarcasAtivasAsync();
        Task<Marca> GetByIdAsync(int? id);
        Task<Marca> GetByNomeAsync(string nome);

        Task<Marca> CreateAsync(Marca marca);
        Task<Marca> UpdateAsync(Marca marca);
        Task<Marca> RemoveAsync(int? id);
    }
}
