using LojaDoSrManoel.Models;

namespace LojaDoSrManoel.Services
{
    public interface IPackingService
    {
        PedidoEmpacotado Empacotar(Pedido pedido);
    }
}
