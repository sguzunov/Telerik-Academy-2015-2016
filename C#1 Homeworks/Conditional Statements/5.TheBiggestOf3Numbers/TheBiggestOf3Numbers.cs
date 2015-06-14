using System;
using System.Threading;
using System.Globalization;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

        Console.WriteLine("Enter three numbers:");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        if ((num1 > num2) && (num1 > num3))
        {

            Console.WriteLine("The biggest is: {0}",num1);

        }

        else if ((num2 > num1) && (num2 > num3))
        {

            Console.WriteLine("The biggest is: {0}", num2);

        }

        else if ((num3 > num1) && (num3 > num2))
        {

            Console.WriteLine("The biggest is: {0}", num3);

        }






    }
}

