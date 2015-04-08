namespace DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DivisibleMain
    {
        public static void Main()
        {
            var intArr = new int[200];

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = i;
            }

            // Lambda
            var allNumbersLambda = intArr.Where(x => x % 7 == 0 && x % 3 == 0);

            //Linq
            var allNumberLinq = from x in intArr
                                where x % 7 == 0 && x % 3 == 0
                                select x;
            Print(allNumbersLambda);
        }

        public static void Print<T>(IEnumerable<T> collection)
        {
            Console.WriteLine(string.Join(", ", collection));
        }
    }
}
