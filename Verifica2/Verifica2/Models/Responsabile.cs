using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica2.Models
{
    internal class Responsabile
    {
		private string _nome;

		public string Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

		private string _cognome;

		public string Cognome
		{
			get { return _cognome; }
			set { _cognome = value; }
		}

        public Responsabile(string nome, string cognome)
        {
            _nome = nome;
            _cognome = cognome;
        }
    }
}
