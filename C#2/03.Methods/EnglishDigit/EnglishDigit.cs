
//Problem 3. English digit

//    Write a method that returns the last digit of given integer as an English word.


using System;

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
       Console.WriteLine(NumberAsWord(number));
    }

    private static string NumberAsWord(int number)
    {
        string result = "";
        int digit = number % 10;
        switch (digit)
        {
            case 0:
                result = "Zero";
                break;
            case 1:
                result = "One";
                break;
            case 2:
                result = "Two";
                break;
            case 3:
                result = "Three";
                break;
            case 4:
                result = "Four";
                break;
            case 5:
                result = "Five";
                break;
            case 6:
                result = "Six";
                break;
            case 7:
                result = "Seven";
                break;
            case 8:
                result = "Eight";
                break;
            case 9:
                result = "Nine";
                break;
        }
        return result;
    }
}

