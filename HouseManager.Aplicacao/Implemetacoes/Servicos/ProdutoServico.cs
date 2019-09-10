using HouseManager.Aplicacao.Interfaces.Servicos;
using HouseManager.Dominio.Entidades;
using HouseManager.Infraestrutura.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseManager.Aplicacao.Implemetacoes.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
        {
            this.produtoRepositorio = produtoRepositorio;
        }

        public void InserirProduto(Produto produto)
        {
            produtoRepositorio.IserirProduto(produto);
        }

        public List<Produto> ListAll()
        {
            return produtoRepositorio.ListarProdutos();
        }

        public Produto Get(Guid id)
        {
            return produtoRepositorio.BuscarUmProduto(id);
        }

        public void Deletar(Guid id)
        {
            produtoRepositorio.DeletarProduto(id);
        }

        public void Alterar(Produto produto)
        {
            produtoRepositorio.AlterarProduto(produto);
        }
    }
}
