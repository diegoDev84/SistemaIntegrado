using AutoMapper;
using FluentResults;
using SistemaApi.Data;
using SistemaApi.Data.Dtos;
using SistemaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaApi.Services
{
    public class ClienteService
    {

        private AppDbContext _context;
        private IMapper _mapper;

        public ClienteService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadClienteDto AdicionaCliente(CreateClienteDto clienteDto)
        {
            Cliente cliente = _mapper.Map<Cliente>(clienteDto);
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return _mapper.Map<ReadClienteDto>(cliente);
        }

        public List<ReadClienteDto> RecuperaCliente()
        {
            List<Cliente> clientes = _context.Clientes.ToList();
            if (clientes == null)
            {
                return null;
            }
            return _mapper.Map<List<ReadClienteDto>>(clientes);
        }

        public ReadClienteDto RecuperaClientePorId(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if(cliente != null)
            {
                ReadClienteDto clienteDto = _mapper.Map<ReadClienteDto>(cliente);
                return clienteDto;
            }
            return null;
        }
        

        public Result AtualizaCliente(int id, UpdateClienteDto clienteDto)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null) return Result.Fail("Cliente não encontrado");
            _mapper.Map(clienteDto, cliente);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeletaCliente(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null) return Result.Fail("Cliente não encontrado");
            _context.Remove(cliente);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
