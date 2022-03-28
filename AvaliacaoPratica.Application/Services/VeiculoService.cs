using AutoMapper;
using AvaliacaoPratica.Application.DTOs;
using AvaliacaoPratica.Application.Interfaces;
using AvaliacaoPratica.Domain.Entities;
using AvaliacaoPratica.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Application.Services
{
    public class VeiculoService : IVeiculoService
    {
        private IVeiculoRepository _veiculoRepository;
        private readonly IMapper _mapper;

        public VeiculoService(IVeiculoRepository veiculoRepository, IMapper mapper)
        {
            _veiculoRepository = veiculoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VeiculoDTO>> GetVeiculos()
        {
            var veiculoEntity = await _veiculoRepository.GetVeiculosAsync();
            return _mapper.Map<IEnumerable<VeiculoDTO>>(veiculoEntity);
        }

        public async Task<VeiculoDTO> GetById(int? id)
        {
            var veiculoEntity = await _veiculoRepository.GetByIdAsync(id);
            return _mapper.Map<VeiculoDTO>(veiculoEntity);
        }

        public async Task<VeiculoDTO> GetByRenavam(string renavam)
        {
            var veiculoEntity = await _veiculoRepository.GetByRenavamAsync(renavam);
            return _mapper.Map<VeiculoDTO>(veiculoEntity);
        }

        public async Task Add(VeiculoDTO veiculoDto)
        {
            var veiculoEntity = _mapper.Map<Veiculo>(veiculoDto);
            await _veiculoRepository.CreateAsync(veiculoEntity);
        }

        public async Task Update(VeiculoDTO veiculoDto)
        {
            var veiculoEntity = _mapper.Map<Veiculo>(veiculoDto);
            await _veiculoRepository.UpdateAsync(veiculoEntity);
        }
    }
}
