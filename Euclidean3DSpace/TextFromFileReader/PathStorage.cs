using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euclidean3DSpace.Models;

namespace Euclidean3DSpace.FileProcessing
{
    public static class PathStorage
    {
        public static Models.Path LoadPath(string directory = "", string fileName = "CollectionOfPoints.txt")  //When skip Directory as parameter, the default empty string will use current EXE working directory.
        { //Method can read Point3D in format "X = 1, Y = 2, Z = 3". There is no limit how many Point3D can be read as collection (Models.Path). Every Point3D need to be in NEW line!

            Models.Path collectionOfPoints = new Models.Path();
            try
            {
                using (var reader = new StreamReader((directory + fileName), Encoding.UTF8))
                {
                    while (reader != null)
                    {
                        string[] splitText = reader.ReadLine()
                                                   .Split(new string[] { "X = ", ",", " ", "Y = ", ",", "Z = ",
                                                                         "X:", "X: ", "Y:", "Y: ", "Z:", "Z: " }, 
                                                                         StringSplitOptions.RemoveEmptyEntries)
                                                   .ToArray();

                        double[] XYZ_points = new double[3];
                        for (int index = 0; index <= splitText.Length - 1; index++)
                        {
                            XYZ_points[index] = double.Parse(splitText[index]);  //if more than three doubles, IndexOutOfRangeException
                        }

                        Point3D currentPoint = new Point3D(XYZ_points[0], XYZ_points[1], XYZ_points[2]);
                        collectionOfPoints.AddPoint(currentPoint);
                    }
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
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("More than three numbers/points are detected!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Not correct numeric value!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file can't be accessed, parsed or do not exist! " + ex.Message);
            }

            return collectionOfPoints;
        }

        public static void SafePath(Models.Path collectionOfPoints, string directory = "", string fileName = "CollectionOfPoints.txt")  //When skip Directory as parameter, the default empty string will use current EXE working directory.
        {
            try
            {
                using (var writer = new StreamWriter((directory + fileName), false, Encoding.UTF8))  //if safeToFilePath is null, ArgumentNullException
                {
                    foreach (var currentPoint in collectionOfPoints)  //if collectionOfPoints is null, NullReferenceException
                    {
                        writer.WriteLine(currentPoint.ToString());
                    }
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("SafeToFilePath is NULL!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("CollectionOfPoints is NULL!");
            }
            catch (Exception)
            {
                Console.WriteLine("The file can't be created!");
            }
        }
    }
}

