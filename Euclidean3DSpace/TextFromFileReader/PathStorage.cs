using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euclidean3DSpace.Models;

namespace Euclidean3DSpace.TextFromFileReader
{
    public static class PathStorage
    {
        private static string textFromFile;

        public static void LoadPath(string fileReader)
        {
            var reader = new StreamReader(fileReader);
            textFromFile = reader.ReadToEnd();
            reader.Close();
        }
        public static void SafePath()
        {

        }
    }
}
