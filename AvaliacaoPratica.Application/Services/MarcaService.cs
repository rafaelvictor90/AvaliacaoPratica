using AutoMapper;
using AvaliacaoPratica.Application.DTOs;
using AvaliacaoPratica.Application.Interfaces;
using AvaliacaoPratica.Domain.Entities;
using AvaliacaoPratica.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Application.Services
{
    public class MarcaService : IMarcaService
    {
        private IMarcaRepository _marcaRepository;
        private readonly IMapper _mapper;

        public MarcaService(IMarcaRepository marcaRepository, IMapper mapper)
        {
            _marcaRepository = marcaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MarcaDTO>> GetMarcas()
        {
            var marcaEntity = await _marcaRepository.GetMarcasAsync();
            return _mapper.Map<IEnumerable<MarcaDTO>>(marcaEntity);
        }
        public async Task<IEnumerable<MarcaDTO>> GetMarcasAtivas()
        {
            var marcaEntity = await _marcaRepository.GetMarcasAtivasAsync();
            return _mapper.Map<IEnumerable<MarcaDTO>>(marcaEntity);
        }

        public async Task<MarcaDTO> GetById(int? id)
        {
            var marcaEntity = await _marcaRepository.GetByIdAsync(id);
            return _mapper.Map<MarcaDTO>(marcaEntity);
        }

        public async Task Add(MarcaDTO marcaDto)
        {
            var marcaEntity = _mapper.Map<Marca>(marcaDto);
            await _marcaRepository.CreateAsync(marcaEntity);
        }

        public async Task Update(MarcaDTO marcaDto)
        {
            var marcaEntity = _mapper.Map<Marca>(marcaDto);
            await _marcaRepository.UpdateAsync(marcaEntity);
        }

        public async Task Remove(int? id)
        {
            await _marcaRepository.RemoveAsync(id);
        }

        public async Task<MarcaDTO> GetByNome(string nome)
        {
            var marcaEntity = await _marcaRepository.GetByNomeAsync(nome);
            return _mapper.Map<MarcaDTO>(marcaEntity);
        }
    }
}
