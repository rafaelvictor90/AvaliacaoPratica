using AvaliacaoPratica.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Domain.Interfaces
{
    public interface IVeiculoRepository
    {
        Task<IEnumerable<Veiculo>> GetVeiculosAsync();
        Task<Veiculo> GetByIdAsync(int? id);
        Task<Veiculo> GetByRenavamAsync(string renavam);

        Task<Veiculo> CreateAsync(Veiculo veiculo);
        Task<Veiculo> UpdateAsync(Veiculo veiculo);
    }
}
