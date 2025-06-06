using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto.Models
{
    internal class Popolari
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

		private string _imgCanzone;

		public string ImgCanzone
		{
			get { return _imgCanzone; }
			set { _imgCanzone = value; }
		}
    }
}
