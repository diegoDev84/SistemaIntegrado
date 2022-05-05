using AutoMapper;
using SistemaApi.Data;
using SistemaApi.Services;
using SistemaApi.Data.Dtos;
using SistemaApi.Models;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public IActionResult AdicionaCliente([FromBody] CreateClienteDto clienteDto)
        {
            ReadClienteDto readDto = _clienteService.AdicionaCliente(clienteDto);
            return CreatedAtAction(nameof(RecuperaClientePorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperaCliente()
        {
            List <ReadClienteDto> readDto = _clienteService.RecuperaCliente();
            if(readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaClientePorId(int id)
        {
            ReadClienteDto readDto = _clienteService.RecuperaClientePorId(id);
            if(readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCliente(int id, [FromBody] UpdateClienteDto clienteDto)
        {
            Result resultado = _clienteService.AtualizaCliente(id, clienteDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaCliente(int id)
        {
            Result resultado = _clienteService.DeletaCliente(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }



    }
}
