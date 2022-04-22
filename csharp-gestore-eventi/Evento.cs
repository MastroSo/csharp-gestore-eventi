using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienzaMassima;
        private int postiPrenotati;

        

        //costruttori
        public Evento(string titolo, DateTime data, int capienzaMassima, int postiPrenotati)
        {
            SetTitolo(titolo);
            Setdata(data);
            SetcapienzaMassima(capienzaMassima);
            SetnumeroPrenotati(postiPrenotati);

            
        }

        public Evento(string titolo, DateTime data, int capienzaMassima)
        {
            SetTitolo(titolo);
            Setdata(data);
            SetcapienzaMassima(capienzaMassima);
            postiPrenotati = 0;

        }

        //------ Metodi ------

        public void Prenota()
        {
            DateTime dateOdierna = DateTime.Now;
            if (data < dateOdierna)
            {
                throw new ArgumentOutOfRangeException("l'evento è già passato ci dispiace");
            }
            else if (postiPrenotati < capienzaMassima)
            {
                postiPrenotati++;
            }
            else
            {
                Console.WriteLine("mi dispiace ma non ci sono più posti da prenotare");
            }
        }

        public void Disdici()
        {
            DateTime dateOdierna = DateTime.Now;
            if (data < dateOdierna)
            {
                throw new ArgumentOutOfRangeException("l'evento è già passato ci dispiace");
            }
            else if (postiPrenotati > 0)
            {
                postiPrenotati--;
            }
            else
            {
                throw new ArgumentOutOfRangeException("mi dispiace ma non si può andare in negativo");
            }
        }

        public override string ToString()
        {
            return "(dd/mm/yyyy): " + data;
        }

        public int PostiDisponibili()
        {
            int postiRimanenti;
            postiRimanenti = capienzaMassima - postiPrenotati;
            return postiRimanenti;
        }
        //------ Getters ------

        public string GetTitolo()
        {
            return titolo;
        }

        public DateTime GetData()
        {
            return data;
        }

        public int GetcapienzaMassima()
        {
            return capienzaMassima;
        }

        public int GetpostiPrenotati()
        {
            return postiPrenotati;
        }

        //------ Setters ------

        public void SetTitolo(string titolo)
        {
            if (titolo != null)
            {
                this.titolo = titolo;
            }
            else
            {
                throw new ArgumentNullException("Deve inserire un Titolo caro Utente");
            }
        }

        public void Setdata(DateTime data)
        {
            DateTime dateOdierna = DateTime.Now;
            if (data <= dateOdierna)
            {
                throw new ArgumentOutOfRangeException("Non puoi inserire una data nel passato");
            }
            else
            {
                this.data = data;
            }
        }

        public void SetcapienzaMassima(int capienzaMassima)
        {
            if (capienzaMassima < 0)
            {
                throw new ArgumentOutOfRangeException("non puoi inserire un valore negativo");
            }
            else
            {
                this.capienzaMassima = capienzaMassima;
            }
        }
        public void SetnumeroPrenotati(int postiPrenotati)
        {
            if (postiPrenotati < 0)
            {
                throw new ArgumentOutOfRangeException("non puoi inserire un valore negativo");
            }
            else
            {
                this.postiPrenotati = postiPrenotati;
            }

        }
    }

}