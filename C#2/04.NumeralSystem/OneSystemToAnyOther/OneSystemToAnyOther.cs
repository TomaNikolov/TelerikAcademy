
//Problem 7. One system to any other

//    Write a program to convert from any numeral system of given base
//    s to any other numeral system of base d (2 ≤ s, d ≤ 16).


using System;
using System.Text;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter system base s: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter system base d: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        string inputstring = Console.ReadLine();
        long decimalNumber = Convert.ToInt64(inputstring, s);

        if (d == 10)
        {
            Console.WriteLine("Number in {0} base system is:{1}", d, decimalNumber);
        }
        else
        {
            string result = ConvertNumber(decimalNumber, d);
            Console.WriteLine("Number in {0} base system is:{1}", d, result);
        }
    }

    private static string ConvertNumber(long decimalNumber, int d)
    {
        StringBuilder result = new StringBuilder();

        while (decimalNumber > 0)
        {
            long remainder = decimalNumber % d;
            result.Insert(0, SwitchNumbers(remainder));
            decimalNumber /= d;
        }
        return result.ToString();
    }

    private static string SwitchNumbers(long remainder)
    {
        switch (remainder)
        {

            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
                return remainder.ToString();
            case 10: return "A";
            case 11: return "B";
            case 12: return "C";
            case 13: return "D";
            case 14: return "E";
            case 15: return "F";
            default: throw new Exception("Incorect numerical system");
                
        }
    }
}

