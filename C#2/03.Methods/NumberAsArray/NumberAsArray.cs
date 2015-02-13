
//Problem 8. Number as array

//    Write a method that adds two positive integer numbers represented
//    as arrays of digits (each array element arr[i] contains a digit;
//    the last digit is kept in arr[0]).
//    Each of the numbers that will be added could have up to 10 000 digits.


using System;
using System.Linq;
using System.Collections.Generic;

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        string firstNumber = Console.ReadLine();
        Console.Write("Enter second number: ");
        string secondNumber = Console.ReadLine();
       List <int> result = AddNumber(firstNumber, secondNumber);
        foreach (var digit in result)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }

    private static List<int> AddNumber(string firstNumber, string secondNumber)
    {
        int[] firstNumberArr = firstNumber.Select(x => x - '0').ToArray();
        int[] secondNumberArr = secondNumber.Select(x => x - '0').ToArray();
        Array.Reverse(firstNumberArr);
        Array.Reverse(secondNumberArr);
        List<int> result = new List<int>();
        int left = 0;
        for (int i = 0; i < Max(firstNumber.Length, secondNumberArr.Length); i++)
        {
            int element = 0;
            if (i < firstNumberArr.Length)
            {
                element += firstNumberArr[i];
            }
            if (i < secondNumber.Length)
            {
                element += secondNumberArr[i];
            }
            element += left;
            if(element > 9)
            {
                left = element / 10;
                element %= 10;
            }
            else
            {
                left = 0;
            }
            result.Add(element);

        }
        if(left > 0)
        {
            result.Add(left);
        }
        result.Reverse();
        return result;
    }

    private static int Max(int first, int second)
    {
        if (first >= second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }
}

