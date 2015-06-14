using System;
using System.Collections.Generic;
using System.Threading;

/*
    Write methods that calculate the surface of a triangle by given:
    -Side and an altitude to it;
    - Three sides;
    -Two sides and an angle between them;
    Use System.Math.
 */

class TriangleSurface
{
    static void Main()
    { 
        Console.WriteLine("1-Side and an altitude to it" + "\n2-Three sides" + "\n3-Two sides and an angle between them");
        Console.Write("Choose one of the options: ");
        byte option = byte.Parse(Console.ReadLine());
                

        if (option == 1)
        {
            SurfaceBySideAndAnAltitude();
        }
        else if (option == 2)
        {
            SurfaceByThreeSides();
        }
        else if (option == 3)
        {
            SurfaceByAngle();
        }
       
    }

    static void SurfaceBySideAndAnAltitude()
    {
        Console.Write("\nEnter a length of a side: ");
        decimal side = decimal.Parse(Console.ReadLine());
        side = Math.Abs(side);

        Console.Write("Enter a length of an altitude: ");
        decimal altitude = decimal.Parse(Console.ReadLine());
        altitude = Math.Abs(altitude);

        Console.WriteLine("Surface is: {0}",(side*altitude)/2);

    }

    static void SurfaceByAngle()
    {
        double a, b, angle;

        Console.Write("\nEnter a length of the first side: ");
        a = Math.Abs(double.Parse(Console.ReadLine()));

        Console.Write("\nEnter a length of the second side: ");
        b = Math.Abs(double.Parse(Console.ReadLine()));

        Console.Write("\nEnter an angle: ");
        angle = Math.Abs(double.Parse(Console.ReadLine()));

        Console.WriteLine("Surface is: {0:F2}", (a * b * Math.Sin((Math.PI * angle / 180))) / 2);

    }

    static void SurfaceByThreeSides()
    {
        double a, b, c;

        Console.Write("\nEnter a length of the first side: ");
        a = Math.Abs(double.Parse(Console.ReadLine()));

        Console.Write("\nEnter a length of the second side: ");
        b = Math.Abs(double.Parse(Console.ReadLine()));
        do
        {
            Console.Write("\nEnter a length of the third side: ");
            c = Math.Abs(double.Parse(Console.ReadLine()));

        }
        while (c > (a + b));

        double p = (a + b + c) / 2;

        Console.WriteLine("Surface is: {0:F2}", Math.Sqrt(p*(p-a)*(p-b)*(p-c)));

    }       

}

