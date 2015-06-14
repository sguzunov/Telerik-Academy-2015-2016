using System;
using System.Threading;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        CultureInfo enUS = new CultureInfo("en-US");

        DateTime dt;
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime stopTime = DateTime.Parse("3:00 PM");
        Console.WriteLine("Enter beer time!");
        string input = Console.ReadLine();


        if (DateTime.TryParseExact(input, "h:mm tt", enUS,
                                 DateTimeStyles.None, out dt))
        {
            if ((dt >= startTime) || (dt <= stopTime))
            {
                Console.WriteLine("BEER TIME");
            }
            else
            {

                Console.WriteLine("NOT BEER TIME");
            }
        }

        else
        {
            Console.WriteLine("Invalid time!");
        }


    }

}


