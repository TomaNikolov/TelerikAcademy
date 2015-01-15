using System;

namespace NumbersAsWords
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            string[] zeroToNineteenSmall = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten","eleven",
             "twelve", "thirteen", "sourteen", "sifteen", "sixtee", "sevenTeen", "eighteen", "nineteen" };

            string[] zeroToNineteen = new string[] {"Zero", "One","Two","Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten","Eleven",
             "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixtee", "SevenTeen", "Eighteen", "Nineteen"};

            string[] twentyToNinty = new string[] {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            string[] twentyToNintySmall = new string[] {"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string numberToWords = "";

            if(number <= 19)
            {
                Console.WriteLine(zeroToNineteen[number]);
            }
            if(number > 19 && number <= 99)
            {
                int a = number / 10;
                int b = number % 10;
                numberToWords += twentyToNinty[a - 2]; 
                if(b != 0)
                {
                    numberToWords += " " + zeroToNineteenSmall[b];
                }
            }
            if(number >= 100)
            {
                int a = number / 100;
                int b = number / 10;
                int c = (number % 100) % 10;
              numberToWords += zeroToNineteen[a] + " " + "hundred";
                if(b != 0)
                {
                    if(b <= 19)
                    {
                        numberToWords += " " + "and" + " " + zeroToNineteenSmall[b];
                    }
                    else
                    {
                        numberToWords += " " + "and" + " " + twentyToNintySmall[(b % 10 ) -2 ];
                    }
                }
                if(c != 0)
                {
                    numberToWords += " " + zeroToNineteenSmall[c];
                }
            }
            Console.WriteLine(numberToWords);
        }
    }
}
