using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10AppHotel.Models
{
    class Stanza
    {
		private int _numero;

		public int Numero
		{
			get { return _numero; }
			set { _numero = value; }
		}

		private int _costo;

		public int Costo
		{
			get { return _costo; }
			set { _costo = value; }
		}

		private string _Osservazioni;

		public string Osservazioni
		{
			get { return _Osservazioni; }
			set { _Osservazioni = value; }
		}

		private string[] _percorsoImmagine;

		public string[] PercorsoImmagine
		{
			get { return _percorsoImmagine; }
			set { _percorsoImmagine = value; }
		}

		public Stanza(int numero, int costo, string osservazioni)
		{
			Numero = numero;
			Costo = costo;
			Osservazioni = osservazioni;
		}
	}
}
