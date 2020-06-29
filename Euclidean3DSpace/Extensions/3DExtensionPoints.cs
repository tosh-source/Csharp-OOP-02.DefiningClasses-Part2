using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euclidean3DSpace.Models;

namespace Euclidean3DSpace.Extensions
{
    public static class ExtensionPointsOf3DSpace
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = 0d;
            distance = Math.Sqrt(
                Math.Pow((firstPoint.X - secondPoint.X), 2) +   //this is equivalent of "(firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X)"
                Math.Pow((firstPoint.Y - secondPoint.Y), 2) +
                Math.Pow((firstPoint.Z - secondPoint.Z), 2)
                );

            return distance;
        }
    }
}
