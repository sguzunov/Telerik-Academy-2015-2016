using System;

class PointInACircle
{
    static void Main()
    {

        double x, y;
        Console.WriteLine("A circle has a radius 2 cm.Choose coordinates of a point to check if it is inside the circle or not.");
        Console.Write("x=");
        x = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        Console.Write("y=");
        y = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));

        if((x*x)+(y*y)<=(2*2))
            Console.WriteLine("True");
        else Console.WriteLine("False");

    }
}

