using System;
using System.Threading;
using System.Globalization;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

        Console.WriteLine("Enter five numbers:");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());
        double num4 = double.Parse(Console.ReadLine());
        double num5 = double.Parse(Console.ReadLine());

        if ((num1 > num2) && (num1 > num3) && (num1 > num4) && (num1 > num5))
        {
            Console.WriteLine("The biggest is: {0}",num1);
        }

        else if ((num2 > num1) && (num2 > num3) && (num2 > num4) && (num2 > num5))
        {
            Console.WriteLine("The biggest is: {0}", num2);
        }

        else if ((num3 > num1) && (num3 > num2) && (num3 > num4) && (num3 > num5))
        {
            Console.WriteLine("The biggest is: {0}", num3);
        }

        else if ((num4 > num1) && (num4 > num2) && (num4 > num3) && (num4 > num5))
        {
            Console.WriteLine("The biggest is: {0}", num4);
        }

        else if ((num5 > num1) && (num5 > num2) && (num5 > num3) && (num5 > num4))
        {
            Console.WriteLine("The biggest is: {0}", num5);
        }

    }
}

