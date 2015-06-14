using System;
using System.Threading;
using System.Globalization;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

        Console.WriteLine("Enter a digit from 1 to 9:");
        string digit = Console.ReadLine();
        
        switch (digit)
        {
            case "1": Console.WriteLine("ONE"); break;
            case "2": Console.WriteLine("TWO"); break;
            case "3": Console.WriteLine("THREE"); break;
            case "4": Console.WriteLine("FOUR"); break;
            case "5": Console.WriteLine("FIVE"); break;
            case "6": Console.WriteLine("SIX"); break;
            case "7": Console.WriteLine("SEVEN"); break;
            case "8": Console.WriteLine("EIGHT"); break;
            case "9": Console.WriteLine("NINE"); break;
            default: Console.WriteLine("NOT A DIGIT"); break;

        }
        

    }
}

