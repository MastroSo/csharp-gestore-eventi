using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        private string titolo;
        private List<Evento> eventi = new List<Evento>();

        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
        }

        //Metodi

        public void AggiungiEvento(Evento nomEvento)
        {
            eventi.Add(nomEvento);
        }

        public void GetListaRicercata(DateTime dataDaCercare)
        {
            foreach (Evento evento in eventi)
            {
                if (eventi.Exists(x => x.GetData() == dataDaCercare))
                {
                    Console.WriteLine("l'evento in data " + evento.GetData() + " è " + evento.GetTitolo());
                }

            }
        }

        //------- Getters - Setters ---------
        public string GetTitolo()
        {
            return titolo;
        }

        public void SetTitolo(string titolo)
        {
            this.titolo = titolo;
        }

    }
}