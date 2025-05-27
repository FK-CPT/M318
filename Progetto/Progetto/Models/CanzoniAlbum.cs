using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto.Models
{
    internal class CanzoniAlbum
    {
		private string _titolo;

		public string Titolo
		{
			get { return _titolo; }
			set { _titolo = value; }
		}

		private string _durata;

		public string Durata
		{
			get { return _durata; }
			set { _durata = value; }
		}

		private int _ascolti;

		public int Ascolti
		{
			get { return _ascolti; }
			set { _ascolti = value; }
		}

        public CanzoniAlbum(string titolo, string durata, int ascolti)
        {
            _titolo = titolo;
            _durata = durata;
            _ascolti = ascolti;
        }
    }
}
