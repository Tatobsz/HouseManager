using HouseManager.Aplicacao.Interfaces.Servicos;
using HouseManager.Dominio.Entidades;
using HouseManager.Infraestrutura.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseManager.Aplicacao.Implemetacoes.Servicos
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio usuarioRepositorio;

        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            this.usuarioRepositorio = usuarioRepositorio;
        }

        public Usuario Get()
        {
            return new Usuario();
        }
    }
}
