using System;
using System.Collections.Generic;
using System.Text;

/*
 You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.  
 */

class ParseTags
{
    static void Main()
    {
        Console.WriteLine("Enter a text");
        string input = Console.ReadLine();

        input.Trim();

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '<')
            {
                i += 8;

                while (input[i] != '<')
                {
                    result.Append(input[i].ToString().ToUpper());
                    i++;
                }
                i += 8;
            }
            else
            {
                result.Append(input[i].ToString());
            }
            
        } // for

        Console.WriteLine();
        Console.WriteLine(result);

    }

}

