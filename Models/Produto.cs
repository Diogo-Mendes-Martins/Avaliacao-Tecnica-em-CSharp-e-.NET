using LojaDoSrManoel.Models;

namespace LojaDoSrManoel.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } /*= string.Empty;*/
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }
        /*
        public int PedidoId { get; set; } // FK para Pedido
        public Pedido? Pedido { get; set; }
        */
    }
}
