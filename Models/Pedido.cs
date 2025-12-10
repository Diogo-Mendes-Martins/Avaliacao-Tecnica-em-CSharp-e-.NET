using System.Collections.Generic;

namespace LojaDoSrManoel.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
