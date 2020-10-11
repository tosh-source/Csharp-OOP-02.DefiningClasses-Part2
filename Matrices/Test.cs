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
            genericMatrix[0, 0] = 32;
            genericMatrix[0, 1] = 65;
            genericMatrix[1, 0] = 76;
            genericMatrix[1, 1] = 82;

        }
    }
}
