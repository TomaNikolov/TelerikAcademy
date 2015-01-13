using System;

namespace GravitationOnTheMoon
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter Earth weight: ");
            double earthWeight = double.Parse(Console.ReadLine());
            double moonWeight = earthWeight * 0.17;
            Console.WriteLine("The weight on the moon will be: {0}", moonWeight);
        }
    }
}
