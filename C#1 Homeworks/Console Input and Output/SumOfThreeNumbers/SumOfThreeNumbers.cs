using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Input your numbers:");
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        Console.WriteLine();
        Console.WriteLine("The sum of {0} and {1} is {2}",a,b,a+b);
       



    }
}

