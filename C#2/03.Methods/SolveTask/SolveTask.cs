
//Problem 13. Solve tasks

//    Write a program that can solve these tasks:
//        Reverses the digits of a number
//        Calculates the average of a sequence of integers
//        Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to 
//        choose which task to solve.
//        Validate the input data:
//        The decimal number should be non-negative
//        The sequence should not be empty
//        a should not be equal to 0


using System;
using System.Text;

class SolveTask
{
    static void Main()
    {
        int choice = Menu();

        switch (choice)
        {
            case 1:
                Reverse();
                break;
            case 2:
                GetAverageSum();
                break;
            case 3:
                LinearEquation();
                break;
            default:
                Menu();
                break;
        }

    }

    private static void LinearEquation()
    {
        Console.Write("Enter A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        int b = int.Parse(Console.ReadLine());
        double result = (double)-b / a;
        Console.WriteLine("X is: {0}", result);
    }

    private static int Menu()
    {
        Console.WriteLine("########################################################################");
        Console.WriteLine("#                                 Menu                                 #");
        Console.WriteLine("########################################################################");
        Console.WriteLine("#                                                                      #");
        Console.WriteLine("#  Choose whot to do:                                                  #");
        Console.WriteLine("#  For reversing the digits of a number, press 1.                      #");
        Console.WriteLine("#  For calculating the average of a sequence of integers, press 2.     #");
        Console.WriteLine("#  For solving a linear equation a * x + b = 0, press 3.               #");
        Console.WriteLine("#                                                                      #");
        Console.WriteLine("########################################################################");
        Console.Write(">>  Enter a choice: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }

    private static void Reverse()
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();


        StringBuilder result = new StringBuilder();
        for (int i = number.Length - 1; i >= 0; i--)
        {
            result.Append(number[i]);
        }

        Console.WriteLine("Reverse number is: " + result);
    }
    private static void GetAverageSum()
    {
        Console.Write("Enter size of sequence: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Element {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
        }
        int average = 0;
        foreach (var number in arr)
        {
            average += number;

        }
        average /= arr.Length;
        Console.WriteLine("The Average Sum of set integers: {0}", average);
    }

}
