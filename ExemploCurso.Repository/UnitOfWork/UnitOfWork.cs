using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploCurso.Domain.Interfaces.Repository;
using ExemploCurso.Repository.Contexto;

namespace ExemploCurso.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ExemploCursoContext? _context;

        public UnitOfWork(ExemploCursoContext? context)
        {
            _context = context;
        }

        public async Task<bool> Commit()
        {
            var success = await _context.SaveChangesAsync();
            return success > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
