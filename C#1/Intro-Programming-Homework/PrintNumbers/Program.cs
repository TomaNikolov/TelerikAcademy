using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 101, 1001 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
