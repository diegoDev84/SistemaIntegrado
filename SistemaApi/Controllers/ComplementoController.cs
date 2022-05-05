using FluentResults;
using Microsoft.AspNetCore.Mvc;
using SistemaApi.Data.Dtos.Complemento;
using SistemaApi.Services;
using System.Collections.Generic;

namespace SistemaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComplementoController : ControllerBase
    {
        private ComplementoService _complementoService;

        public ComplementoController(ComplementoService complementoService)
        {
            _complementoService = complementoService;
        }

        [HttpPost]
        public IActionResult AdicionaComplemento([FromBody] CreateComplementoDto complementoDto)
        {
            ReadComplementoDto readDto = _complementoService.AdicionaComplemento(complementoDto);
            return CreatedAtAction(nameof(RecuperaComplementoPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperaComplemento()
        {
            List<ReadComplementoDto> readDto = _complementoService.RecuperaComplemento();
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaComplementoPorId(int id)
        {
            ReadComplementoDto readDto = _complementoService.RecuperaComplementoPorId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaComplemento(int id, [FromBody] UpdateComplementoDto complementoDto)
        {
            Result resultado = _complementoService.AtualizaComplemento(id, complementoDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaComplemento(int id)
        {
            Result resultado = _complementoService.DeletaComplemento(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }

    }
}
