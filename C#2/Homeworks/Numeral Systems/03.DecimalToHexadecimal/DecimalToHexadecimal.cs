using System;
using System.Collections.Generic;

// Write a program to convert decimal numbers to their hexadecimal representation.

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a decimal number:");
        int decimalNumber = int.Parse(Console.ReadLine());
        var hexadecimalNumber = new List<string>();
        string[] hexaAlphabet = { "A", "B", "C", "D", "E", "F" };

        int digit = 0;
        while (decimalNumber != 0)
        {
            digit = decimalNumber % 16;
            if (digit >= 0 && digit <= 9)
            {
                hexadecimalNumber.Add(digit.ToString());
            }
            else if (digit > 9 && digit <= 16)
            {
                hexadecimalNumber.Add(hexaAlphabet[digit % 10]);

            }
            
            decimalNumber /= 16;
        }

        hexadecimalNumber.Reverse();

        for (int i = 0; i < hexadecimalNumber.Count; i++)
        {
            Console.Write(hexadecimalNumber[i]);
        }
        Console.WriteLine();


    }
}

