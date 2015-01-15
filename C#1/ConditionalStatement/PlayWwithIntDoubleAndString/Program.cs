

    //Write a program that, depending on the user’s choice, inputs an int, double or string variable.
    //    If the variable is int or double, the program increases it by one.
    //    If the variable is a string, the program appends * at the end.
    //Print the result at the console. Use switch statement.


using System;

namespace PlayWwithIntDoubleAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"
Please choose a type:
1  --> int
2  --> Double     
3  --> String
: ");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.Write("Please enter a int: ");
                       int intChoise = int.Parse(Console.ReadLine());
                    Console.WriteLine(intChoise +1);
                    break;
                     case 2:
                    Console.Write("Please enter a double: ");
                       double doubleChoise = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleChoise +1);
                    break;
                     case 3:
                    Console.Write("Please enter a string: ");
                       string stringChoise = Console.ReadLine();
                    Console.WriteLine(stringChoise +"*");
                    break;
                default:
                    break;
            }
        }
    }
}
