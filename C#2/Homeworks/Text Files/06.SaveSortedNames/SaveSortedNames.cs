using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

class SaveSortedNames
{
    static void Main()
    {
        Console.Write("Enter a path to the file: ");
        string path = Console.ReadLine();

        var list = new List<string>();

        using (StreamReader sr = new StreamReader(path))
        {
            string line = sr.ReadLine();

            while (line != null)
            {
                list.Add(line);
                line=sr.ReadLine(); 
            }
        }

        list.Sort();

        using (StreamWriter sw = new StreamWriter("result.txt"))
        {
            for (int i = 0; i < list.Count; i++)
            {
                sw.WriteLine(list[i]);
            }

        }
        Console.WriteLine("Your new fail is DONE!");   
    }
}

