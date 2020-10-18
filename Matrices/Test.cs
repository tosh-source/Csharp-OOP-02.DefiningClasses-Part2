using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrices.Models;

namespace Matrices
{
    class Test
    {
        static void Main(string[] args)
        {
            //Create new Matrix
            var genericMatrix = new GenericMatrix<int>(2, 2);
            genericMatrix[0, 0] = 1;
            genericMatrix[0, 1] = 2;
            genericMatrix[1, 0] = 3;
            genericMatrix[1, 1] = 4;

            var secondGenericMatrix = new GenericMatrix<int>(2, 2);
            secondGenericMatrix[0, 0] = 5;
            secondGenericMatrix[0, 1] = 6;
            secondGenericMatrix[1, 0] = 7;
            secondGenericMatrix[1, 1] = 8;

            var result = genericMatrix * secondGenericMatrix;
            Console.WriteLine(result);
        }
    }
}
