using System;
using System.Text;
using System.IO;

// Write a program that reads a text file and prints on the console its odd lines.

class OddLines
{
    static void Main()
    {
        Console.WriteLine("Enter a path to a text file:  ");
        string path=Console.ReadLine();

        string line = string.Empty;
        int counter = 0;

        using (StreamReader sr = new StreamReader(path))
        {
            while ((line = sr.ReadLine())!=null)
            {
                counter++;

                if (counter % 2 != 0)
                {
                    Console.WriteLine("Line {0} ==> {1}", counter, line);
                }                
            }
        }        
    }
}

