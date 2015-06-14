using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Enter a list of words separated by SPACES!");
        string words = Console.ReadLine();

        string[] separatedWords = words.Split(' ');

        Array.Sort(separatedWords);

        Console.WriteLine();
        foreach (var item in separatedWords)
        {
            Console.WriteLine(item);
        }

    }
}

