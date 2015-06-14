using System;
using System.Threading;
using System.Globalization;

class SumOfFiveNumbers
{
    static void Main()
    {

        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

        Console.WriteLine("Enter 5 numbers i a single line separated by a space:");
        string[] numbers = new string[5];
        decimal sum=0;
        numbers = Console.ReadLine().Split();
        for(int i=0;i<5;i++)
        {

            sum=sum+ Convert.ToDecimal(numbers[i]);

        }
        Console.WriteLine();
        Console.WriteLine("The sum is:{0}",sum);
        

        
    }
}

 