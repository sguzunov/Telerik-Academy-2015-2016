using System;

class QuotesInStrings
{
    static void Main()
    {

        string quotedString = "The \"use\" of quotations causes difficulties.";
        string notquotedString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("Quoted string - {0}",quotedString);
        Console.WriteLine("Not quoted string - {0}", notquotedString);
        Console.WriteLine();

    }
}

