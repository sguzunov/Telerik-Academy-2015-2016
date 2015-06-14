using System;
using System.Collections.Generic;

// Write a program to convert hexadecimal numbers to their decimal representation.

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hexadecial number: ");
        string hexadecimaNumber = Console.ReadLine();
        var decimalNumberAsString = new List<string>();
        int decimalNumber = 0;
        int digit = 0;
        int j = 0;
        for (int i = hexadecimaNumber.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(hexadecimaNumber[i]))
            {
                digit = int.Parse(hexadecimaNumber[i].ToString());
                decimalNumberAsString.Add((digit * (int)Math.Pow(16, j)).ToString());
            }
            else
            {
                switch (hexadecimaNumber[i])
                {
                    case 'A': decimalNumberAsString.Add((10 * (int)Math.Pow(16, j)).ToString()); break;
                    case 'B': decimalNumberAsString.Add((11 * (int)Math.Pow(16, j)).ToString()); break;
                    case 'C': decimalNumberAsString.Add((12 * (int)Math.Pow(16, j)).ToString()); break;
                    case 'D': decimalNumberAsString.Add((13 * (int)Math.Pow(16, j)).ToString()); break;
                    case 'E': decimalNumberAsString.Add((14 * (int)Math.Pow(16, j)).ToString()); break;
                    case 'F': decimalNumberAsString.Add((15 * (int)Math.Pow(16, j)).ToString()); break;
                }

            }
           
            j++;
        }

        decimalNumberAsString.Reverse();

        for (int i = 0; i < decimalNumberAsString.Count; i++)
        {
            // decimalNumber *= 10;
            decimalNumber += int.Parse(decimalNumberAsString[i]);

        }

        Console.WriteLine("Decimal repesentation {0}", decimalNumber);


    }
}

