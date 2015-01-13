using System;


namespace QuotesInString
{
    class Program
    {
        static void Main()
        {
            string escapingChar= "The \"Use\" of quotations causes difficulties.";
            string doubleQuotes = @"The ""Use"" of quotations causes difficulties.";

            Console.WriteLine(escapingChar);
            Console.WriteLine(doubleQuotes);
        }
    }
}
