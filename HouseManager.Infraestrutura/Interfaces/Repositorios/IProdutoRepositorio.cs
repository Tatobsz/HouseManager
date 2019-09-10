using HouseManager.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseManager.Infraestrutura.Interfaces.Repositorios
{
    public interface IProdutoRepositorio
    {
        Produto BuscarUmProduto(Guid id);
        List<Produto> ListarProdutos();
        void AlterarProduto(Produto produto);
        void IserirProduto(Produto produto);
        void DeletarProduto(Guid id);
    }
}