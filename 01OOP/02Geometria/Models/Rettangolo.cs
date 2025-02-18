using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Geometria.Models
{

    internal class Rettangolo
    {
        #region =01=== costanti & statici ======================
        #endregion

        #region =02=== membri & proprietà ============propfull==
        private double _latoMinore;

        public double LatoMinore
        {
            get { return _latoMinore; }

            set
            {
                if (value > 0)
                {
                    _latoMaggiore = value;
                }
                else
                {
                    throw new ArgumentException("Inserire solo valori positivi");
                }
            }
        }


        private double _latoMaggiore;

        public double LatoMaggiore
        {
            get { return _latoMaggiore; }
            set
            {
                if (value > 0)
                {
                    _latoMaggiore = value;
                }
                else
                {
                    throw new ArgumentException("Inserire solo valori positivi");
                }
            }
        }
        #endregion

        #region =03=== costruttori =======================ctor==
        public Rettangolo(double latoMinore, double latoMaggiore)
        {
            LatoMinore = latoMinore;
            LatoMaggiore = latoMaggiore;
        }

        public Rettangolo()
        {
            LatoMinore = 1;
            LatoMaggiore = 1;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================

        /// <summary>
        /// Metodo che serve a calcolare l'area di un rettangolo
        /// </summary>
        /// <returns>Area del rettangolo</returns>
 
        public double CalcolaArea()
        {
            return LatoMaggiore * LatoMinore;
        }

        /// <summary>
        /// Metodo che serve a calcolare il perimetro di un rettangolo
        /// </summary>
        /// <returns>Perimetro del rettangolo</returns>

        public double CalcolaPerimetro()
        {
            return (LatoMinore * 2) + (LatoMaggiore * 2);
        }
        #endregion
    }
}