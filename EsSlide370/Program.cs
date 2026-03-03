namespace EsSlide370
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scuola scuola = new Scuola();
            Studente studente = new Studente()
            {
                Nome = "Mario",
                Cognome = "Rossi",
                Voto = new List<Voti>()
                {
                    new Voti() 
                    {
                        Valore = 8,
                        Data = new DateTime(2024, 5, 10) },

                    new Voti() 
                    { 
                        Valore = 7, 
                        Data = new DateTime(2024, 5, 15) },

                    new Voti()
                    { 
                        Valore = 9, 
                        Data = new DateTime(2024, 6, 20)
                    }
                }
            };

            scuola.Studenti.Add(studente);
            scuola.MediaTuttiVoti(studente);
            scuola.MediaStudentePerMese(studente, 5);
        }
    }
}
