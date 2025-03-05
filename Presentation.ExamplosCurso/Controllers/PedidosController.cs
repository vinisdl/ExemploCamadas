using ExemploCurso.Domain.Entidades;
using ExemploCurso.Domain.Interfaces.Services;
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

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pedidos = await pedidoService.ObterTodos();
            return Ok(pedidos);
        }
    }
}
