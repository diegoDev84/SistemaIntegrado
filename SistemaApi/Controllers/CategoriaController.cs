using FluentResults;
using Microsoft.AspNetCore.Mvc;
using SistemaApi.Data.Dtos.Categoria;
using SistemaApi.Services;
using System.Collections.Generic;

namespace SistemaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private CategoriaService _categoriaService;

        public CategoriaController(CategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpPost]
        public IActionResult AdicionaCategoria([FromBody] CreateCategoriaDto categoriaDto)
        {
            ReadCategoriaDto readDto = _categoriaService.AdicionaCategoria(categoriaDto);
            return CreatedAtAction(nameof(RecuperaCategoriaPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperaCategoria()
        {
            List<ReadCategoriaDto> readDto = _categoriaService.RecuperaCategoria();
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCategoriaPorId(int id)
        {
            ReadCategoriaDto readDto = _categoriaService.RecuperaCategoriaPorId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCategoria(int id, [FromBody] UpdateCategoriaDto categoriaDto)
        {
            Result resultado = _categoriaService.AtualizaCategoria(id, categoriaDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaCategoria(int id)
        {
            Result resultado = _categoriaService.DeletaCategoria(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}
