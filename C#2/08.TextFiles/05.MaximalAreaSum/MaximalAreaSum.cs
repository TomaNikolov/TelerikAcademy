
//Problem 5. Maximal area sum

//    Write a program that reads a text file containing a square matrix of numbers.
//    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//        The first line in the input file contains the size of matrix N.
//        Each of the next N lines contain N numbers separated by space.
//        The output should be a single number in a separate text file.


using System;
using System.IO;

namespace _05.MaximalAreaSum
{
    class MaximalAreaSum
    {
        static void Main(string[] args)
        {
            try
            {
                string firstFilPath = @"..\..\matrix.txt"; 
                StreamReader streamReader = new StreamReader(firstFilPath);
                string[] textLine;
                    using (streamReader)
                    {
                        int n = int.Parse(streamReader.ReadLine());
                        int[,] matrix = new int[n, n];
                        for (int i = 0; i < n; i++)
                        {
                            textLine = streamReader.ReadLine().Split(' ');
                            for (int j = 0; j < n; j++)
                            {
                                matrix[i, j] = int.Parse(textLine[j]);
                            }
                        }
                        int maxSum = int.MinValue;
                        for (int i = 0; i < n - 1; i++)
                        {
                            for (int j = 0; j < n - 1; j++)
                            {
                                int currentSum = 0;
                                for (int k = i; k < i + 2; k++)
                                { 
                                    for (int m = j ; m <j + 2; m++)
                                    {
                                        currentSum += matrix[k, m];
                                    }
                                }
                                if (maxSum < currentSum)
                                {
                                    maxSum = currentSum;
                                }
                            }
                        }
                       string writeFailPath = @"..\..\result.txt"; 
                        StreamWriter streamWriter = new StreamWriter(writeFailPath);
                        using (streamWriter)
                        {
                            streamWriter.WriteLine(maxSum);
                        }
                    }

                }
            catch (OutOfMemoryException)
            {

                Console.WriteLine("Input file is too big!");
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("File not found, or you don't have administrator permissions");
            }
            catch (ArgumentNullException)
            {

                Console.WriteLine("Some Method received a null argument!");
            }
            catch (IOException)
            {

                Console.WriteLine("An IO exception occurred");
            }

        }
    }
}
