using System;

class Rectangles
{
    static void Main()
    {
        double width, heigth;
        Console.WriteLine("Input width:");
        width = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        Console.WriteLine("Input heigth:");
        heigth = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        Console.WriteLine("Rectangle’s perimeter is:{0}",(2*width)+(2*heigth));
        Console.WriteLine("Rectangle’s area is:{0}", width*heigth);     



    }
}

