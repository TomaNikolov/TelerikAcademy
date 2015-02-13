
//Problem 2. Get largest number

//    Write a method GetMax() with two parameters that 
//    returns the larger of two integers.
//    Write a program that reads 3 integers from the
//    console and prints the largest of them using the method GetMax().


using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers.");
        Console.Write("First: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Second: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Third: ");
        int z = int.Parse(Console.ReadLine());
        
        if(GetMax(x, y) >= GetMax(y, z))
        {
            Console.WriteLine(GetMax(x, y));
        }
        else
        {
            Console.WriteLine(GetMax(y, z));
        }
    }

    private static int GetMax(int x, int y)
    {
       if(x >= y)
       {
           return x;
       }
       else
       {
           return y;
       }

    }
}

