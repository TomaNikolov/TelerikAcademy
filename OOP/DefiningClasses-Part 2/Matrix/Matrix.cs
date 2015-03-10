namespace Matrix
{
    using System;
    using System.Text;

    //Problem 8. Matrix
    public class Matrix<T>
        where T : struct
    {
        private T[,] matrix;

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.matrix = new T[row, col];
        }

        public int Row { get; private set; }
        public int Col { get; private set; }

        //Problem 9. Matrix indexer
        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        //Problem 10. Matrix operations
        //Implement the operators +
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Col != secondMatrix.Col ||
                                 firstMatrix.Row != secondMatrix.Row)
            {
                throw new Exception("Matrix must be with same dimensions.");
            }

            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);

            for (int row = 0; row < firstMatrix.Row; row++)
            {
                for (int col = 0; col < firstMatrix.Col; col++)
                {
                    newMatrix[row, col] = (dynamic)firstMatrix[row, col] + (dynamic)secondMatrix[row, col];
                }
            }
            return newMatrix;
        }

        // Implement the operators -
        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Col != secondMatrix.Col ||
            firstMatrix.Row != secondMatrix.Row)
            {
                throw new Exception("Matrix must be with same dimensions.");
            }
            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);
            for (int row = 0; row < firstMatrix.Row; row++)
            {
                for (int col = 0; col < firstMatrix.Col; col++)
                {
                    newMatrix[row, col] = (dynamic)firstMatrix[row, col] - (dynamic)secondMatrix[row, col];
                }
            }
            return newMatrix;
        }

        // Implement the operators *
        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Col != secondMatrix.Col ||
            firstMatrix.Row != secondMatrix.Row)
            {
                throw new Exception("Matrix must be with same dimensions.");
            }
            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);
            for (int row = 0; row < firstMatrix.Row; row++)
            {
                for (int col = 0; col < firstMatrix.Col; col++)
                {
                    for (int k = 0; k < firstMatrix.Col; k++)
                    {
                        newMatrix[row, col] += (dynamic)firstMatrix[row, k] * (dynamic)secondMatrix[k, col];
                    }
                }
            }
            return newMatrix;
        }
        //Implement the true operator (check for non-zero elements).
        public static bool operator true(Matrix<T> firstMatrix)
        {

            for (int row = 0; row < firstMatrix.Row; row++)
            {
                for (int col = 0; col < firstMatrix.Col; col++)
                {
                    if ((dynamic)firstMatrix[row, col] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> firstMatrix)
        {

            for (int row = 0; row < firstMatrix.Row; row++)
            {
                for (int col = 0; col < firstMatrix.Col; col++)
                {
                    if ((dynamic)firstMatrix[row, col] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //Print matrix
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < this.Row; row++)
            {
                for (int col = 0; col < this.Col; col++)
                {
                    result.AppendFormat("{0}, ", matrix[row, col]);
                }
                result.AppendLine();
            }
            return result.ToString();
        }
    }
}
