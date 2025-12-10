using LojaDoSrManoel.Models;

namespace LojaDoSrManoel.Services
{
    public class PackingService : IPackingService
    {
        private readonly List<Caixa> _caixas;


        public PackingService()
        {
            _caixas = new List<Caixa>
{
new Caixa { Id = 1, Nome = "Caixa 1", Altura = 30, Largura = 40, Comprimento = 80 },
new Caixa { Id = 2, Nome = "Caixa 2", Altura = 80, Largura = 50, Comprimento = 40 },
new Caixa { Id = 3, Nome = "Caixa 3", Altura = 50, Largura = 80, Comprimento = 60 }
};
        }


        public PedidoEmpacotado Empacotar(Pedido pedido)
        {
            var resultado = new PedidoEmpacotado { PedidoId = pedido.Id };


            // Estratégia simples: colocar cada produto na menor caixa possível
            foreach (var produto in pedido.Produtos)
            {
                var caixa = _caixas
                .FirstOrDefault(c => produto.Altura <= c.Altura &&
                produto.Largura <= c.Largura &&
                produto.Comprimento <= c.Comprimento);


                if (caixa == null)
                    throw new Exception($"Produto {produto.Nome} não cabe em nenhuma caixa disponível.");


                var caixaExistente = resultado.Caixas.FirstOrDefault(c => c.TipoCaixa == caixa.Nome);
                if (caixaExistente == null)
                {
                    caixaExistente = new CaixaEmpacotada { TipoCaixa = caixa.Nome };
                    resultado.Caixas.Add(caixaExistente);
                }


                caixaExistente.Produtos.Add(produto);
            }


            return resultado;
        }
    }
}
