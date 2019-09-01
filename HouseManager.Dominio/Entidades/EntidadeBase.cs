using System;
using System.Collections.Generic;
using System.Text;

namespace HouseManager.Dominio.Entidades
{
    public class EntidadeBase
    {
        public EntidadeBase(Guid id, string nome, DateTime dataDeCriacao)
        {
            Id = id;
            Nome = nome;
            DataDeCriacao = dataDeCriacao;
        }

        public EntidadeBase(Guid id)
        {        
            Id = id;
            DataDeCriacao = DateTime.Now;
        }

        public Guid Id { get; set; }
        public String Nome { get; set; }
        public DateTime DataDeCriacao { get; set; }
    }
}
