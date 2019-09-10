using HouseManager.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseManager.Infraestrutura.BancoDeDados
{
    public class Contexto
    {
        public List<Produto> Produtos;
        public List<Usuario> Usuarios;

        public Contexto()
        {
            Produtos = new List<Produto>();
            Usuarios = new List<Usuario>();
        }
    }
}
