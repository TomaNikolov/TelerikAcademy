
//Problem 3. Sequence n matrix

//    We are given a matrix of strings of size N x M. 
//    Sequences in the matrix we define as sets of several 
//    neighbour elements located on the same line, column or diagonal.
//    Write a program that finds the longest sequence of equal strings in the matrix.


using System;
using System.Text;

class SequenceNMatrix
{
    static void Main()
    {
        int bestSequence = 0;
        StringBuilder elements = new StringBuilder();
        string bestElement = "";
        string[,] matrix = new string[,]{
            {"ha", "fifi", "ho", "hi"},
            {"fo", "ha", "hi", "xx"},
            {"xxx", "ho", "ha", "xx"}
        };
        //string[,] matrix = new string[,]{
        //    {"s", "qq", "s"},
        //    {"pp", "pp", "s",},
        //    {"pp", "qq", "s"}
        //};
        int dim1 = matrix.GetLength(0);
        int dim2 = matrix.GetLength(1);

        for (int row = 0; row < matrix.GetLength(0); row++)
        {

            string currentElement = "";
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentSequence = 0;
                currentSequence += Right(matrix, row, col, matrix[row, col]);
                currentSequence += Left(matrix, row, col, matrix[row, col]);
                currentSequence += RightDiagonal(matrix, row, col, matrix[row, col]);
                currentSequence += LeftDiagonal(matrix, row, col, matrix[row, col]);
                currentSequence += Down(matrix, row, col, matrix[row, col]);
                currentElement = matrix[row, col];
                currentSequence++;

                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                    bestElement = currentElement;

                }
            }


        }
        for (int i = 0; i < bestSequence; i++)
        {
            Console.Write(bestElement);
            if (i == bestSequence - 1)
            {
                Console.Write("");
            }
            else
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    private static int LeftDiagonal(string[,] matrix, int row, int col, string searchElement)
    {
        
        int result = 0;
        row--;
        col--;
        while (true)
        {
            if (col < 0 ||
                row < 0)
            {
                break;
            }
            if (matrix[row, col] == searchElement)
            {
                result++;
            }
            else
            {
                break;
            }
            row--;
            col--;
        }
        return result;
    }
    

    private static int Down(string[,] matrix, int row, int col, string searchElement)
    {
        int result = 0;
        if (row != matrix.GetLength(0) - 1)
        {
            for (int i = row + 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, col] == searchElement)
                {
                    result++;
                }
                else
                {
                    break;
                }
            }
        }
        return result;
    }

    private static int RightDiagonal(string[,] matrix, int row, int col, string searchElement)
    {
        int result = 0;
        row++;
        col++;
        while (true)
        {
            if (col == matrix.GetLength(1) ||
                row == matrix.GetLength(0))
            {
                break;
            }
            if (matrix[row, col] == searchElement)
            {
                result++;
            }
            else
            {
                break;
            }
            row++;
            col++;
        }
        return result;
    }

    private static int Left(string[,] matrix, int row, int col, string searchElement)
    {
        int result = 0;
        for (int i = col +1; i < matrix.GetLength(1); i++)
        {
            if (matrix[row, i] == searchElement)
            {
                result++;
            }
            else
            {
                break;
            }
        }
        return result;
    }

    private static int Right(string[,] matrix, int row, int col, string searchElement)
    {
        int result = 0;
        for (int i = col -1; i >= 0; i--)
        {
            if (matrix[row, i] == searchElement)
            {
                result++;
            }
            else
            {
                break;
            }
        }
        return result;
    }
}

