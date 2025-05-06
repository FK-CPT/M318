using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica3FabioKoffel.Models
{
    internal class Ricetta
    {
		private string _nome;

		public string Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

		private string _numeroPresone;

		public string NumPersone
		{
			get { return _numeroPresone; }
			set { _numeroPresone = value; }
		}

		private string _sitoRicetta;

		public string Sito
		{
			get { return _sitoRicetta; }
			set { _sitoRicetta = value; }
		}

		private string _preparazione;

		public string Preparazione
		{
			get { return _preparazione; }
			set { _preparazione = value; }
		}

		private string _difficolta;

		public string Difficolta
		{
			get { return _difficolta; }
			set { _difficolta = value; }
		}


		private string _commento;

		public string Commento
		{
			get { return _commento; }
			set { _commento = value; }
		}

        public Ricetta(string nome, string numPresone, string sito, string preparazione, string difficolta, string commento)
        {
            _nome = nome;
            _numeroPresone = numPresone;
            _sitoRicetta = sito;
            _preparazione = preparazione;
            _difficolta = difficolta;
            _commento = commento;
        }

        public override string? ToString()
        {
            return Nome + " - " + "Difficoltà: " + Difficolta;
        }
    }
}
