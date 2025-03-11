using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10AppHotel.Models
{
	class Calcolatore
	{
		private bool _hasAnimali;

		public bool HasAnimali
		{
			get { return _hasAnimali; }
			set { _hasAnimali = value; }
		}

		private DatePicker _dataArrivo;

		public DatePicker DataArrivo
		{
			get { return _dataArrivo; }
			set { _dataArrivo = value; }
		}

		private DatePicker _dataPartenza;

		public DatePicker DataPartenza
		{
			get { return _dataPartenza; }
			set { _dataPartenza = value; }
		}

		private int _persone;

		public int Persone
		{
			get { return _persone; }
			set { _persone = value; }
		}

		private Stanza _stanza;

		public Stanza Stanza
		{
			get { return _stanza; }
			set { _stanza = value; }
		}

		public Calcolatore(Stanza stanza)
		{
            HasAnimali = false;
            Persone = 0;
            Stanza = stanza;
        }

		public int CalcolaGiorni()
		{
			//Permette di restituire la differenza (in giorni) tra due date
			DateTime dataArrivo = DataArrivo.Date;
			DateTime dataPartenza = DataPartenza.Date;	
			TimeSpan diff = dataPartenza.Subtract(dataArrivo);
			return Convert.ToInt32(diff.TotalDays);
		}

		public double CalcolaCosto()
		{
			double costo = CalcolaGiorni() * Persone * Stanza.Costo;
			if(HasAnimali)
			{
				costo += CalcolaGiorni() * 20;
			}
		return costo;
		}
	}
}
