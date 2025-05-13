using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto.Models
{
    class Catalogo
    {
        public List<Artista> Artisti { get; set; }

        public Catalogo()
        {
            Artisti = new List<Artista>();
        }

        public void AggiungiVideogame(Artista videogame)
        {
            if (!Artisti.Contains(videogame))
            {
                Artisti.Add(videogame);
            }
            else
            {
                throw new Exception("Artista Esistente");
            }
        }
    }
}
