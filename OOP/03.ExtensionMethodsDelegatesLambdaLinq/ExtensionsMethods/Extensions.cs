namespace ExtensionsMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Extensions
    {
        /// <summary>
        /// Return new StringBuilder starting from index  
        /// </summary>
        /// <param name="stringBuilder"></param>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        //Problem 1. StringBuilder.Substring
        public static StringBuilder Substring(this StringBuilder stringBuilder, int index, int length)
        {
            if (index < 0 || (index + length - 1) >= stringBuilder.Length)
            {
                throw new IndexOutOfRangeException();
            }
            string currentString = stringBuilder.ToString();
            StringBuilder result = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                result.Append(currentString[i]);
            }
            return result;
        }

        public static T Sum<T>(this IEnumerable<T> enumeration)
        {
            T result = (dynamic)0;
            foreach (var item in enumeration)
            {
                result += (dynamic)item;
            }
            return result;
        }

        public static T Min<T>(this IEnumerable<T> enumeration)
            where T : IComparable
        {
                T result = enumeration.First();

                foreach (var item in enumeration)
                {
                    if (result.CompareTo(item) > 0)
                    {
                        result = item;
                    }
                }
                return result;
        }

        public static T Max<T>(this IEnumerable<T> enumeration)
             where T: IComparable 
        {
            T result = enumeration.First();

            foreach (var item in enumeration)
            {
                if (result.CompareTo(item) < 0)
                {
                    result = item;
                }
            }
            return result;
        }

        public static T Product<T>(this IEnumerable<T> enumeration)
        {
            T result = (dynamic)1;
            foreach (var item in enumeration)
            {
                result *= (dynamic)item;
            }
            return result;
        }

        public static T Average<T>(this IEnumerable<T> enumeration)
        {
            return enumeration.Sum() / (dynamic)enumeration.Count(); 
        }
    }
}
