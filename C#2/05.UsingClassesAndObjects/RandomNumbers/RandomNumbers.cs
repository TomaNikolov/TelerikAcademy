
//Problem 2. Random numbers

//    Write a program that generates and prints to the console
//    10 random values in the range [100, 200].


using System;

class RandomNumbers
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
			{
                arr[i] = randomGenerator.Next(100, 201);
			}
        Console.WriteLine(string.Join(", ", arr));
    }
}

