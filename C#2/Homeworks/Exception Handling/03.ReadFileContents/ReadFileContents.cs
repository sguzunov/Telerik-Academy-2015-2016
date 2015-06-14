using System;
using System.IO;
using System.Text;


/*
    Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    Find in MSDN how to use System.IO.File.ReadAllText(…).
    Be sure to catch all possible exceptions and print user-friendly error messages.
*/ 

class ReadFileContents
{
    static void Main()
    {
        Console.WriteLine("Enter a full path to the fail");
        string path = Console.ReadLine();

        try
        {
            string readFile = File.ReadAllText(path);
            Console.WriteLine(readFile);
        }
        catch (FileNotFoundException) //4
        {
            Console.Error.WriteLine("Your file was NOT found!");
        }
        catch (ArgumentException) // 1
        {
            Console.Error.WriteLine("Your file was NOT found.You should enter a VALID path!");
        }
        catch (IOException) //2
        {
            Console.Error.WriteLine("The file you chosen is not available now.I might be used by another programe!");
        }
        catch (UnauthorizedAccessException) //3
        {
            Console.Error.WriteLine("You DO NOT HAVE the required permission!");
        }
        catch (NotSupportedException) //4
        {
            Console.Error.WriteLine("Your is in an invalid format!");
        }

    }   
}

