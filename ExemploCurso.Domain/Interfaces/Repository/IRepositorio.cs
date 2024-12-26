using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploCurso.Domain.Entidades;

namespace ExemploCurso.Domain.Interfaces.Repository
{
    public interface IRepositorio<T> : IDisposable where T : EntidadeBasica
    {

        Task<T?> ObterPeloId(Guid id);        
        Task<IEnumerable<T>> ObterTodos();

        void Adicionar(T item);
        void Atualizar(T item);
        void Remover(T item);

        IUnitOfWork UnitOfWork { get; }
    }
}
