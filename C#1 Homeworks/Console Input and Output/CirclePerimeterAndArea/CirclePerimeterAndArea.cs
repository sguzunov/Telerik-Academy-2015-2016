using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Type radius");
        double r=double.Parse(Console.ReadLine(),System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        Console.WriteLine("The perimeter is = {0:F2}",2*3.14*r);
        Console.WriteLine("The area is = {0:F2}",3.14*r*r);

          
    }
}

