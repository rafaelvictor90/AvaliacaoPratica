using AvaliacaoPratica.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Domain.Interfaces
{
    public interface IStatusRepository
    {
        Task<IEnumerable<Status>> GetStatusAsync();
    }
}
