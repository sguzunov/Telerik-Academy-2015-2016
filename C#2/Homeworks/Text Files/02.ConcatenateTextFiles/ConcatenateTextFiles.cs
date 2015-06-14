using System;
using System.Text;
using System.IO;

// Write a program that concatenates two text files into another text file.

class ConcatenateTextFiles
{
    static void Main()
    {
        Console.WriteLine("Enter the first path: ");
        string pathFirst = Console.ReadLine();
        Console.WriteLine("Enter the second path: ");
        string pathSecond = Console.ReadLine();

        StringBuilder text1 = new StringBuilder();
        StringBuilder text2 = new StringBuilder();
        StringBuilder result = new StringBuilder();

        using (StreamReader sr1 = new StreamReader(pathFirst,Encoding.UTF8))
        {
            text1.Append(sr1.ReadToEnd());
        }

        using (StreamReader sr2 = new StreamReader(pathSecond,Encoding.UTF8))
        {
             text2.Append(sr2.ReadToEnd());
        }

        text1.Append(text2);

        try
        {
            using (StreamWriter sw = new StreamWriter(@"result.txt", false, Encoding.UTF8))
            {
                sw.Write(text1);
            }

        }
        finally
        {
            Console.WriteLine("The new file is written!");
        }

    }
}

