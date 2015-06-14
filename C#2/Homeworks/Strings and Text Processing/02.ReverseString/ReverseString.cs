using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

//Write a program that reads a string, reverses it and prints the result at the console.

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        char[] symbols = input.ToCharArray();

        for (int i = symbols.Length - 1; i >= 0; i--)
        {
            result.Append(symbols[i]);
        }

        Console.WriteLine(result.ToString());
    }
}

