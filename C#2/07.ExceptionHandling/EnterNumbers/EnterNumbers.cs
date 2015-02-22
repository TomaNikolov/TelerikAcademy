
//Problem 2. Enter numbers

//    Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//        If an invalid number or non-number text is entered, the method should throw an exception.
//    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;

class EnterNumbers
{
    static void Main()
    {
        const int start = 1;
        const int end = 100;
        try
        {
            Console.WriteLine("Enter 10 numbers (1< n >100): ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}: ", i + 1);
              int num = ReadNumbers(start, end);
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Error " + e.Message);
        }
    }
    static int ReadNumbers(int start, int end)
    {
       
            int numb = int.Parse(Console.ReadLine());
            if (numb < start || numb > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return numb;
    }
}

