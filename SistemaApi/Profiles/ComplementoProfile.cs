using AutoMapper;
using SistemaApi.Data.Dtos.Complemento;
using SistemaApi.Models;

namespace SistemaApi.Profiles
{
    public class ComplementoProfile : Profile
    {
        public ComplementoProfile()
        {
            CreateMap<CreateComplementoDto, Complemento>();
            CreateMap<Complemento, ReadComplementoDto>();
            CreateMap<UpdateComplementoDto, Complemento>();
        }

    }
}
