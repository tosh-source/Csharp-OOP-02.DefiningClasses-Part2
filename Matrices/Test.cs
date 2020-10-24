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
            //Expected result of matrix multiplication
            //19 22
            //43 50

            //Test overloaded true/false operator
            var newGenericMatrix = new GenericMatrix<int>(2, 2);
            genericMatrix[0, 0] = 0;
            genericMatrix[0, 1] = 0;
            genericMatrix[1, 0] = 3;
            genericMatrix[1, 1] = 4;

            if (newGenericMatrix)
            {
                Console.WriteLine("There is zero values in the Matrix!");
            }
            else 
            {
                Console.WriteLine("There is NO zero values in the Matrix!");
            }

            if (result)
            {
                Console.WriteLine("There is zero values in the Matrix!");
            }
            else
            {
                Console.WriteLine("There is NO zero values in the Matrix!");
            }

            //Print Attributes
            Type matrixType = typeof(GenericMatrix<Type>);
            var allAttributes = matrixType.GetCustomAttributes(false);  //matrixType return type is "object[]".
            Console.WriteLine(string.Join(Environment.NewLine, allAttributes));
        }
    }
}
