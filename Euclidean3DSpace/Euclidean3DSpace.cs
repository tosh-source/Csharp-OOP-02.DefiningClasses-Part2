﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euclidean3DSpace.Models;
using Euclidean3DSpace.Extensions;
using Euclidean3DSpace.FileProcessing;

namespace Euclidean3DSpace
{
    class Euclidean3DSpace
    {
        static void Main(string[] args)
        {
            #region TESTS
            //Test point3D and calculation
            Point3D point3D = new Point3D() {X = 1, Y = 2, Z = 3};
            Console.WriteLine(point3D);
            Console.WriteLine(Point3D.StartCoordinate);
            Console.WriteLine(ExtensionPointsOf3DSpace.CalculateDistance(point3D, Point3D.StartCoordinate));

            //Test collection of points (aka. Path)
            Path points = new Path();
            points.AddPoint(point3D);
            points.AddPoint(Point3D.StartCoordinate);
            points.AddPoint(new Point3D { X = 3, Y = 3, Z = 3 });
            foreach (var item in points)
            {
                Console.WriteLine(item);
            }

            //Test file reader & writer
            PathStorage.SafePath(points);
            Path newPointsFromFile = PathStorage.LoadPath(fileName: "CollectionOfPoints.txt");
            //Console.WriteLine(newPointsFromFile);
            #endregion


        }
    }
}
