using HouseManager.Dominio.Entidades;
using HouseManager.Infraestrutura.BancoDeDados;
using HouseManager.Infraestrutura.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseManager.Infraestrutura.Implemetacoes.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private Contexto db;

        public ProdutoRepositorio(Contexto db)
        {
            this.db = db;
        }

        public Produto BuscarUmProduto(Guid id)
        {
            return db.Produtos.FirstOrDefault(produto => produto.Id == id);
        }

        public List<Produto> ListarProdutos()
        {
            return db.Produtos.ToList();
        }

        public void AlterarProduto(Produto produto)
        {
            var produtoDoBanco = BuscarUmProduto(produto.Id);

            if (produtoDoBanco is null)
                throw new Exception("Produto não foi encontrado");

            db.Produtos.Remove(produtoDoBanco);
            db.Produtos.Add(produto);
        }

        public void IserirProduto(Produto produto)
        {
            if (db.Produtos.Contains(produto))
                throw new Exception("Produto já cadastrado");

            db.Produtos.Add(produto);
        }

        public void DeletarProduto(Guid id)
        {
            var produtoDoBanco = BuscarUmProduto(id);

            if (produtoDoBanco is null)
                throw new Exception("Produto não foi encontrado");

            db.Produtos.Remove(produtoDoBanco);
        }
    }
}