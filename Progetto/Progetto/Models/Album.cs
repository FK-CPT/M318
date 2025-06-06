using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto.Models
{
    internal class Album
    {
		private string _nome;

		public string Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

		private int _ascolti;

		public int Ascolti
		{
			get { return _ascolti; }
			set { _ascolti = value; }
		}

		private string _canzoni;

		public string Canzoni
		{
			get { return _canzoni; }
			set { _canzoni = value; }
		}

		private string _coverAlbum;

		public string CoverAlbum
		{
			get { return _coverAlbum; }
			set { _coverAlbum = value; }
		}

        public Album(string nome, int ascolti, string canzoni, string coverAlbum)
        {
            _nome = nome;
            _ascolti = ascolti;
            _canzoni = canzoni;
            _coverAlbum = coverAlbum;
        }
    }
}