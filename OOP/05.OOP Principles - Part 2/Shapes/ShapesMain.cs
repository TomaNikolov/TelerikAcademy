namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShapesMain
    {
        static void Main()
        {
            // Write a program that tests the behaviour of the CalculateSurface()
            // method for different shapes (Circle, Rectangle, Triangle) stored in an array.
            var shapeArray = new Shape[]
            {
                new Rectanngle(4, 4),
                new Rectanngle(3, 6),
                new Rectanngle(2, 1),
                new Triangle(3, 5),
                new Triangle(2, 1),
                new Triangle(5, 9),
                new Circle(7),
                new Circle(5),
                new Circle(4),
            };
            //Print surface
            shapeArray.TestCalculateSurface(x => Console.WriteLine(x.CalculateSurface()));
        }
    }
}