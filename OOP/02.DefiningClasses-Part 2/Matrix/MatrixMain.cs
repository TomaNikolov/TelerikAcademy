namespace Matrix
{
    using System;

    public class MatrixMain
    {
        static void Main()
        {
            //Test of matrix class
            Matrix<int> firstMatrix = new Matrix<int>(4, 4);
            Matrix<int> secondMatrix = new Matrix<int>(4, 4);
            for (int i = 0; i < firstMatrix.Row; i++)
            {
                for (int j = 0; j < firstMatrix.Col; j++)
                {
                    firstMatrix[i, j] = j + i + 1;
                    secondMatrix[i, j] = j + i + 2;
                }
            }
            System.Console.WriteLine(firstMatrix);
            System.Console.WriteLine(secondMatrix);

            if (firstMatrix)
            {
                Matrix<int> newMatrix = firstMatrix + secondMatrix;
                System.Console.WriteLine(newMatrix);
            }
        }
    }
}
