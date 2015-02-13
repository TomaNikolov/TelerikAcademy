
//Problem 15.* Number calculations

//    Modify your last program and try to make it work for any
//    number type, not just integer (e.g. decimal, float, byte, etc.)
//    Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;

class NumberCalculations
{
    static void Main() 
    {

          Console.WriteLine("The Minimum of set integers: {0}", GetMin(1.6, 3.1, 5.2, 4.1));
             Console.WriteLine("The Maximum of set integers: {0}", GetMax(1.6, 3.1, 5.2, 4.1));
              Console.WriteLine("The Average Sum of set integers: {0}", GetAverageSum(1.6, 3.1, 5.2, 4.1));
             Console.WriteLine("The Sum of set integers: {0}", GetSum(1.6, 3.1, 5.2, 4.1));
        Console.WriteLine("The Product of set integers: {0}\n", GetProduct(1.6, 3.1, 5.2, 4.1));
    }

    private static T GetProduct<T>(params T[] numbers)
    {
        dynamic product = 1;
        foreach (var number in numbers)
        {
            product *= number;

        }

        return product;
    }

    private static T GetSum<T>(params T[] numbers)
    {
        dynamic sum = 0;
        foreach (var number in numbers)
        {
            sum += number;

        }
        return sum;
    }

    private static T GetAverageSum<T>(params T[] numbers)
    {
        dynamic average = 0;
        foreach (var number in numbers)
        {
            average += number;

        }
        average /= numbers.Length;
        return average;
    }

    private static T GetMax<T>(params T[] numbers)
    {
        dynamic max = int.MinValue;
        foreach (var number in numbers)
        {
            if (max < number)
            {
                max = number;
            }
        }
        return max;
    }

    private static T GetMin<T>(params T[] numbers)
    {
        dynamic min = int.MaxValue;
        foreach (var number in numbers)
        {
            if (min > number)
            {
                min = number;
            }
        }
        return min;
    }
}

