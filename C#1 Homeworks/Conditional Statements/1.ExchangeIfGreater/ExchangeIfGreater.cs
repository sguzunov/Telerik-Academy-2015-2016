using System;
using System.Threading;
using System.Globalization;

class ExchangeIfGreater
{
    static void Main()                                                                   
                                                                                              
    {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        Console.WriteLine("Enter the numbers:");
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine();
        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("{0} {1}", a, b);

        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }

        
    }
}

 