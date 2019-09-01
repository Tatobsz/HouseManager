using System;
using System.Collections.Generic;
using System.Text;

namespace HouseManager.Dominio.Entidades
{
    public class Usuario : EntidadeBase
    {
        public String Login { get; set; }
        public String Senha { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public Usuario(string login, string senha, DateTime dataDeNascimento, string nome)
            : base(Guid.NewGuid())
        {
            DataDeNascimento = dataDeNascimento;
            Nome = nome;
            Login = login;
            Senha = senha;
            DataDeNascimento = dataDeNascimento;
        }

        public Usuario()
            : base(Guid.NewGuid())
        {

        }
    }
}
