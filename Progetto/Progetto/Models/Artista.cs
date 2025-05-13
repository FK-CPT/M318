using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto.Models
{
    class Artista
    {
		private string _nome;

		public string Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

		private string _genere;

		public string Genere
		{
			get { return _genere; }
			set { _genere = value; }
		}

		private int _ascoltiMensili;

		public int AscoltiMensili
		{
			get { return _ascoltiMensili; }
			set { _ascoltiMensili = value; }
		}

		private string _biografia;

		public string Biografia
		{
			get { return _biografia; }
			set { _biografia = value; }
		}

		private string _imgArtista;

		public string ImgArtista
		{
			get { return _imgArtista; }
			set { _imgArtista = value; }
		}


		public override string? ToString()
        {
            return Nome + " - " + Genere;
        }
    }
}