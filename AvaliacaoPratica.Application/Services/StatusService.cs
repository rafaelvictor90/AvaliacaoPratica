using AutoMapper;
using AvaliacaoPratica.Application.DTOs;
using AvaliacaoPratica.Application.Interfaces;
using AvaliacaoPratica.Domain.Entities;
using AvaliacaoPratica.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Application.Services
{
    public class StatusService : IStatusService
    {
        private IStatusRepository _statusRepository;
        private readonly IMapper _mapper;

        public StatusService(IStatusRepository statusRepository, IMapper mapper)
        {
            _statusRepository = statusRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StatusDTO>> GetStatus()
        {
            var statusEntity = await _statusRepository.GetStatusAsync();
            return _mapper.Map<IEnumerable<StatusDTO>>(statusEntity);
        }
    }
}
