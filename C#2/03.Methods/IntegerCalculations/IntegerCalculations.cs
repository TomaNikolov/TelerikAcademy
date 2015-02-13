
//Problem 14. Integer calculations

//    Write methods to calculate minimum, maximum, average,
//    sum and product of given set of integer numbers.
//    Use variable number of arguments.

using System;
using System.Collections.Generic;

class IntegerCalculations
{
    static void Main()
    {
        
        HashSet<int> set = new HashSet<int>();
        //set.Add(1);
        //set.Add(2);
        //set.Add(3);
        //set.Add(4);
        //set.Add(5);
        //set.Add(6);
        //set.Add(7);
        //set.Add(8);
        //set.Add(9);
        Console.WriteLine("The Minimum of set integers: {0}", GetMin(set));
        Console.WriteLine("The Maximum of set integers: {0}", GetMax(set));
        Console.WriteLine("The Average Sum of set integers: {0}", GetAverageSum(set));
        Console.WriteLine("The Sum of set integers: {0}", GetSum(set));
        Console.WriteLine("The Product of set integers: {0}\n", GetProduct(set));
    }

    private static int GetProduct(HashSet<int> set)
    {
        int product = 1;
        foreach (var number in set)
        {
            product *= number;

        }

        return product;
    }

    private static int GetSum(HashSet<int> set)
    {
        int sum = 0;
        foreach (var number in set)
        {
            sum += number;

        }
        return sum;
    }

    private static int GetAverageSum(HashSet<int> set)
    {
        int average = 0;
        foreach (var number in set)
        {
                average += number;
            
        }
        average /= set.Count;
        return average;
    }

    private static int GetMax(HashSet<int> set)
    {
        int max = int.MinValue;
        foreach (var number in set)
        {
            if (max < number)
            {
                max = number;
            }
        }
        return max;
    }

    private static int GetMin(HashSet<int> set)
    {
        int min = int.MaxValue;
        foreach (var number in set)
        {
            if(min > number)
            {
                min = number;
            }
        }
        return min;
    }
}
