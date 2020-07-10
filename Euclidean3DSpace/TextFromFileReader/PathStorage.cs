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
        private static string textToFile;

        public static string TextFromFile
        {
            get { return textFromFile; }
            set { textFromFile = value; }
        }
        public static string TextToFile
        {
            get { return textToFile; }
            set { textToFile = value; }
        }

        public static void LoadPath(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    textFromFile = reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File was not found!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Wrong directory path!");
            }
            catch (Exception)
            {
                Console.WriteLine("The file can't be accessed, parsed or do not exist!");
            }
        }
        public static void SafePath()
        {

        }
    }
}
