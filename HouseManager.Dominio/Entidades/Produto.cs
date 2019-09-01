using System;
using System.Collections.Generic;
using System.Text;

namespace HouseManager.Dominio.Entidades
{
    public class Produto : EntidadeBase
    {
        //Deve ter descrição
        public String Descricao { get; private set; }

        //Deve ser maior ou igual a data atual
        public DateTime DataDeValidade { get; private set; }

        //Tempo estimado não pode ser nulo, vazio ou menor do que 0;
        public Int32 TempoEstimadoDeUso { get; private set; }

        /*Trocar por uma classe*/
        //Deve ter uma categoria
        public String Categoria { get; private set; }

        public Produto()
            : base(Guid.NewGuid())
        {
        }

        public void SetDescricao(String descricao)
        {
            Descricao = descricao;
        }

        public void SetDataDeValidade(DateTime dataDeValidade)
        {
            DataDeValidade = dataDeValidade;
        }

        public void SetTempoEstimadoDeUso(Int32 tempoEstimadoDeUso)
        {
            TempoEstimadoDeUso = tempoEstimadoDeUso;
        }

        public void SetCategoria(String categoria)
        {
            Categoria = categoria;
        }
    }
}