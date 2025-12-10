namespace LojaDoSrManoel.Models
{
    public class PedidoEmpacotado
    {
        public int PedidoId { get; set; }
        public List<CaixaEmpacotada> Caixas { get; set; } = new();
    }


    public class CaixaEmpacotada
    {
        public string TipoCaixa { get; set; }
        public List<Produto> Produtos { get; set; } = new();
    }
}