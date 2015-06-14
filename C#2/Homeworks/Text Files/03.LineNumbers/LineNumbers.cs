using System;
using System.Text;
using System.IO;

/*  Write a program that reads a text file and inserts line numbers in front of each of its lines.
    The result should be written to another text file.
 */ 

class LineNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the path of the file: ");
        string path=Console.ReadLine();

        string line = string.Empty;
        int counter=0;

        
        using (StreamWriter sw = new StreamWriter(@"numberedLines.txt", false, Encoding.UTF8))
        {
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                line=sr.ReadLine();

                while (line!=null)
                {
                    counter++;
                    line = line.Insert(0, counter.ToString()+"- ");
                    sw.WriteLine(line);
                    line = sr.ReadLine();
                }

            }//streawritter

        }// streamreader
        Console.WriteLine("Your file is DONE!");
    }
}

