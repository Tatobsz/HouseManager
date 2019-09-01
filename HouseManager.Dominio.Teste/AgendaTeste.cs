using HouseManager.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HouseManager.Dominio.Teste
{
    public class AgendaTeste
    {
        [Fact]
        public void VerificarSeAdicionandoEvento()
        {
            var agenda = new Agenda();

            agenda.AdicionarEvento("Primeiro metodo", DateTime.Now, DateTime.Now, "verde", true);
        
            Assert.True(agenda.Eventos.Count >= 1);
        }

        [Fact]
        public void VerificarSeAdicionandoHorario()
        {
            Agenda agenda = new Agenda();
            agenda.AdicionarHorario(DateTime.Now);

            Assert.True(agenda.Horarios.Count >= 1);
        }
    }
}
