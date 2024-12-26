using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploCurso.Domain.Entidades;
using ExemploCurso.Domain.Interfaces.Repository;
using ExemploCurso.Repository.Contexto;

namespace ExemploCurso.Repository.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public int CountadorAcessos = 0;

        public PedidoRepositorio(ExemploCursoContext context) : base(context)
        {
            CountadorAcessos += 1;
        }
    }
}
