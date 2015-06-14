using System;
using System.Collections.Generic;
using System.Threading;

// Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.


class LettersCount
{
    static void Main()
    {
        Console.WriteLine("Enter a text");
        string text = Console.ReadLine();
        text=text.ToLower();
    
        int[] arr = new int[26];

        
        foreach (var ch in text)
        {
            if (char.IsLetter(ch))
            {
                arr[ch - 'a']++;
            }
            
        }

        Console.WriteLine();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                Console.WriteLine("Letter - {0} : {1}", (char)(i + 'a'), arr[i]);
            }
            
        }

    }
}

