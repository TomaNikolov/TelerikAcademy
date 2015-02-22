


using System;

class StringLenght
{
    const int stringLength = 20; 
    static void Main()
    {
        string inputString;
        do
        {
            Console.WriteLine("Max text length is {0}", stringLength);
            Console.Write(">>");
            inputString = Console.ReadLine();

        } while (inputString.Length > stringLength);

        Console.WriteLine(inputString.PadRight(20, '*'));
    }
}

