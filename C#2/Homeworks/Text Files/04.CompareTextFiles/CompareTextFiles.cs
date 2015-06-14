using System;
using System.Text;
using System.IO;

/*
    Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
    Assume the files have equal number of lines.
*/

class CompareTextFiles
{
    static void Main()
    {
        Console.WriteLine("Enter the path to the first file: ");
        string pathFirst = Console.ReadLine();
        Console.WriteLine("Enter the path to the second file: ");
        string pathSecond = Console.ReadLine();

        string firstLine = string.Empty;
        string secondLine = string.Empty;

        int counterSame = 0;
        int counterDifferent = 0;

        using (StreamReader firstReader = new StreamReader(pathFirst))
        {
            using (StreamReader secondReader = new StreamReader(pathSecond))
            {
                firstLine = firstReader.ReadLine();
                secondLine = secondReader.ReadLine();

                while ((firstLine != null) || (secondLine != null))
                {
                    if (string.Compare(firstLine, secondLine) == 0)
                    {
                        counterSame++;
                    }
                    else if (string.Compare(firstLine, secondLine) != 0)
                    {
                        counterDifferent++;
                    }

                    firstLine = firstReader.ReadLine();
                    secondLine = secondReader.ReadLine();
                }
 
            } // second reader

        }// first reader
        Console.WriteLine("Lines that are same are {0}", counterSame);
        Console.WriteLine("Lines that are different are {0}", counterDifferent);
    }
}

