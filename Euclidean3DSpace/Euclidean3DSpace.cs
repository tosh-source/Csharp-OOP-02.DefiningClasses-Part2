﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euclidean3DSpace.Models;
using Euclidean3DSpace.Extensions;

namespace Euclidean3DSpace
{
    class Euclidean3DSpace
    {
        static void Main(string[] args)
        {
            Point3D point3D = new Point3D() {X = 1, Y = 1, Z =  1};
            Console.WriteLine(point3D);
            Console.WriteLine(Point3D.StartCoordinate);
            Console.WriteLine(ExtensionPointsOf3DSpace.CalculateDistance(point3D, Point3D.StartCoordinate));
        }
    }
}
