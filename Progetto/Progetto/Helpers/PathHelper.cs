using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto.Helpers
{
    internal class PathHelper
    {
        public static string GetConfigJsonPathArtisti()
        {
            string folderPathArtisti = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Artisti.json");
            return folderPathArtisti;
        }

        public static string GetConfigJsonPathAlbum()
        {
            string folderPathAlbum = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Album.json");
            return folderPathAlbum;
        }

        public static string GetConfigJsonPathPopolari()
        {
            string folderPathPopolari = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Popolari.json");
            return folderPathPopolari;
        }
    }
}
