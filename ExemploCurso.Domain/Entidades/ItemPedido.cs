using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCurso.Domain.Entidades
{
    public class ItemPedido : EntidadeBasica
    {
        public Produto? Produto { get; set; }
        public int Quantidade { get; set; }        
        public decimal PrecoTotal { get { return Quantidade * Produto.Preco; } }        
    }
}
