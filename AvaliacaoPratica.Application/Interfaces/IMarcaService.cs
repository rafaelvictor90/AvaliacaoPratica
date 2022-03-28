using AvaliacaoPratica.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Application.Interfaces
{
    public interface IMarcaService
    {
        Task<IEnumerable<MarcaDTO>> GetMarcas();
        Task<IEnumerable<MarcaDTO>> GetMarcasAtivas();
        Task<MarcaDTO> GetById(int? id);
        Task<MarcaDTO> GetByNome(string nome);
        Task Add(MarcaDTO marcaDto);
        Task Update(MarcaDTO marcaDto);
        Task Remove(int? id);
    }
}
