using System;
using System.Collections.Generic;
using System.Text;

namespace HouseManager.Dominio.Entidades
{
    public class Produto : EntidadeBase
    {
        public String Descricao { get; [Sourceble] private set; }
        public DateTime DataDeValidade { get; [Sourceble] private set; }
        public Int32 TempoEstimadoDeUso { get; [Sourceble] private set; }
        public String Categoria { get; [Sourceble] private set; }

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