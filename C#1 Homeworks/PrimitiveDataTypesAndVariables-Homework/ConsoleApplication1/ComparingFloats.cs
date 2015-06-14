using System;

class ComparingFloats
{
    static void Main()
    {
       
        double a, b;
        double eps=0.000001;
        Console.WriteLine("Enter the numbers:");
        a = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        b = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        bool equal;
        equal = Math.Abs(a - b) < eps;
        Console.WriteLine(equal);


      

    }
}

