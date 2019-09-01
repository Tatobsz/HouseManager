using System;
using System.Collections.Generic;
using System.Text;

namespace HouseManager.Dominio.Entidades
{
    public class Agenda
    {
        public List<DateTime> Datas { get; set; }
        public List<DateTime> Horarios { get; set; }
        public List<Evento> Eventos { get; set; }

        public Agenda()
        {
            Eventos = new List<Evento>();
            Horarios = new List<DateTime>();
        }

        public void AdicionarEvento(String nome, DateTime inicio, DateTime fim,
            String cor, Boolean prioridade)
        {
            var novoEvento = new Evento();
            novoEvento.Nome = nome;
            novoEvento.Prioridade = prioridade;
            novoEvento.Inicio = inicio;
            novoEvento.Fim = fim;
            novoEvento.Cor = cor;
            Eventos.Add(novoEvento);
        }

        public void AdicionarHorario(DateTime horario)
        {
            Horarios.Add(horario);

        }
    }
}
