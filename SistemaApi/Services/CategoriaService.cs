using AutoMapper;
using FluentResults;
using SistemaApi.Data;
using SistemaApi.Data.Dtos.Categoria;
using SistemaApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaApi.Services
{
    public class CategoriaService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public CategoriaService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadCategoriaDto AdicionaCategoria(CreateCategoriaDto categoriaDto)
        {
            Categoria categoria = _mapper.Map<Categoria>(categoriaDto);
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return _mapper.Map<ReadCategoriaDto>(categoria);
        }

        public ReadCategoriaDto RecuperaCategoriaPorId(int id)
        {
            Categoria categoria = _context.Categorias.FirstOrDefault(c => c.Id == id);
            if (categoria != null)
            {
                ReadCategoriaDto categoriaDto = _mapper.Map<ReadCategoriaDto>(categoria);
                return categoriaDto;
            }
            return null;
        }

        public List<ReadCategoriaDto> RecuperaCategoria()
        {
            List<Categoria> categorias = _context.Categorias.ToList();
            if (categorias == null)
            {
                return null;
            }
            return _mapper.Map<List<ReadCategoriaDto>>(categorias);
        }

        public Result AtualizaCategoria(int id, UpdateCategoriaDto categoriaDto)
        {
            Categoria categoria = _context.Categorias.FirstOrDefault(c => c.Id == id);
            if (categoria == null) return Result.Fail("Categoria não encontrado");
            _mapper.Map(categoriaDto, categoria);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeletaCategoria(int id)
        {
            Categoria categoria = _context.Categorias.FirstOrDefault(c => c.Id == id);
            if (categoria == null) return Result.Fail("Categoria não encontrado");
            _context.Remove(categoria);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
