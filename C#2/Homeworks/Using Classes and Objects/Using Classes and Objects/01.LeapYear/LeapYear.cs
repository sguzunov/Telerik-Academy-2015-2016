using System;
using System.Collections.Generic;
using System.Threading;

// Write a program that reads a year from the console and checks whether it is a leap one.Use System.DateTime.

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter an year: ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("\n{0} IS a leap year!", year);
        }
        else
        {
            Console.WriteLine("\n{0} IS NOT a leap year!",year);
        }

    }
}

