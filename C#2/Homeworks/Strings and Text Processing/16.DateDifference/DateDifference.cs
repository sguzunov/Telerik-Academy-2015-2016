using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

class DateDifference
{
    static void Main()
    {
        DateTime first = DateTime.Parse(Console.ReadLine());
        DateTime second = DateTime.Parse(Console.ReadLine());

        double result = (first - second).TotalDays;

        Console.WriteLine("The difference is: {0}",Math.Abs(result));
    }
}

