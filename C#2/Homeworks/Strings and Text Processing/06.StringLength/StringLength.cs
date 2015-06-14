using System;
using System.Collections.Generic;
using System.Text;

/*
     Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should      be filled with *.
    Print the result string into the console. 
 */

class StringLength
{
    static void Main()
    {        
        Console.WriteLine("Enter a text:");
        string input = Console.ReadLine();

        int size = input.Length;
        string newString = "";

        if (size > 20)
        {
            newString = input.Remove(20);
            Console.WriteLine(newString);
        }
        else 
        {
          int  count=20-size;
          input += new string('*', count);
          Console.WriteLine(input);
        }

       

    }
}

