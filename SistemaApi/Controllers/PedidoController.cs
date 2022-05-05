using FluentResults;
using Microsoft.AspNetCore.Mvc;
using SistemaApi.Data.Dtos.Pedido;
using SistemaApi.Services;
using System.Collections.Generic;

namespace SistemaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private PedidoService _pedidoService;

        public PedidoController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost]
        public IActionResult AdicionaPedido([FromBody] CreatePedidoDto pedidoDto)
        {
            ReadPedidoDto readDto = _pedidoService.AdicionaPedido(pedidoDto);
            return CreatedAtAction(nameof(RecuperaPedidoPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperaPedido()
        {
            List<ReadPedidoDto> readDto = _pedidoService.RecuperaPedido();
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPedidoPorId(int id)
        {
            ReadPedidoDto readDto = _pedidoService.RecuperaPedidoPorId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPedido(int id, [FromBody] UpdatePedidoDto pedidoDto)
        {
            Result resultado = _pedidoService.AtualizaPedido(id, pedidoDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaPedido(int id)
        {
            Result resultado = _pedidoService.DeletaPedido(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }



    }
}