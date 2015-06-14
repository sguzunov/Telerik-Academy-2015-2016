using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

// Write a program that reverses the words in given sentence.


class ReverseSentence
{
    static void Main()
    {
        Console.WriteLine("Enter a setance:");
        string input = Console.ReadLine();
        string sign = input[input.Length - 1].ToString();
        input = input.Remove(input.Length - 1);

        input = input.Replace(",", "");

        string[] byWords = input.Split(' ');

        Array.Reverse(byWords);

        Console.WriteLine();
        foreach (var item in byWords)
        {
            Console.Write(item+" ");
        }

        Console.Write(sign);        
    }
}

