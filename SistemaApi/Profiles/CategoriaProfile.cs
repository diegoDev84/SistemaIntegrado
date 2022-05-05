using AutoMapper;
using SistemaApi.Data.Dtos.Categoria;
using SistemaApi.Models;

namespace SistemaApi.Profiles
{
    public class CategoriaProfile : Profile
    {
        public CategoriaProfile()
        {
            CreateMap<CreateCategoriaDto, Categoria>();
            CreateMap<Categoria, ReadCategoriaDto>();
            CreateMap<UpdateCategoriaDto, Categoria>();
        }
    }
}
