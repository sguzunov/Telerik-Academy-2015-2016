using System;
using System.Threading;
using System.Globalization;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

        Console.WriteLine("Make your choice!");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3--> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                {
                    Console.WriteLine(@"Enter an ""int"" ");
                    int integerNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("{0}", integerNumber + 1);

                }; break;

            case 2:
                {
                    Console.WriteLine(@"Enter a ""double"" ");
                    double doubleNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("{0}", doubleNumber + 1);

                }; break;

            case 3:
                {
                    Console.WriteLine(@"Enter a ""string"" ");
                    string stringNumber = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("{0}*", stringNumber);

                } break;


        }


    }
}

