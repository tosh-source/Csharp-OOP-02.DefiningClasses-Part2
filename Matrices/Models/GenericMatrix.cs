﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices.Models
{
    [Version(1, 00)]
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

        //Overload arithmetical operators.
        public static GenericMatrix<T> operator +(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            MatrixCheckerAndExceptionHandler(firstMatrix, secondMatrix);

            var result = new GenericMatrix<T>(firstMatrix.Rows, firstMatrix.Columns);

            for (int rowsToSet = 0; rowsToSet < firstMatrix.Rows; rowsToSet++)
            {
                for (int colsToSet = 0; colsToSet < firstMatrix.Columns; colsToSet++)
                {
                    result[rowsToSet, colsToSet] = (dynamic)firstMatrix[rowsToSet, colsToSet] + (dynamic)secondMatrix[rowsToSet, colsToSet];
                }
            }

            return result;
        }
        public static GenericMatrix<T> operator -(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            MatrixCheckerAndExceptionHandler(firstMatrix, secondMatrix);

            var result = new GenericMatrix<T>(firstMatrix.Rows, firstMatrix.Columns);

            for (int rowsToSet = 0; rowsToSet < firstMatrix.Rows; rowsToSet++)
            {
                for (int colsToSet = 0; colsToSet < firstMatrix.Columns; colsToSet++)
                {
                    result[rowsToSet, colsToSet] = (dynamic)firstMatrix[rowsToSet, colsToSet] - (dynamic)secondMatrix[rowsToSet, colsToSet];
                }
            }

            return result;
        }
        public static GenericMatrix<T> operator *(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            MatrixCheckerAndExceptionHandler(firstMatrix, secondMatrix);

            var result = new GenericMatrix<T>(firstMatrix.Rows, firstMatrix.Columns);
            var tempValue = default(T);

            for (int currentRow = 0; currentRow < firstMatrix.Rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < firstMatrix.Columns; currentCol++)
                {
                    for (int index = 0; index < firstMatrix.Columns; index++)
                    {
                        tempValue += (dynamic)firstMatrix[currentRow, index] * (dynamic)secondMatrix[index, currentCol];
                    }
                    result[currentRow, currentCol] = tempValue;
                    tempValue = default(T);
                }
            }

            return result;
        }

        //Overloaded operators true/false will check for non-zero elements.
        public static bool operator true(GenericMatrix<T> genericMatrix)
        {
            bool haveZero = false;

            for (int rowsToCheck = 0; rowsToCheck < genericMatrix.Rows; rowsToCheck++)
            {
                for (int colsToCheck = 0; colsToCheck < genericMatrix.Columns; colsToCheck++)
                {
                    if (genericMatrix[rowsToCheck, colsToCheck].Equals(default(T)))
                    {
                        haveZero = true;
                    }
                }
            }

            return haveZero;
        }
        public static bool operator false(GenericMatrix<T> genericMatrix)
        {
            bool haveZero = true;

            for (int rowsToCheck = 0; rowsToCheck < genericMatrix.Rows; rowsToCheck++)
            {
                for (int colsToCheck = 0; colsToCheck < genericMatrix.Columns; colsToCheck++)
                {
                    if (!(genericMatrix[rowsToCheck, colsToCheck].Equals(default(T))))
                    {
                        haveZero = false;
                    }
                }
            }

            return haveZero;
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

            //Check type of matrix values. Currently allowed value types of GenericMatrix are: (see below)
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

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int rowToPrint = 0; rowToPrint < this.Matrix.GetLength(0); rowToPrint++)
            {
                for (int colToPrint = 0; colToPrint < this.Matrix.GetLength(1); colToPrint++)
                {
                    result.Append(string.Format("{0,5}", this.Matrix[rowToPrint, colToPrint]));  //or use .AppendFormat() is combination of: .Append(string.Format())
                }
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
