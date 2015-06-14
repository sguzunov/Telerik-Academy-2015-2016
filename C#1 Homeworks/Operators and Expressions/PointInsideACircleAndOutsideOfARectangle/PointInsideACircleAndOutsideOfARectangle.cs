using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        double x, y;
        bool insideCircle, outsideCircle;
        Console.Write("x=");
        x = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        Console.Write("y=");
        y = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));

        insideCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
        outsideCircle = (x > 1) || (x < 6) && (y > -1) || (y < 2);

        if((insideCircle==true)&&(outsideCircle==true))
            Console.WriteLine("It's true");
        else Console.WriteLine("It's false");

    }
}

