using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

// Modify the solution of the previous problem to replace only whole words (not strings).

class ReplaceSubString
{
    static void Main()
    {
        Console.Write("Enter a path to the fail: ");
        string path = Console.ReadLine();

        string text = string.Empty;

        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("There is not enough memory to continue the execution!");
        }

        text = Regex.Replace(text, @"\bstart\b", "finish");

        using (StreamWriter sw = new StreamWriter("result.txt"))
        {
            sw.Write(text);
        }

        Console.WriteLine("Your request is DONE!");
    }
}

