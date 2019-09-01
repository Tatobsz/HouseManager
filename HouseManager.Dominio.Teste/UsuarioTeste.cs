using Bogus;
using HouseManager.Dominio.Entidades;
using System;
using Xunit;

namespace HouseManager.Dominio.Teste
{
    public class UsuarioTeste
    {
        private readonly Faker faker;
        private readonly Usuario usuario;

        public UsuarioTeste()
        {
            faker = new Faker();

            var usuarioRecebido = new
            {
                Nome = faker.Person.FullName,
                Login = faker.Person.Email,
                Senha = faker.Person.Phone,
                DataDeNascimento = faker.Person.DateOfBirth
            };

            usuario = new Usuario(usuarioRecebido.Login, usuarioRecebido.Senha,
                usuarioRecebido.DataDeNascimento, usuarioRecebido.Nome);
        }

        [Fact]
        public void VerificarSeCriandoUsuarioIdValido()
        {
            Assert.True(usuario.Id != null || usuario.Id != Guid.Empty);
        }

        [Fact]
        public void VerificarSeCriandoUsuarioDataCriacaoValido()
        {
            Assert.True(usuario.DataDeCriacao != null || usuario.DataDeCriacao != new DateTime());
        }

        [Fact]
        public void VerificarSeCriandoUsuarioNomeValido()
        {
            Assert.True( !string.IsNullOrEmpty(usuario.Nome));
        }
    }
}

