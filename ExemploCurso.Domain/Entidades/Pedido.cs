using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCurso.Domain.Entidades
{
    public class Pedido : EntidadeBasica
    {
        //public Cpf Cpf { get; set; }

        public List<ItemPedido>? ItemPedidos { get; set; }
        public decimal Imposto { get; set; }        

        public decimal PedidoTotal()
        {           
            return ItemPedidos.Sum(x=> x.PrecoTotal) * Imposto;
        }
    }
}
