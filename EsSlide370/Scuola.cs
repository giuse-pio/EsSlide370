using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsSlide370
{
    public class Scuola
    {
        public Insegnante Insegnante
        {
            get => default;
            set
            {
            }
        }

        public Studente Studente
        {
            get => default;
            set
            {
            }
        }

        public List<Studente> Studenti { get; set; } = new();
        public List<Insegnante> Insegnanti { get; set; } = new();
    }
}