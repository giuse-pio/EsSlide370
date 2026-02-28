using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsSlide370
{
    public class Studente : Persona
    {
        public List<Voti> Voto { get; set; } = new();

        public Voti Voti
        {
            get => default;
            set
            {
            }
        }
    }
}