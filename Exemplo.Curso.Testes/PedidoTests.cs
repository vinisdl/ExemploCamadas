using System.Collections.Generic;
using ExemploCurso.Domain.Entidades;
using Xunit;

namespace Exemplo.Curso.Testes
{
    public class PedidoTests
    {
        [Fact]
        public void PedidoTotal_ShouldCalculateCorrectly()
        {
            var produto = new Produto { Titulo = "Produto Teste", Descricao = "Descrição do produto", Preco = 10m };
            var itemPedido = new ItemPedido { Produto = produto, Quantidade = 2 };
            var pedido = new Pedido
            {
                ItemPedidos = new List<ItemPedido> { itemPedido },
                Imposto = 1.1m
            };

            var total = pedido.PedidoTotal();
            Assert.Equal(22m, total);
        }
    }
}
