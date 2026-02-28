using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsSlide370
{
    public class Voti
    {
        public Materie Materia { get; set; }
        public DateTime Data { get; set; }
        public float Valore { get; set; }

        public Materie Materie
        {
            get => default;
            set
            {
            }
        }
    }
}