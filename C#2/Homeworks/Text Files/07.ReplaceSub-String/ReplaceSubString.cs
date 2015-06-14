using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

//  Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//  Ensure it will work with large files (e.g. 100 MB).


class ReplaceSubString
{
    static void Main()
    {
        Console.Write("Enter a path to the fail: ");
        string path = Console.ReadLine();

        StringBuilder text = new StringBuilder();

        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                text.Append(sr.ReadToEnd());
            }
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("There is not enough memory to continue the execution!");
        }

        text = text.Replace("start", "finish");

        using (StreamWriter sw = new StreamWriter("result.txt")) 
        {
            sw.Write(text);
        }

        Console.WriteLine("Your request is DONE!");
    }
}

