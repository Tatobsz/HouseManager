using System;
using System.Collections.Generic;
using System.Text;

namespace HouseManager.Dominio.Entidades
{
    public class Evento
    {
        public String Nome { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public String Cor { get; set; }
        public Boolean Prioridade { get; set; }            
    }
}
