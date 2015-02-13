
//Problem 6.* Matrix class

//    Write a class Matrix, to hold a matrix of integers. 
//    Overload the operators for adding, subtracting and 
//    multiplying of matrices, indexer for accessing the matrix content and ToString().


using System;
namespace MatrixClass
{
    class MatrixClass
    {
        static void Main()
        {
            Matrix matrix = new Matrix(5, 5);
            int fillmatrix = 1;
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    matrix[i, j] = fillmatrix;
                    fillmatrix++;
                }
            }
            Matrix matrix2 = new Matrix(5, 5);
            ;
            for (int i = 0; i < matrix2.Row; i++)
            {
                for (int j = 0; j < matrix2.Col; j++)
                {
                    matrix2[i, j] = fillmatrix + 4;
                    fillmatrix++;
                }
            }
            
           Console.WriteLine(matrix.ToString());
           Console.WriteLine();
           Console.WriteLine(matrix2.ToString());
           Console.WriteLine();
           Console.WriteLine((matrix + matrix2).ToString());
           Console.WriteLine();
           Console.WriteLine((matrix - matrix2).ToString());
           Console.WriteLine();
           Console.WriteLine((matrix * matrix2).ToString());
        }
    }

}