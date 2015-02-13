using System;
using System.Text;

namespace MatrixClass
{
   public class Matrix
    {
        private int row;
        private int col;
        private int[,] matrix;
        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.matrix = new int[row, col];
        }
        public int this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }
        public int Row
        {
            get { return this.row; }
            set { this.row = value; }
        }
        public int Col
        {
            get { return this.col; }
            set { this.col = value; }
        }
        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix.Col != secondMatrix.Col ||
                firstMatrix.Row != secondMatrix.Row)
            {
                throw new Exception("Matrix must be with same dimensions.");
            }
            Matrix newMatrix = new Matrix(firstMatrix.Row, firstMatrix.Col);
            for (int row = 0; row < firstMatrix.Row; row++)
            {
                for (int col = 0; col < firstMatrix.Col; col++)
                {
                    newMatrix[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
                }
            }

            return newMatrix;
        }
        public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix.Col != secondMatrix.Col ||
                firstMatrix.Row != secondMatrix.Row)
            {
                throw new Exception("Matrix must be with same dimensions.");
            }
            Matrix newMatrix = new Matrix(firstMatrix.Row, firstMatrix.Col);
            for (int row = 0; row < firstMatrix.Row; row++)
            {
                for (int col = 0; col < firstMatrix.Col; col++)
                {
                    newMatrix[row, col] = firstMatrix[row, col] - secondMatrix[row, col];
                }
            }

            return newMatrix;
        }
        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix.Col != secondMatrix.Col ||
                firstMatrix.Row != secondMatrix.Row)
            {
                throw new Exception("Matrix must be with same dimensions.");
            }
            Matrix newMatrix = new Matrix(firstMatrix.Row, firstMatrix.Col);
            for (int row = 0; row < firstMatrix.Row; row++)
            {
                for (int col = 0; col < firstMatrix.Col; col++)
                {
                    for (int k = 0; k < firstMatrix.Col; k++)
                    {
                        newMatrix[row, col] += firstMatrix[row, k] * secondMatrix[k, col];
                    }
                }
            }

            return newMatrix;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < this.row; row++)
            {
                for (int col = 0; col < this.col; col++)
                {
                    result.AppendFormat("{0}, ", matrix[row, col]);
                }
                result.AppendLine();
            }
            return result.ToString();
        }
    }
}
