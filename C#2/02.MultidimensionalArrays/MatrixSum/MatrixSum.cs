
//Problem 2. Maximal sum

//    Write a program that reads a rectangular matrix of size
//    N x M and finds in it the square 3 x 3 that has maximal sum of its elements.


using System;
using System.Text;

class MatrixSum
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int bestSum = int.MinValue;
        string bestPlatform = "";
        //Comment for test
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = randomGenerator.Next(1, ((n * m) + 1));
            }
        }
        //and uncomment this
        //int n = 4;
        //int n = 6;
        //int[,] matrix = 
        //{
        //    {0, 2, 4, 0, 9, 5},
        //    {7, 1, 3, 3, 2, 1},
        //    {1, 3, 9, 8, 5, 6},
        //    {4, 6, 7, 9, 1, 0},
        //};
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                StringBuilder currentPlatform = new StringBuilder();
                int sum = 0;
                for (int row = i; row < i + 3; row++)
                {
                    for (int col = j; col < j + 3; col++)
                    {
                        sum += matrix[row, col];
                        currentPlatform.AppendFormat("{0}, ", matrix[row, col]);
                    }
                    if(sum > bestSum)
                    {
                        bestSum = sum;
                        bestPlatform = currentPlatform.ToString();
                    }
                }
            }
        }
        Console.WriteLine("Best platform is: " + bestPlatform);
        Console.WriteLine("Maxima sum of the elements is: " + bestSum);
        
    }
}

