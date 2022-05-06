using AutoMapper;
using FluentResults;
using SistemaApi.Data;
using SistemaApi.Data.Dtos.Empresa;
using SistemaApi.Models;
using System.Linq;

namespace SistemaApi.Services
{
    public class EmpresaService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public EmpresaService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadEmpresaDto RecuperaEmpresaPorId(int id)
        {
            DadosEmpresa empresa = _context.Empresa.FirstOrDefault(c => c.Id == id);
            if (empresa != null)
            {
                ReadEmpresaDto empresaDto = _mapper.Map<ReadEmpresaDto>(empresa);
                return empresaDto;
            }
            return null;
        }

       public Result AtualizaEmpresa(int id, UpdateEmpresaDto empresaDto)
        {
            DadosEmpresa empresa = _context.Empresa.FirstOrDefault(c => c.Id == id);
            if (empresa == null) return Result.Fail("Empresa não encontrada");
            _mapper.Map(empresaDto, empresa);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}