using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/*
   A dictionary is stored as a sequence of text lines containing words and their explanations.
   Write a program that enters a word and translates it by using the dictionary.
 */

class WordDictionary
{
    static void Main()
    {
        string[,] dictionary = 
        {
            {".NET", "platform for applications from Microsoft"},
            {"CLR", "managed execution environment for .NET"},
            {"namespace", "hierarchical organization of classes"}
            
        };

        bool isFound = false;

        Console.Write("Enter a word: ");
        string input = Console.ReadLine();

        for (int i = 0; i < dictionary.GetLength(0); i++)
        {
            if (dictionary[i, 0] == input)
            {
                Console.WriteLine(dictionary[i,1]);
                isFound = true;
            }
            
        }

        if (isFound == false)
        {
            Console.WriteLine("Such a word NOT found!");
        }

    }
}

