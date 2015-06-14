using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

//  Describe the strings in C#.
//  What is typical for the string data type?
//  Describe the most important methods of the String class.

class StringsInCSharp
{
    static void Main()
    {
        Console.WriteLine(WhatIsString());
    }

    static string WhatIsString()
    {
        return "Strings are sequences of characters.Each character is a Unicode symbol.Strings are represented by Syste.String objects in .NET Framework.String objects are like arrays of characters.Have fixed length (String.Length).Elements can be accesed by their index.Some of the important methods:Clone(),Compare(),Concat(),Copy(),IndexOf(),Insert(),Join(),Remove(),Replace().\n"; 
       
    }

}

