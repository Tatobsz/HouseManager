using HouseManager.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HouseManager.Dominio.Teste
{
    public class ProdutoTeste
    {
        [Theory]
        [InlineData("Cozinha")]
        [InlineData("Banheiro")]
        public void VerificarSeRecebendoCategoria(string categoria)
        {
            var produto = new Produto();

            produto.SetCategoria(categoria);

            Assert.Equal(categoria, produto.Categoria);
        }

        [Theory]
        [InlineData("Coisas de cozinha")]
        [InlineData("Coisas de banheiro")]
        public void VerificarSeRecebendoDescricao(string descricao)
        {
            var produto = new Produto();

            produto.SetDescricao(descricao);

            Assert.Equal(descricao, produto.Descricao);
        }
    }
}