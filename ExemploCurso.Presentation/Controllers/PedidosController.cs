using ExemploCurso.Domain.Entidades;
using ExemploCurso.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ExamplosCurso.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        
        private readonly IPedidoService pedidoService;

        public PedidosController(IPedidoService pedidoService)
        {
            this.pedidoService = pedidoService;
        }

        [HttpGet("Todos")]
        public async Task<IEnumerable<Pedido>> TodosAsync()
        {
            return await pedidoService.ObterTodos();
        }


        [HttpGet("Relatorio/v1")]
        public async Task<IEnumerable<Pedido>> Relatorio()
        {
            return await pedidoService.ObterTodos();
        }

        [HttpGet]
        public IActionResult Get()
        {
            decimal imposto = 0.20m;
            var pedido = new Pedido()
            {
                Id = Guid.NewGuid(),
                Imposto = imposto,
                ItemPedidos = new List<ItemPedido>()
                {

                        new ItemPedido()
                        {
                            Id = Guid.NewGuid(),
                            Produto = new Produto()
                            {
                                Id = Guid.NewGuid(),
                                Titulo = "Produto 1",
                                Descricao = "Descricao Produto 1",
                                Preco = 10
                            },
                            Quantidade = 2
                        },
                        new ItemPedido()
                        {
                            Id = Guid.NewGuid(),
                            Produto = new Produto()
                            {
                                Id = Guid.NewGuid(),
                                Titulo = "Produto 2",
                                Descricao= "Descricao Produto 2",
                                Preco = 20
                            },
                            Quantidade = 3
                        }
                }
            };

            return Ok(pedido);
        }
    }
}
