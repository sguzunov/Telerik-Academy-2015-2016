using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;

// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

class SeriesOfLetters
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        result.Append(input[0].ToString());
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != result[result.Length - 1])
            {
                result.Append(input[i].ToString());
            }
          
        }


        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);
        }

    }
}

