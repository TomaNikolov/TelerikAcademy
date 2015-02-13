
//Problem 18.* Trailing Zeroes in N!

//    Write a program that calculates with how many zeroes the
//factorial of a given number n has at its end.
//    Your program should work well for very big numbers, e.g. n=100000.


using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            FillMatrix(matrix, n);

            PrinMatrix(matrix, n);

          
        }

        private static void PrinMatrix(int[,] matrix, int n)
        {

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    Console.Write("{0,3}", matrix[i, j]);

                }

                Console.WriteLine();

            }

           
        }

        private static void FillMatrix(int[,] matrix, int n)
        {
            int count = n * n;
            int positionX = 0;
            int positionY = 0;

            int step = 1;

            int direction = 0;

            for (int i = 1; i <= count; i++)
            {
                matrix[positionX, positionY] = i;

                if (positionX == 0 && positionY <= n)
                {
                    direction = 0;
                    if (positionY == n)
                    {
                        positionX++;
                    }
                }
                if (positionY == n && positionX != 0)
                {
                    direction = 3;
                    if (positionX == n)
                    {
                        positionY--;
                    }
                }
                if (positionX == n && positionY < n)
                {
                    direction = 1;
                    if (positionX == n && positionX == 0)
                    {
                        positionX++;
                    }
                }

            }

            switch (direction)
            {
                case 0:
                    positionY++;
                    break;
                case 1:
                    positionX--;
                    break;
                case 2:
                    positionY--;
                    break;
                case 3:
                    positionX++;
                    break;
                default:
                    break;
            }
        }
    }
}
