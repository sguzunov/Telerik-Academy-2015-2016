using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

/*
 Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 */


class ParseURL
{
    static void Main()
    {
        Console.Write("Enter a URL: ");
        string input=Console.ReadLine();

        Uri inputURL = new Uri(input);

        string resource = inputURL.PathAndQuery;
        string server = inputURL.Authority;
        string protokol = inputURL.Scheme;

        Console.WriteLine();
        Console.WriteLine("Server: {0}", protokol);
        Console.WriteLine("Server: {0}", server);
        Console.WriteLine("Resource: {0}", resource);        
        
    }
}

