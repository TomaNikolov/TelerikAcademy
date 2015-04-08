
//Problem 17. Longest string
//    Write a program to return the string with maximum length from an array of strings.
//    Use LINQ.

namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestStringMain
    {
        public static void Main()
        {
            const string input = "Write a program to return the string with maximum length from an array of strings";

            var arrOfString = input.Split(' ').ToArray();

            var longestWord = MaxLenghtWord(arrOfString);

            Console.WriteLine(longestWord);

        }

        public static string MaxLenghtWord(IEnumerable<string> collection)
        {
            var result = (from x in collection
                          orderby x.Count() descending
                          select x);

           // var result2 = collection.OrderByDescending(x => x.Length).ToArray()[0];
            return result.ToArray()[0];
        }
    }
}
