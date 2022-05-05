﻿using AutoMapper;
using SistemaApi.Data.Dtos.Pedido;
using SistemaApi.Models;

namespace SistemaApi.Profiles
{
    public class PedidoProfile : Profile
    {
        public PedidoProfile()
        {
            CreateMap<CreatePedidoDto, Pedido>();
            CreateMap<Pedido, ReadPedidoDto>();
            CreateMap<UpdatePedidoDto, Pedido>();
        }

    }
}
