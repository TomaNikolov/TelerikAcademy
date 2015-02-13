
//Problem 6. Quadratic Equation

//    Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).


using System;


class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter  a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter  b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter  c: ");
        double c = double.Parse(Console.ReadLine());

        double x1 = 0;
        double x2 = 0;
        double d = (b * b) - (4 * a * c);

        if (d < 0)
        {
            Console.WriteLine("No real Roots.");
        }
        if (d == 0)
        {
            x1 = -b / 2 * a;

            Console.WriteLine("x1 = x2 = {0}", x1);
        }
        if (d > 0)
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);

            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
        }
    }
}

