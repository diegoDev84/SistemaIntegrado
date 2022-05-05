using AutoMapper;
using FluentResults;
using SistemaApi.Data;
using SistemaApi.Data.Dtos.Produto;
using SistemaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaApi.Services
{
    public class ProdutoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public ProdutoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadProdutoDto AdicionaProduto(CreateProdutoDto produtoDto)
        {
            Produto produto = _mapper.Map<Produto>(produtoDto);
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return _mapper.Map<ReadProdutoDto>(produto);
        }

        public ReadProdutoDto RecuperaProdutoPorId(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(c => c.Id == id);
            if (produto != null)
            {
                ReadProdutoDto produtoDto = _mapper.Map<ReadProdutoDto>(produto);
                return produtoDto;
            }
            return null;
        }

        public List<ReadProdutoDto> RecuperaProduto()
        {
            List<Produto> produtos= _context.Produtos.ToList();
            if (produtos == null)
            {
                return null;
            }
            return _mapper.Map<List<ReadProdutoDto>>(produtos);
        }

        public Result AtualizaProduto(int id, UpdateProdutoDto produtoDto)
        {
            Produto produto = _context.Produtos.FirstOrDefault(c => c.Id == id);
            if (produto == null) return Result.Fail("Produto não encontrado");
            _mapper.Map(produtoDto, produto);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeletaProduto(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(c => c.Id == id);
            if (produto == null) return Result.Fail("Produto não encontrado");
            _context.Remove(produto);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
