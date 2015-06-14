using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

// Write a program to check if in a given expression the brackets are put correctly.

class CorrectBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        int counterFirst = 0, counterSecond = 0;
        
        foreach (var ch in input)
        {
            if (ch == '(')
            {
                counterFirst++;
            }
            else if (ch == ')')
            {
                counterSecond++;
            }
        }

        Console.WriteLine((counterFirst == counterSecond) ? "Correct" : "Incorrect");

    }
}

