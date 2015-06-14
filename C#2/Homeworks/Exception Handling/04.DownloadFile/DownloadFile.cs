using System;
using System.Text;
using System.IO;
using System.Net;

/*
    Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
    Find in Google how to download files in C#.
    Be sure to catch all exceptions and to free any used resources in the finally block.
*/

class DownloadFile
{
    static void Main()
    {
        Console.Write("Enter the Uri: ");
        string uri = Console.ReadLine();
        Console.Write("Enter the name of the file: ");
        string name = Console.ReadLine();

        using (WebClient myClient = new WebClient())
        {
            try
            {
                myClient.DownloadFile(uri, name);
                Console.WriteLine("Downloading succesful!");
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("The address you entered i NOT VALID.");
            }
            catch (WebException)
            {
                Console.Error.WriteLine("The file may NOT exist or an ERROR occured while downloading!");
            }

        }

    }
}

