using ExemploCurso.Domain.Entidades;
using ExemploCurso.Domain.Interfaces.Repository;
using ExemploCurso.Domain.Interfaces.Services;

namespace ExemploCurso.Application.Servicos
{
    public class PedidoService : IPedidoService
    {
        
        private readonly IPedidoRepositorio pedidoRepositorio;

        public PedidoService(IPedidoRepositorio pedidoRepositorio)
        {

            this.pedidoRepositorio = pedidoRepositorio;
        }

        public async Task<Pedido?> ObterPorId(Guid id)
        {            
            return await pedidoRepositorio.ObterPeloId(id);
        }

        public async Task<IEnumerable<Pedido>> ObterTodos()
        {
            return await pedidoRepositorio.ObterTodos();
        }
    }
}
