
//Problem 10. Odd and Even Product

//    You are given n integers (given in a single line, separated by a
//space).
//    Write a program that checks whether the product of the odd 
//elements is equal to the product of the even elements.
//    Elements are counted from 1 to n, so the first element is odd,
//the second is even, etc.


using System;


class OddAndEvenProducts
{
    static void Main()
    {
        Console.Write("Enter a numbers: ");
        string[] numbersInput = Console.ReadLine().Split(' ');
        int[] numbers = new int[numbersInput.Length];
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < numbersInput.Length; i++)
        {
            numbers[i] = int.Parse(numbersInput[i]);
            if (i % 2 == 0)
            {
                evenProduct *= numbers[i];
            }
            else
            {
                oddProduct *= numbers[i];
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Product = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("OddProduct = {0}", oddProduct);
            Console.WriteLine("EvenProduct = {0}", evenProduct);
        }
    }
}

