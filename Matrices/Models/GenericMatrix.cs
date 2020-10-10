using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices.Models
{
    class GenericMatrix<T>
    {
        private T[,] matrix;

        public T[,] Matrix { get; private set; }

        public GenericMatrix(int rows, int cols)
        {
            this.Matrix = new T[rows, cols];
        }

        public T this[int row, int col]
        {
            get
            {
                return this.Matrix[row, col];
            }
            set
            {
                this.Matrix[row, col] = value;
            }
        }
    }
}
