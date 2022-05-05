using FluentResults;
using Microsoft.AspNetCore.Mvc;
using SistemaApi.Data.Dtos.Produto;
using SistemaApi.Services;
using System.Collections.Generic;

namespace SistemaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        public IActionResult AdicionaProduto([FromBody] CreateProdutoDto produtoDto)
        {
            ReadProdutoDto readDto = _produtoService.AdicionaProduto(produtoDto);
            return CreatedAtAction(nameof(RecuperaProdutoPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperaProduto()
        {
            List<ReadProdutoDto> readDto = _produtoService.RecuperaProduto();
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaProdutoPorId(int id)
        {
            ReadProdutoDto readDto = _produtoService.RecuperaProdutoPorId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaProduto(int id, [FromBody] UpdateProdutoDto produtoDto)
        {
            Result resultado = _produtoService.AtualizaProduto(id, produtoDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaProduto(int id)
        {
            Result resultado = _produtoService.DeletaProduto(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}