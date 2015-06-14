using System;
using System.Threading;
using System.Globalization;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

        Console.WriteLine("Enter three numbers:");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        if ((num1 == num2) && (num2 == num3))
        {
            Console.WriteLine("Sorted: {0} {1} {2}",num1,num2,num3);
        }

        if ((num1 > num2)&&(num1>num3))
        {
            if (num2 < num3)
            {
                Console.WriteLine("Sorted: {0} {1} {2}", num2, num3 ,num1);
            }
            else
            {
                 Console.WriteLine("Sorted: {0} {1} {2}",num3,num2,num1);
            }
        }

        if ((num2 > num1)&&(num2 > num3))
        {
            if (num1 < num3)
            {
                Console.WriteLine("Sorted: {0} {1} {2}", num1, num3, num2);
            }
            else
            {
                 Console.WriteLine("Sorted: {0} {1} {2}",num3,num1,num2);
            }
        }

        if ((num3 > num1)&&(num3>num2))
        {
            if (num2 < num1)
            {
                Console.WriteLine("Sorted: {0} {1} {2}", num2, num1, num3);
            }
            else
            {
                 Console.WriteLine("Sorted: {0} {1} {2}",num1,num2,num3);
            }
        }
        

    }
}

