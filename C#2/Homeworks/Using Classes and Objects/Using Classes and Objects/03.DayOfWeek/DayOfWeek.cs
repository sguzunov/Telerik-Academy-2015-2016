using System;
using System.Collections.Generic;
using System.Threading;

// Write a program that prints to the console which day of the week is today.Use System.DateTime.

class Program
{
    static void Main()
    {
        DateTime day = DateTime.Today;

        Console.WriteLine(day.ToString("D"));

    }
}

