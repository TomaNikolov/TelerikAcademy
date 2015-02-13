
//Problem 7. Reverse number

//    Write a method that reverses the digits of given decimal number.


using System;
using System.Linq;
using System.Text;

class ReverxeNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();
        Console.WriteLine("Reverse number is: " + Reverse(number));
    }

    private static string Reverse(string number)
    {
        StringBuilder result = new StringBuilder();
        for (int i = number.Length - 1; i >= 0; i--)
        {
            result.Append(number[i]);
        }
       
        return result.ToString();
    }
}

