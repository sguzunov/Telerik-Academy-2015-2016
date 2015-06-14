using System;

class NumberComparer
{
    static void Main()
    {
        double a, b, c;
        Console.Write("a=");
        a = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        b = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        c = Math.Abs(a + b / 2) + Math.Abs(a - b / 2);
        Console.WriteLine("The greater one is:{0}",c);



    }
}

