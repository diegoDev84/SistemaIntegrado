using FluentResults;
using Microsoft.AspNetCore.Mvc;
using SistemaApi.Data.Dtos.Empresa;
using SistemaApi.Services;

namespace SistemaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : ControllerBase
    {
        private EmpresaService _empresaService;

        public EmpresaController(EmpresaService empresaService)
        {
            _empresaService = empresaService;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEmpresaPorId(int id)
        {
            ReadEmpresaDto readDto = _empresaService.RecuperaEmpresaPorId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEmpresa(int id, [FromBody] UpdateEmpresaDto empresaDto)
        {
            Result resultado = _empresaService.AtualizaEmpresa(id, empresaDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}