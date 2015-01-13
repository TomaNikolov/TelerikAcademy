using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("Square root of number {0} is {1}.", number, squareRoot);
        }
    }
}
