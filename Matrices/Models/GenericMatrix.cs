﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices.Models
{
    class GenericMatrix<T>
    {
        public T[,] Matrix { get; set; }

        public int Rows
        {
            get
            {
                return this.Matrix.GetLength(0);
            }
        }

        public int Columns
        {
            get
            {
                return this.Matrix.GetLength(1);
            }
        }

        public GenericMatrix(int rows, int cols)
        {
            this.Matrix = new T[rows, cols];
        }

        //Overload "operators for addition"
        public static GenericMatrix<T> operator +(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            MatrixCheckerAndExceptionHandler(firstMatrix, secondMatrix);

            GenericMatrix<T> result = new GenericMatrix<T>(firstMatrix.Rows, firstMatrix.Columns);

            for (int rowsToSet = 0; rowsToSet < firstMatrix.Rows; rowsToSet++)
            {
                for (int colToSet = 0; colToSet < firstMatrix.Columns; colToSet++)
                {
                    result[rowsToSet, colToSet] = (dynamic)firstMatrix[rowsToSet, colToSet] + (dynamic)secondMatrix[rowsToSet, colToSet];
                }
            }

            return result;
        }

        private static void MatrixCheckerAndExceptionHandler(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows)
            {
                throw new ArgumentException("The Matrices have different rows!");
            }
            if (firstMatrix.Columns != secondMatrix.Columns)
            {
                throw new ArgumentException("The Matrices have different columns!");
            }

            if (firstMatrix.GetType() != secondMatrix.GetType())
            {
                throw new ArgumentException("The Matrices have different types of values! No kind if action can be performed of different type of matrices!");
            }

            //Check type of matrix values.
            if (firstMatrix.GetType() == typeof(GenericMatrix<int>))
            {
            }
            else if (firstMatrix.GetType() == typeof(GenericMatrix<long>))
            {
            }
            else if (firstMatrix.GetType() == typeof(GenericMatrix<float>))
            {
            }
            else if (firstMatrix.GetType() == typeof(GenericMatrix<double>))
            {
            }
            else if (firstMatrix.GetType() == typeof(GenericMatrix<decimal>))
            {
            }
            else
            {
                throw new ArgumentException("The GenericMatrix need to have some ValueType as used type! Strings, chars and so on are not allowed!");
            }
        }

        //Indexer
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