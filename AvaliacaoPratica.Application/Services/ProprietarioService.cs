using AutoMapper;
using AvaliacaoPratica.Application.DTOs;
using AvaliacaoPratica.Application.Interfaces;
using AvaliacaoPratica.Domain.Entities;
using AvaliacaoPratica.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoPratica.Application.Services
{
    public class ProprietarioService : IProprietarioService
    {
        private IProprietarioRepository _proprietarioRepository;
        private readonly IMapper _mapper;

        public ProprietarioService(IProprietarioRepository proprietarioRepository, IMapper mapper)
        {
            _proprietarioRepository = proprietarioRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProprietarioDTO>> GetProprietarios()
        {
            var proprietarioEntity = await _proprietarioRepository.GetProprietaiosAsync();
            return _mapper.Map<IEnumerable<ProprietarioDTO>>(proprietarioEntity);
        }
        public async Task<IEnumerable<ProprietarioDTO>> GetProprietariosAtivos()
        {
            var proprietarioEntity = await _proprietarioRepository.GetProprietaiosAtivosAsync();
            return _mapper.Map<IEnumerable<ProprietarioDTO>>(proprietarioEntity);
        }

        public async Task<ProprietarioDTO> GetById(int? id)
        {
            var proprietarioEntity = await _proprietarioRepository.GetByIdAsync(id);
            return _mapper.Map<ProprietarioDTO>(proprietarioEntity);
        }

        public async Task Add(ProprietarioDTO proprietarioDto)
        {
            var proprietarioEntity = _mapper.Map<Proprietario>(proprietarioDto);
            await _proprietarioRepository.CreateAsync(proprietarioEntity);
        }

        public async Task Update(ProprietarioDTO proprietarioDto)
        {
            var proprietarioEntity = _mapper.Map<Proprietario>(proprietarioDto);
            await _proprietarioRepository.UpdateAsync(proprietarioEntity);
        }

        public async Task Remove(int? id)
        {
            await _proprietarioRepository.RemoveAsync(id);
        }

        public async Task<ProprietarioDTO> GetByDocumento(string documento)
        {
            var proprietarioEntity = await _proprietarioRepository.GetByDocumentoAsync(documento);
            return _mapper.Map<ProprietarioDTO>(proprietarioEntity);
        }
    }
}
