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

		private int _numeroPersone;

		public int NumeroPersone
		{
			get { return _numeroPersone; }
			set { _numeroPersone = value; }
		}

		private string _sitoRicetta;

		public string SitoRicetta
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

		private int _difficolta;

		public int Difficolta
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

        public Ricetta(string nome, int numeroPersone, string sitoRicetta, string preparazione, int difficolta, string commento)
        {
            _nome = nome;
            _numeroPersone = numeroPersone;
            _sitoRicetta = sitoRicetta;
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
