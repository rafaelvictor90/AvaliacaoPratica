using AutoMapper;
using AvaliacaoPratica.Application.DTOs;
using AvaliacaoPratica.Domain.Entities;

namespace AvaliacaoPratica.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Marca, MarcaDTO>().ReverseMap();
            CreateMap<Proprietario, ProprietarioDTO>().ReverseMap();
            CreateMap<Veiculo, VeiculoDTO>().ReverseMap();
            CreateMap<Status, StatusDTO>().ReverseMap();
        }
    }
}
