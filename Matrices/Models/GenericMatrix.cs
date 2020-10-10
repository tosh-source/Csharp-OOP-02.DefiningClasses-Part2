using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class GenericMatrix<T>
    {
        private T[,] matrix;

        public T[,] Matrix { get; private set; }

        public GenericMatrix(int rows, int cols)
        {
            this.Matrix = new T[rows, cols];
        }
    }
}
