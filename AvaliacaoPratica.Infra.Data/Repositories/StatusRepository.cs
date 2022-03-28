using AvaliacaoPratica.Domain.Entities;
using AvaliacaoPratica.Domain.Interfaces;
using AvaliacaoPratica.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Infra.Data.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        private ApplicationDbContext _statusContext;
        public StatusRepository(ApplicationDbContext context)
        {
            _statusContext = context;
        }

        public async Task<IEnumerable<Status>> GetStatusAsync()
        {
            return await _statusContext.Status.ToListAsync();
        }
    }
}
