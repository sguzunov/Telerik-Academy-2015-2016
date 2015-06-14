using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

// Write a program that extracts from a given text all sentences containing given word.

class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();

        Console.Write("Enter a target: ");
        string target = Console.ReadLine();               

        text.Trim();

        string[] sentances = text.Split('.');
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < sentances.Length; i++)
        {
            if (sentances[i].Contains(' ' + target + ' '))
            {
                result.Append(sentances[i]);
            }            
        }
        Console.WriteLine();
        Console.WriteLine(result);
    }
}

