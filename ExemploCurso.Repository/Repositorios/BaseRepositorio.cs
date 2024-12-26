using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploCurso.Domain.Entidades;
using ExemploCurso.Domain.Interfaces.Repository;
using ExemploCurso.Repository.Contexto;
using Microsoft.EntityFrameworkCore;

namespace ExemploCurso.Repository.Repositorios
{
    public class BaseRepositorio<T> : IRepositorio<T> where T : EntidadeBasica
    {

        protected readonly ExemploCursoContext Db;
        protected readonly DbSet<T> DbSet;

        public BaseRepositorio(ExemploCursoContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        public IUnitOfWork UnitOfWork => Db;        

        public void Adicionar(T item)
        {            
            DbSet.Add(item);
        }

        public void Atualizar(T item)
        {
            DbSet.Update(item);
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public async Task<T?> ObterPeloId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> ObterTodos()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public void Remover(T item)
        {
            DbSet.Remove(item);
        }
    }
}
