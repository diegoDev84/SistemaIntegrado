using AutoMapper;
using SistemaApi.Data.Dtos.Produto;
using SistemaApi.Models;

namespace SistemaApi.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<Produto, ReadProdutoDto>();
            CreateMap<UpdateProdutoDto, Produto>();
        }
            
    }
}
