using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica3FabioKoffel.Models
{
    internal class Catalogo
    {
        public List<Ricetta> Ricette { get; set; }
        public Catalogo() 
        { 
            Ricette = new List<Ricetta>();
        }
        public void AggiungiRicetta(Ricetta ricetta)
        {
            if (!Ricette.Contains(ricetta))
            {
                Ricette.Add(ricetta);
            }
            else
            {
                throw new Exception("Ricetta Esistente");
            }
        }
    }
}
