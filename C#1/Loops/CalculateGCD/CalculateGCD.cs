
//Problem 17.* Calculate GCD

//    Write a program that calculates the greatest common divisor (GCD)
//of given two integers a and b.
//    Use the Euclidean algorithm (find it in Internet).


using System;



class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        do
        {
            if (a < b)
            {
                int c = a;
                a = b;
                b = c;
            }
            if (b != 0)
            {
                int swap = b;
                b = a % b;
                a = swap;
            }
        } while (b != 0);

        Console.WriteLine("GCD is : " + a);
    }


}

