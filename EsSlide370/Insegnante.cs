using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace EsSlide370
{
    public class Insegnante : Persona
    {
        public List<Materie> Materia { get; set; } = new();

        public Materie Materie
        {
            get => default;
            set
            {
            }
        }
    }
}