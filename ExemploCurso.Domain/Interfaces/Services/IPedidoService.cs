using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploCurso.Domain.Entidades;

namespace ExemploCurso.Domain.Interfaces.Services
{
    public interface IPedidoService
    {
        Task<Pedido?> ObterPorId(Guid id);
        Task<IEnumerable<Pedido>> ObterTodos();
    }
}
