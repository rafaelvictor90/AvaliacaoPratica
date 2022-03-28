using AvaliacaoPratica.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Application.Interfaces
{
    public interface IProprietarioService
    {
        Task<IEnumerable<ProprietarioDTO>> GetProprietarios();
        Task<IEnumerable<ProprietarioDTO>> GetProprietariosAtivos();
        Task<ProprietarioDTO> GetById(int? id);
        Task<ProprietarioDTO> GetByDocumento(string documento);
        Task Add(ProprietarioDTO proprietarioDto);
        Task Update(ProprietarioDTO proprietarioDto);
        Task Remove(int? id);
    }
}
