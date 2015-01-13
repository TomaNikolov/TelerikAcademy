using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a four-digit number: ");

            int number = int.Parse(Console.ReadLine());
            int[] digits = new int[4];
            int sum = 0;

            for (int i = 0; i < 4; i++)
            {
                digits[i] = number % 10;
                number = number / 10;
                 sum += digits[i];
            }

            PrintNumbers(digits);

            Console.WriteLine(sum);

            Array.Reverse(digits);

            LastDigitFirst(digits);

            ExchangeSecondAndThird(digits);
        }

        public static void LastDigitFirst(int[] digits)
        {
            int changer = 0;
            int[] copyOfDigit = new int[digits.Length];

            for (int i = 0; i < digits.Length; i++)
            {
                copyOfDigit[i] = digits[i];
            }

            for (int i = copyOfDigit.Length - 1; i >= 0; i--)
            {


                if (i == copyOfDigit.Length - 1)
                {
                    changer = copyOfDigit[i];
                }
                else
                {
                    copyOfDigit[i + 1] = copyOfDigit[i];
                }
                if (i == 0)
                {
                    copyOfDigit[i] = changer;
                }

            }

            PrintNumbers(copyOfDigit);

        }

        public static void ExchangeSecondAndThird(int [] digits)
        {


           int  changer = digits[1];
            digits[1] = digits[2];
            digits[2] = changer;

            PrintNumbers(digits);


        }

        public static void PrintNumbers(int [] numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(number);
                
            }
            Console.WriteLine();
        }
    }
}
