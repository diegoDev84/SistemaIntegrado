using Microsoft.EntityFrameworkCore;
using SistemaApi.Models;

namespace SistemaApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //usar isso quando for vincular uma entidade a outra: um cinema tem tal filme.
        //}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Complemento> Complementos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
   
}
