using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Koffel.Modules
{
    internal class CalcolatoreRumore
    {
        public class CalcolaRumore()
        {
            private int _accettabile;
            public int Accettablie
            {
                get { return _accettabile; }
                set { _accettabile = value; }
            }

            private int _moderato;
            public int Moderato
            {
                get { return _moderato; }
                set { _moderato = value; }
            }

            private int _forte;
            public int Forte
            {
                get { return _forte; }
                set { _forte = value; }
            }

            private int _troppoForte;
            public int TroppoForte
            {
                get { return _forte; }
                set { _forte = value; }
            }

            private int _sogliaDelDolore;
            public int SogliaDelDolore
            {
                get { return _sogliaDelDolore; }
                set { _sogliaDelDolore = value; }
            }
        }

    }
}
