using System;

class Trapezoids
{
    static void Main()
    {
        double a, b, h,area;
        Console.WriteLine("Insert the longer side: ");
        a = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        Console.WriteLine("Insert the other side: ");
        b = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        Console.WriteLine("Insert the height: ");
        h = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        area = ((a + b) * h) / 2;
        Console.WriteLine("This trapezoid has an area: {0}",area);





    }
}

