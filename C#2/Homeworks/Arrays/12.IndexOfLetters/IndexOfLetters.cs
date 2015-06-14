using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        List<char> searchedLetters = new List<char>();

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = Convert.ToChar(i + 65); //65 is the offset for capital A in the ascaii table
        }

        Console.Write("Enter a word ---> ");
        string word = Console.ReadLine();

        foreach (char item in word)
        {            
            searchedLetters.Add((char)item);           
        }

        searchedLetters.Sort(); // sorting the searched letters

        for (int i = 0; i < searchedLetters.Count; i++)
        {
            for (int j = 0; j < alphabet.Length-1; j++)
            {
                if (searchedLetters[i] == alphabet[j])
                {
                    Console.WriteLine("The letter {0} is found on position {1}.",searchedLetters[i],j);
                }

            }

        }
        
    }
}

