using System;

namespace ComparingFloats
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double firsNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double precision = 0.000001; //double.Parse(Console.WriteLine());

            Console.WriteLine(EqualsWhitPrecision(firsNumber, secondNumber, precision), precision);
        }

        private static string EqualsWhitPrecision(double firsNumber, double secondNumber, double precision)
        {
            if(Math.Abs(firsNumber - secondNumber) < precision)
            {
                return "The Numbers are equal whit precision eps={0}.";
            }
            else
            {
                return "The Numbers is not equal whit precision eps={0}.";
            }
        }
    }
}
