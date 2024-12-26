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
    public class ItemPedidoRepositorio : BaseRepositorio<ItemPedido>, IItemPedidoRepositorio
    {
        public ItemPedidoRepositorio(ExemploCursoContext context) : base(context)
        {
        }
    }
}
