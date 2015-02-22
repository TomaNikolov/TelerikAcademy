using System;

class FormatNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Decima: {0,15}", number);
        Console.WriteLine("Hexadecimal: {0,15}", number.ToString("X4"));
        Console.WriteLine("Procentage: {0,15}", number.ToString("P"));
        Console.WriteLine("Scientific notation: {0,15}", number.ToString("E"));
    }
}

