
//Problem 4. Triangle surface

//    Write methods that calculate the surface of a triangle by given:
//        Side and an altitude to it;
//        Three sides;
//        Two sides and an angle between them;
//    Use System.Math.


using System;

class TriangleSurface
{
    static void Main()
    {
        int choice = Menu();
        switch (choice)
        {
            case 1 :
                SideAndAtitude();
                break;
            case 2 :
                TreeSide();
                break;
            case 3 :
                TwoSideAndAngle();
                break;
            default:
                Menu();
                    break;
        }
    }

    private static void TwoSideAndAngle()
    {
        Console.Write("Enter side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter angle: ");
        double angle = double.Parse(Console.ReadLine());
        double sinAngle = Math.Sin(angle);
        double surface = ((a * b * sinAngle) / 2);

        Console.WriteLine("Surface is: {0}", surface.ToString("F3"));
    }

    private static void TreeSide()
    {
        Console.Write("Enter side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter side c: ");
        double c = double.Parse(Console.ReadLine());
        double perimeter = (a + b + c) / 2;
        double surface = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));

        Console.WriteLine("Surface is: {0}", surface.ToString("F3"));
    }

    private static void SideAndAtitude()
    {
        Console.Write("Enter side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter atitude h: ");
        double h = double.Parse(Console.ReadLine());

        double surface = (a * h) / 2;
        Console.WriteLine("Surface is: {0}", surface.ToString("F3"));
    }

    private static int Menu()
    {
        Console.WriteLine("########################################################################");
        Console.WriteLine("#                                 Menu                                 #");
        Console.WriteLine("########################################################################");
        Console.WriteLine("#                                                                      #");
        Console.WriteLine("#  Calculate4 the surface ot triangle:                                 #");
        Console.WriteLine("#  For side and an altitude to it, press 1.                            #");
        Console.WriteLine("#  For three side, press 2.                                            #");
        Console.WriteLine("#  For two sides and an angle between them, press 3.                   #");
        Console.WriteLine("#                                                                      #");
        Console.WriteLine("########################################################################");
        Console.Write(">>  Enter a choice: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
}

