
//Problem 1. Fill the matrix

//    Write a program that fills and prints a matrix of size (n, n) as shown below:


using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n =int.Parse(Console.ReadLine());
        Console.Write("Choose a, b, c or d: ");
        string choose = Console.ReadLine();
        int[,] matrix = new int[n, n];
        if (choose == "a")
        {
            FillAMatrix(matrix, n);
        }
        if (choose == "b")
        {
            FillBMatrix(matrix, n);
        }
        if (choose == "c")
        {
            FillCMatrix(matrix, n);
        }
        if (choose == "d")
        {
            FillDMatrix(matrix, n);
        }
        PrintMatrix(matrix, n);
    }

    private static void FillDMatrix(int[,] matrix, int n)
    {
        int counter = 1;
        int row = 0;
        int col = 0;
        int position = 0;
        int rowEnd = n;
        int colEnd = n;
        while (counter != (n * n) + 1 )
        {
            //down
            while (row != n)
            {
                 if( matrix[row ,col] != 0)
                 {
                     break;
                 }
                matrix[row, col] = counter;
                row++;
                counter++;

            }
            row--;
            col++;
            //right
             while (col != n)
            {
                if ( matrix[row,col] != 0)
                {
                    break;
                }
                matrix[row, col] = counter;
                col++;
                counter++;
            }
             col--;
             row--;
            //Up
            while (row != -1)
            {
                if ( matrix[row , col] != 0)
                {
                    break;
                }
                matrix[row, col] = counter;
                row--;
                counter++;
            }
            row++;
            col--;
            //Left 
            while (col != -1)
            {
                if ( matrix[row, col] != 0)
                {
                    
                    break;
                }  
                matrix[row, col] = counter;
                col--;
                counter++;
              
            }
            col++;
            row++;
        }
    }

    private static void FillCMatrix(int[,] matrix, int n)
    {
        int counter = 1;
        int row = n - 1;
        int col = 1;
        int rowLastPosition = row;
        int colLastPosition = 0;

        for (int i = row; i >= 0; i--)
        {
            rowLastPosition = i;
            for (int j = 0; j < n - i; j++)
            {

                matrix[rowLastPosition, j] = counter;
                rowLastPosition++;
                counter++;
            }

        }
        for (int i = col; i < n; i++)
        {
            colLastPosition = i;
            for (int j = 0; j < n - i; j++)
            {
                matrix[j, colLastPosition] = counter;
                counter++;
                colLastPosition++;
            }
        }
    }

    private static void FillBMatrix(int[,] matrix, int n)
    {
        int counter = 1;
        int row = 0;
        int col = 0;
        while (counter != (n * n) + 1)
        {
            matrix[row, col] = counter;
            if (row != 3)
            {
                row++;
            }
            else
            {
                row = 0;
                col++;
            }
            counter++;
        }
    }

    private static void PrintMatrix(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    private static void FillAMatrix(int[,] matrix, int n)
    {
        int counter = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[j, i] = counter;
                counter++;
            }
        }
    }
}

