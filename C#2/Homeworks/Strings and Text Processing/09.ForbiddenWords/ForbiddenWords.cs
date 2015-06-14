using System;
using System.Collections.Generic;
using System.Text;

// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.

class ForbiddenWords
{
    static void Main()
    {
        Console.Write("Enter forbidden words: ");
        string str = Console.ReadLine();

        Console.WriteLine("Enter a text:");
        string text = Console.ReadLine();

        string[] forbiddenWords = str.Split(' ');

        string result = string.Empty;

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            if (text.Contains(forbiddenWords[i]))
            {
                int count=forbiddenWords[i].Length;
                 text=  text.Replace(forbiddenWords[i], new string('*', count));
 
            }            
        }
        Console.WriteLine();
        Console.WriteLine(text);
    }
}

