using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVideogame.Helpers
{
    internal class PathHelper
    {
        public static string GetConfigJsonPath()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "videogames.json");
            return folderPath;
        }
    }
}