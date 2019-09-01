using HouseManager.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseManager.Aplicacao.Interfaces.Servicos
{
    public interface IProdutoServico
    {
        List<Produto> ListAll();
        Produto Get();
    }
}
