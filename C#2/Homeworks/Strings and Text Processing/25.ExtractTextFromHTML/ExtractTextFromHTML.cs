using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

class ExtractTextFromHTML
{
    static void Main()
    {
        Console.WriteLine("Enter HTML code");
        string html = Console.ReadLine();

        string pattern = @"(?<=^|>)[^><]+?(?=<|$)";

        Regex rgx = new Regex(pattern);

        Console.WriteLine();

        foreach (Match match in rgx.Matches(html))
        {
            Console.WriteLine(match.Value);
        }

        Console.WriteLine();
    }
}

