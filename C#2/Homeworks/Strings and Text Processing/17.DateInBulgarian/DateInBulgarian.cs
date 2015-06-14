using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/*
 Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian. 
 */

class DateInBulgarian
{
    static void Main()
    {

        Console.WriteLine("Enter a date in format [day.month.year hour:minute:second]");
        DateTime date = new DateTime();
        date = DateTime.Parse(Console.ReadLine());

        date = date.AddHours(6);
        date = date.AddMinutes(30);

      //  Console.WriteLine("{0:HH:mm}",date);

        Console.InputEncoding = Encoding.UTF8;

        var culture = new System.Globalization.CultureInfo("bg-BG");

        Console.WriteLine(date.ToString(culture));

    }
}

