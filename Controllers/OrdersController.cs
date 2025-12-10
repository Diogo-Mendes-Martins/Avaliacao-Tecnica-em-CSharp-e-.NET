namespace LojaDoSrManoel.Controllers
{
    using LojaDoSrManoel.Models;
    using LojaDoSrManoel.Services;
    using Microsoft.AspNetCore.Mvc;


    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IPackingService _packingService;


        public OrdersController(IPackingService packingService)
        {
            _packingService = packingService;
        }


        [HttpPost("empacotar")]
        public ActionResult<List<PedidoEmpacotado>> EmpacotarPedidos([FromBody] List<Pedido> pedidos)
        {
            var resultado = new List<PedidoEmpacotado>();


            foreach (var pedido in pedidos)
                resultado.Add(_packingService.Empacotar(pedido));


            return Ok(resultado);
        }
    }
}
