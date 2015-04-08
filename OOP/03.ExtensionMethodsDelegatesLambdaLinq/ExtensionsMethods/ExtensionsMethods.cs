namespace ExtensionsMethods
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExtensionsMethods
    {
        static void Main()
        {
            //Test StringBuilder extension
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Pesho");
            stringBuilder = stringBuilder.Substring(1, 4);
            Console.WriteLine(stringBuilder);

            //Test IEnumerable extensions
            var testList = new List<int>
            {
                2, 3, 4, 5, 6, 7,
            };

            //Sum
            var sum = testList.Sum();
            Console.WriteLine(sum);

            //Min
            var min = testList.Min();
            Console.WriteLine(min);

            //Max
            var max = testList.Max();
            Console.WriteLine(max);

            //Average
            var average = testList.Average();
            Console.WriteLine(average);

            //Product 
            var product = testList.Product();
            Console.WriteLine(product);
            
        }
    }
}
