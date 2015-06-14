using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/*
 Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */

class ReplaceTag
{
    static void Main()
    {
        Console.WriteLine("Enter HTML document");
        string input = Console.ReadLine();

        input = input.Replace("<a href=\"","[URL=");
        input = input.Replace("\">", "]");
        input = input.Replace("</a>", "[/URL]");

        Console.WriteLine();
        Console.WriteLine(input);
    }
}

