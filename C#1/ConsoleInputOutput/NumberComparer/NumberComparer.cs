
//Problem 4. Number Comparer

//    Write a program that gets two numbers from the console and prints the greater of them.
//    Try to implement this without if statements.


using System;


class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter  a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter  b: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("The greater is {0}.", (a > b) ? a : b);
    }
}

