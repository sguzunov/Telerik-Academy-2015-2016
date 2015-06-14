using System;
using System.Collections.Generic;

/*
    Write a program that reads an integer number and calculates and prints its square root.
    If the number is invalid or negative, print Invalid number.
    In all cases finally print Good bye.
    Use try-catch-finally block.
 */

class SquareRoot
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        string str = Console.ReadLine();

       Sqrt(str);

    }

    static void Sqrt(string str)
    {
        try
        {
            uint number = uint.Parse(str);
            Console.WriteLine("{0}", Math.Sqrt(number));
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }

    }

}

