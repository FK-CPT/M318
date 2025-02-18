using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Geometria.Models
{
    internal class Cerchio
    {
		private double _cerchioRaggio;

		public double CerchioRaggio
		{
			get { return _cerchioRaggio; }
			set 
			{
				if (value > 0)
				{
					_cerchioRaggio = value;
				}
				else
				{

				}
			}
		}

        public Cerchio(double cerchioRaggio)
        {
            CerchioRaggio = cerchioRaggio;
        }
    }
}
