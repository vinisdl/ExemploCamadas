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

        [Fact]
        public void PedidoTotal_ShouldReturnZero_ForEmptyItemPedidos()
        {
            var pedido = new Pedido
            {
                ItemPedidos = new List<ItemPedido>(),
                Imposto = 1.5m
            };
            Assert.Equal(0m, pedido.PedidoTotal());
        }

        [Fact]
        public void PedidoTotal_ShouldThrowException_ForNullItemPedidos()
        {
            var pedido = new Pedido
            {
                ItemPedidos = null,
                Imposto = 1.0m
            };

            Assert.Throws<NullReferenceException>(() => pedido.PedidoTotal());
        }

        [Fact]
        public void PedidoTotal_ShouldReturnZero_WhenImpostoIsZero()
        {
            var produto = new Produto { Titulo = "Test", Descricao = "Test", Preco = 100m };
            var pedido = new Pedido
            {
                ItemPedidos = new List<ItemPedido> { new ItemPedido { Produto = produto, Quantidade = 5 } },
                Imposto = 0m
            };
            Assert.Equal(0m, pedido.PedidoTotal());
        }

        [Fact]
        public void PedidoTotal_ShouldThrowException_ForNullProdutoInItemPedido()
        {
            var pedido = new Pedido
            {
                ItemPedidos = new List<ItemPedido> { new ItemPedido { Produto = null, Quantidade = 1 } },
                Imposto = 1.0m
            };

            Assert.Throws<NullReferenceException>(() => pedido.PedidoTotal());
        }

    }
}
