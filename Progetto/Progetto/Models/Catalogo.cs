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
        public List<Album> Albums { get; set; }
        public List<Popolari> Popolari { get; set; }

        public Catalogo()
        {
            Artisti = new List<Artista>();
            Albums = new List<Album>();
            Popolari = new List<Popolari>();
        }

        public void AggiungiArtista(Artista artista, Album album, Popolari popolari)
        {
            if (!Artisti.Contains(artista))
            {
                Artisti.Add(artista);
            }
            else
            {
                throw new Exception("Artista già esistente");
            }

            if (!Albums.Contains(album))
            {
                Albums.Add(album);
            }
            else
            {
                throw new Exception("Album già esistente");
            }

            if (!Popolari.Contains(popolari))
            {
                Popolari.Add(popolari);
            }
            else
            {
                throw new Exception("Canzone Popolare già esistente");
            }
        }
    }
}
