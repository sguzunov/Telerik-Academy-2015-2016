using System;
using System.Collections.Generic;
using System.Threading;

/*
 
     Write a method that calculates the number of workdays between today and given date, passed as parameter.
     Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */


class Workdays
{
    static DateTime[] holydays =
    {
        new DateTime(2015,3,2),
        new DateTime(2015,3,3),
        new DateTime(2015,4,10),
        new DateTime(2015,4,13),
        new DateTime(2015,5,1),
        new DateTime(2015,5,6),
        new DateTime(2015,9,21),
        new DateTime(2015,9,22),
        new DateTime(2015,12,24),
        new DateTime(2015,12,25),
        new DateTime(2015,12,31)
    };

    static bool isHolyday(DateTime date)
    {      
        foreach (var dt in holydays)
        {
            if (date.Year == dt.Year && date.Month == dt.Month && date.Day == dt.Day)
            {
                return true;
            }
        }
        return false;
    }

    static void Main()
    {        
        DateTime end;
        DateTime start = DateTime.Now;
        int workDays = 0;

        do
        {
            Console.Write("Enter a date after today: ");
            end = DateTime.Parse(Console.ReadLine());
        }
        while (end < start);

        while (start.Year != end.Year || start.Month != end.Month || start.Day != end.Day)
        {
            if (start.DayOfWeek != DayOfWeek.Saturday && start.DayOfWeek != DayOfWeek.Sunday && isHolyday(start) == false)
            {
                workDays++;
            }
            start = start.AddDays(1);
        }

        Console.WriteLine("Workdays between {0} and {1} are {2}.", start, end, workDays);

    }
}

