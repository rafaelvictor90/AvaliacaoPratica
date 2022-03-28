using AvaliacaoPratica.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Application.Interfaces
{
    public interface IVeiculoService
    {
        Task<IEnumerable<VeiculoDTO>> GetVeiculos();
        Task<VeiculoDTO> GetById(int? id);
        Task<VeiculoDTO> GetByRenavam(string renavam);
        Task Add(VeiculoDTO veiculoDto);
        Task Update(VeiculoDTO veiculoDto);
    }
}
