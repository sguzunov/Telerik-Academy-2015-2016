using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Write a program that deletes from given text file all odd lines.The result should be in the same file.

class DeleteOddLines
{
    static void Main()
    {
        Console.Write("Enter a path to a fail: ");
        string path = Console.ReadLine();

        int counter = 0;

        using (StreamWriter sw = new StreamWriter("result.txt"))
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();                

                while (line != null)
                {
                    counter++;
                    if (counter % 2 == 0)
                    {                       
                        sw.WriteLine(line);
                    }
                    
                    line = sr.ReadLine();
                }

            }// sr

        }// sw

        Console.WriteLine("Operation DONE!");
    }
}

