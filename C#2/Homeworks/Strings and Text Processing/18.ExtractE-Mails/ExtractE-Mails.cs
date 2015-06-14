using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

// Write a program for extracting all email addresses from given text.All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as 
// emails.

class ExtractEMails
{
    static void Main()
    {
        Console.WriteLine("Enter a text: ");
        string text = Console.ReadLine();

        string pattern = @"\b[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}\b";
        Regex rgx = new Regex(pattern);

        Console.WriteLine();

        foreach (Match match in rgx.Matches(text))
        {
            Console.WriteLine("E-mail: {0}", match.Value);
        }


    }
}

