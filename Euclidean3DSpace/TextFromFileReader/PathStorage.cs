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
        public static void LoadPath(string filePath)
        {
            try
            {
                Models.Path paths = new Models.Path();
                //List<List<double>> coordinates = 

                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    while (reader != null)
                    {
                        //textFromFile.Append(reader.ReadLine());
                        string[] splitText = reader.ReadLine()
                                                   .Split(new string[] { "X = ", ",", "Y = ", ",", "Z = " }, StringSplitOptions.RemoveEmptyEntries)
                                                   .ToArray();

                        for (int index = 0; index <= splitText.Length -1; index++)
                        {

                        }
                    }
                }

                //for (int index = 0; index < textFromFile.Length; index++)
                //{
                //    paths.AddPoint(textFromFile[index]);
                //}

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
        public static void SafePath(string safeToFilePath, Models.Path paths)
        {
            try
            {
                using (var writer = new StreamWriter(safeToFilePath, false, Encoding.UTF8))
                {
                    foreach (var item in paths)
                    {

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("");               
            }
        }
    }
}
