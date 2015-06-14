using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

// Write a program that extracts from given XML file all the text without the tags.

class ExtractTextFromXML
{
    static void Main()
    {
        Console.Write("Enter a path to a fail: ");
        string path = Console.ReadLine();
        string text = string.Empty;

        using (StreamReader sr = new StreamReader(path))
        {
            text = sr.ReadToEnd();
        }

        Regex rgx = new Regex(@"(?<=^|>)[^><]+?(?=<|$)");

        foreach (Match match in rgx.Matches(text))
        {
            Console.WriteLine(match.Value);
        }

        Console.WriteLine();
    }
}

