using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDDemo.Tests.Entities;

namespace TDDDemo.Tests
{
    [TestClass]
    public class CarrinhoCompraTeste
    {
        [TestMethod]
        public void AdicionarProdutoNoCarrinho()
        {
            //Arrange
            CarrinhodeCompra Carrinho = new CarrinhodeCompra();
            Produto Produto1 = new Produto();

            //Act
            var value = Carrinho.Add(Produto1);

            //Assert (objeto esperado e onde guardei o retorno)
            Assert.AreEqual(true, value);
        }
        [TestMethod]
        public void NaoPermitirAdicionarouRemoverPelaLista()
        {
            //Arrange
            CarrinhodeCompra Carrinho = new CarrinhodeCompra();
            Produto Produto1 = new Produto();

            //Act
            //Carrinho.Itens.Add(Produto1);

            //Assert
            Assert.AreEqual(0, Carrinho.Itens.Count);
        }
    }
}
