using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica3FabioKoffel.Helpers
{
    internal class PathHelper
    {
        public static string GetConfigJsonPath()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Ricette.json");
            return folderPath;
        }
    }
}
