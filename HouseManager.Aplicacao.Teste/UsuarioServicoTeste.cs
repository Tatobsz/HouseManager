using HouseManager.Aplicacao.Implemetacoes.Servicos;
using HouseManager.Dominio.Entidades;
using HouseManager.Infraestrutura.Implemetacoes.Repositorios;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HouseManager.Aplicacao.Teste
{
    public class UsuarioServicoTeste
    {
        [Fact]
        public void VerificaSeGetRetornaUsuario()
        {
            var usuarioServico = new UsuarioServico(new UsuarioRepositorio());

            Assert.True(usuarioServico.Get() != null &&
               usuarioServico.Get().GetType() == typeof(Usuario));
        }
    }
}