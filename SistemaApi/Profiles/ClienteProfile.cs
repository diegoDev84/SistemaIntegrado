using AutoMapper;
using SistemaApi.Data.Dtos;
using SistemaApi.Models;
using System.Linq;

namespace SistemaApi.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDto, Cliente>();
            CreateMap<Cliente, ReadClienteDto>()
                .ForMember(cliente => cliente.Pedidos, opts => opts
                .MapFrom(cliente => cliente.Pedidos.Select
                (p => new { p.DataPedido, p.TipoPedido, p.ValorTotal })));
            CreateMap<UpdateClienteDto, Cliente>();
        }
        
    }
}
