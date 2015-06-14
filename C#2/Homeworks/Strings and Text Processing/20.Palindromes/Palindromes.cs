using System;
using System.Collections.Generic;
using System.Threading;

// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");
        string text = Console.ReadLine();

        string[] byWords = text.Split(' ', ',', '.');

        Console.WriteLine();
        foreach (var word in byWords)
        {
            bool isPolidrome = true;

            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPolidrome = false;
                    break;
                }
            }

            if (isPolidrome == true && word.Length > 1)
            {
                Console.WriteLine(word);
            }
            
        } //foreach


    }
}

