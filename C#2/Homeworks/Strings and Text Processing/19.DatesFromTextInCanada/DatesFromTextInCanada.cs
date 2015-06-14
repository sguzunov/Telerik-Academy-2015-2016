using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

class DatesFromTextInCanada
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");
        string text = Console.ReadLine();

        string pattern = @"\b\d{2}.\d{2}.\d{4}\b";
        Regex rgx = new Regex(pattern);

        DateTime dt;

        foreach (Match match in rgx.Matches(text))
        {
            if (DateTime.TryParseExact(match.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
            {
                Console.WriteLine(dt.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }

            
    }
}