using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

// Write a program that deletes from a text file all words that start with the prefix test.Words contain only the symbols 0…9, a…z, A…Z, _.

class PrefixTtest
{
    static void Main()
    {
        Console.Write("Enter a path to your file: ");
        string path = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter("result.txt"))
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    line = line.ToLower();
                    line = Regex.Replace(line, @"\btest\w*\b", string.Empty);
                    sw.WriteLine(line);
                    line = sr.ReadLine();
                }

            }

        }
        Console.WriteLine("The new file is read!");
    }
}

