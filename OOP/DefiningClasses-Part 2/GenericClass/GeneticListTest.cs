namespace GenericClass
{
    using System;

    public class GeneticListTest
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(3);
            list.Add(3);
            list.Add(3);
            list.Add(1);
            list.Add(3);
            list.Add(7);
            Console.WriteLine(list);
            list.InsertAt(2, 4);
            Console.WriteLine(list);
            int index = list.FindElement(4);
            Console.WriteLine(index);
            list.RemoveAt(2);
            Console.WriteLine(list);
            int max = list.Max();
            Console.WriteLine(max);
            int min = list.Min();
            Console.WriteLine(min);

        }
    }
}
