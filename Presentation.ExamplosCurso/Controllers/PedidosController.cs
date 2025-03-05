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
        public async Task<IActionResult> Get()
        {
            var pedidos = await pedidoService.ObterTodos();
            return Ok(pedidos);
        }
    }
}
