using NUnit.Framework;
using System;
using System.Collections.Generic;
using ExemploCurso.Domain.Entidades;

namespace ExemploCurso.Tests
{
    [TestFixture]
    public class PedidoTest
    {
        [Test]
        public void PedidoTotal_CorrectlyCalculatesTotal_ForMultipleItems()
        {
            var pedido = new Pedido();
            pedido.Imposto = 1.1m;
            pedido.ItemPedidos = new List<ItemPedido>();

            var produto1 = new Produto { Preco = 10m };
            var produto2 = new Produto { Preco = 20m };

            var item1 = new ItemPedido { Produto = produto1, Quantidade = 2 }; // 10*2 = 20
            var item2 = new ItemPedido { Produto = produto2, Quantidade = 3 }; // 20*3 = 60

            pedido.ItemPedidos.Add(item1);
            pedido.ItemPedidos.Add(item2);

            // (20 + 60) * 1.1 = 88
            decimal total = pedido.PedidoTotal();
            Assert.AreEqual(88m, total);
        }
        
        [Test]
        public void PedidoTotal_ReturnsZero_ForEmptyItemPedidos()
        {
            var pedido = new Pedido();
            pedido.Imposto = 1.5m;
            pedido.ItemPedidos = new List<ItemPedido>();
            
            decimal total = pedido.PedidoTotal();
            Assert.AreEqual(0m, total);
        }
        
        [Test]
        public void PedidoTotal_ThrowsException_WhenItemPedidosIsNull()
        {
            var pedido = new Pedido();
            pedido.Imposto = 1.0m;
            pedido.ItemPedidos = null;
            
            Assert.Throws<NullReferenceException>(() => pedido.PedidoTotal());
        }
        
        [Test]
        public void PedidoTotal_ReturnsZero_WhenImpostoIsZero()
        {
            var pedido = new Pedido();
            pedido.Imposto = 0m;
            pedido.ItemPedidos = new List<ItemPedido>();
            
            var produto = new Produto { Preco = 100m };
            var item = new ItemPedido { Produto = produto, Quantidade = 5 }; // 100*5 = 500
            pedido.ItemPedidos.Add(item);
            
            decimal total = pedido.PedidoTotal();
            Assert.AreEqual(0m, total);
        }
        
        [Test]
        public void PedidoTotal_ThrowsException_WhenItemPedidoProdutoIsNull()
        {
            var pedido = new Pedido();
            pedido.Imposto = 1.0m;
            pedido.ItemPedidos = new List<ItemPedido>();
            
            var item = new ItemPedido { Produto = null, Quantidade = 1 };
            pedido.ItemPedidos.Add(item);
            
            Assert.Throws<NullReferenceException>(() => pedido.PedidoTotal());
        }
    }
}
