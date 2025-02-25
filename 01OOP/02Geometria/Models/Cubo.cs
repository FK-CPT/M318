using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Geometria.Models
{
    internal class Cubo
    {
		private double _lato;

		public double Lato
		{
			get { return _lato; }
			set 
			{
				if (value > 0)
				{
					_lato = value;
				}
				else
				{
					throw new ArgumentException("Inserire solo valori positivi");
				}
			}
		}
        public Cubo(double lato)
        {
            _lato = lato;
        }

		public Cubo() 
		{
			_lato = 1;
		}

		public double CalcolaVolume()
		{
			return Lato * Lato * Lato;
		}

		public double CalcolaPerimetro()
		{
			return Lato * 12;
		}
    }
}
