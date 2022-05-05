using AutoMapper;
using FluentResults;
using SistemaApi.Data;
using SistemaApi.Data.Dtos.Pedido;
using SistemaApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaApi.Services
{
    public class PedidoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public PedidoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadPedidoDto AdicionaPedido(CreatePedidoDto pedidoDto)
        {
            Pedido pedido = _mapper.Map<Pedido>(pedidoDto);
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            return _mapper.Map<ReadPedidoDto>(pedido);
        }

        public List<ReadPedidoDto> RecuperaPedido()
        {
            List<Pedido> pedidos = _context.Pedidos.ToList();
            if (pedidos == null)
            {
                return null;
            }
            return _mapper.Map<List<ReadPedidoDto>>(pedidos);
        }

        public ReadPedidoDto RecuperaPedidoPorId(int id)
        {
            Pedido pedido = _context.Pedidos.FirstOrDefault(p => p.Id == id);
            if (pedido != null)
            {
                ReadPedidoDto pedidoDto = _mapper.Map<ReadPedidoDto>(pedido);
                return pedidoDto;
            }
            return null;
        }

        public Result AtualizaPedido(int id, UpdatePedidoDto pedidoDto)
        {
            Pedido pedido = _context.Pedidos.FirstOrDefault(p => p.Id == id);
            if (pedido == null) return Result.Fail("Pedido não encontrado");
            _mapper.Map(pedidoDto, pedido);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeletaPedido(int id)
        {
            Pedido pedido = _context.Pedidos.FirstOrDefault(p => p.Id == id);
            if (pedido == null) return Result.Fail("Pedido não encontrado");
            _context.Remove(pedido);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
