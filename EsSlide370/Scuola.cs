using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsSlide370
{
    public class Scuola
    {

        public List<Studente> Studenti { get; set; } = new();
        public List<Insegnante> Insegnanti { get; set; } = new();

        public void MediaTuttiVoti(Studente studente)
        {
            float somma = 0;
            int contatore = 0;
            float media = 0;
            foreach (var voto in studente.Voto)
            {
                somma += voto.Valore;
                contatore++;

                media = somma / contatore;
            }
            Console.WriteLine(media);

        }

        public void MediaStudentePerMese(Studente studente, int mese)
        {
            float somma = 0;
            int contatore = 0;
            float media = 0;
            foreach (var voto in studente.Voto)
            {
                if ( voto.Data.Month == mese)
                {
                    somma += voto.Valore;
                    contatore++;
                }
                if(contatore == 0)
                {
                    Console.WriteLine("Non ci sono voti per questo mese");
                    return;
                }
                media = somma / contatore;
                Console.WriteLine(media);
            }
        }       

    }
}