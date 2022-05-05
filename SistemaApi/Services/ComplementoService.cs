using AutoMapper;
using FluentResults;
using SistemaApi.Data;
using SistemaApi.Data.Dtos.Complemento;
using SistemaApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaApi.Services
{
    public class ComplementoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public ComplementoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadComplementoDto AdicionaComplemento(CreateComplementoDto complementoDto)
        {
            Complemento complemento = _mapper.Map<Complemento>(complementoDto);
            _context.Complementos.Add(complemento);
            _context.SaveChanges();
            return _mapper.Map<ReadComplementoDto>(complemento);
        }

        public ReadComplementoDto RecuperaComplementoPorId(int id)
        {
            Complemento complemento = _context.Complementos.FirstOrDefault(c => c.Id == id);
            if (complemento != null)
            {
                ReadComplementoDto complementoDto = _mapper.Map<ReadComplementoDto>(complemento);
                return complementoDto;
            }
            return null;
        }

        public List<ReadComplementoDto> RecuperaComplemento()
        {
            List<Complemento> complementos = _context.Complementos.ToList();
            if (complementos == null)
            {
                return null;
            }
            return _mapper.Map<List<ReadComplementoDto>>(complementos);
        }

        public Result AtualizaComplemento(int id, UpdateComplementoDto complementoDto)
        {
            Complemento complemento = _context.Complementos.FirstOrDefault(c => c.Id == id);
            if (complemento == null) return Result.Fail("Complemento não encontrado");
            _mapper.Map(complementoDto, complemento);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeletaComplemento(int id)
        {
            Complemento complemento = _context.Complementos.FirstOrDefault(c => c.Id == id);
            if (complemento == null) return Result.Fail("Complemento não encontrado");
            _context.Remove(complemento);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
