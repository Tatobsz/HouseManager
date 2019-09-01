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

        public List<Produto> ListAll()
        {
            var produtos = new List<Produto>()
            {
                new Produto()
            };

            return produtos;
        }

        public Produto Get()
        {
            return new Produto();
        }
    }
}
