using Microsoft.EntityFrameworkCore;
using LojaDoSrManoel.Models;

namespace LojaDoSrManoel.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Caixa> Caixas { get; set; }
    }
}
