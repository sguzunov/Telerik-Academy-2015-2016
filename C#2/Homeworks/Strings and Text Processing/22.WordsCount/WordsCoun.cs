using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;


class WordsCoun
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");
        string text=Console.ReadLine();
        string pattern =@"\w+";

        Regex rgx = new Regex(pattern);

        var dict = new Dictionary<string, int>();

        foreach (Match match in rgx.Matches(text))
        {
            if (dict.ContainsKey(match.Value))
            {
                dict[match.Value]++;
            }
            else 
            {
                dict.Add(match.Value, 1);
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine("{0} ==> {1}",item.Key,item.Value);            
        }

        
    }
}

