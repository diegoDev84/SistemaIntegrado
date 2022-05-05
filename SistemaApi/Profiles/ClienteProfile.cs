using AutoMapper;
using SistemaApi.Data.Dtos;
using SistemaApi.Models;

namespace SistemaApi.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDto, Cliente>();
            CreateMap<Cliente, ReadClienteDto>();
            CreateMap<UpdateClienteDto, Cliente>();
        }
        
    }
}
