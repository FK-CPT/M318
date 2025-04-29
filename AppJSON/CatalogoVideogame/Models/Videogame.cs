using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVideogame.Models
{
    internal class Videogame
    {
		private string _title;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private string _developer;

		public string Developer
		{
			get { return _developer; }
			set { _developer = value; }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		private string _commento;

		public string Commento
		{
			get { return _commento; }
			set { _commento = value; }
		}

		private string _image;

		public string Image
		{
			get { return _image; }
			set { _image = value; }
		}

        public Videogame(string title, string developer, string description, string commento, string image)
        {
            _title = title;
            _developer = developer;
            _description = description;
            _commento = commento;
            _image = image;
        }

        public override string? ToString()
        {
            return Title;
        }
    }
}
