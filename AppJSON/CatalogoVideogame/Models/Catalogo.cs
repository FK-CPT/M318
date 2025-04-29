using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVideogame.Models
{
    internal class Catalogo
    {
        public List<Videogame> Videogames { get; set; }

        public Catalogo()
        {
            Videogames = new List<Videogame>();
        }

        public void AggiungiVideogame(Videogame videogame)
        {
            if (!Videogames.Contains(videogame))
            {
                Videogames.Add(videogame);
            }
            else
            {
                throw new Exception("Libro Esistente");
            }
        }
    }
}
