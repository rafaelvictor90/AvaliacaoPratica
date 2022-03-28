using AvaliacaoPratica.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Application.Interfaces
{
    public interface IStatusService
    {
        Task<IEnumerable<StatusDTO>> GetStatus();
    }
}
