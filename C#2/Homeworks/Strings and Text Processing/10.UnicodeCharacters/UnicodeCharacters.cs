using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

// Write a program that converts a string to a sequence of C# Unicode character literals.Use format strings.

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        foreach (var ch in input)
        {
            Console.Write(@"\u{0:X4}",(int)ch);          
        }
        
    }
}

