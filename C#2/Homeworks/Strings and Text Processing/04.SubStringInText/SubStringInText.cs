using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

// Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

class SubStringInText
{
    static void Main()
    {
        Console.WriteLine("Enter a text");
        string input = Console.ReadLine();

        Console.WriteLine("Enter a target");
        string target = Console.ReadLine();

        int counter = 0;

        input.Trim();
        string newInput= input.Replace(" ", string.Empty);

        for (int i = 0; i < newInput.Length-1; i ++)
        {
            string str=newInput.Substring(i,2);

            if (string.Compare(str,target)==0)
            {
                counter++;
            }
        }

        Console.WriteLine("The count is: {0}",counter);

    }
}

