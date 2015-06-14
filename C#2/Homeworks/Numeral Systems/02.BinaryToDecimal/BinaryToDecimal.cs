using System;
using System.Collections.Generic;

// Write a program to convert binary numbers to their decimal representation.

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        var decimalNumberAsString = new List<string>();
        int decimalNumber = 0;
        int digit = 0;
        int j = 0;
        for (int i = binaryNumber.Length-1; i >=0; i--)
        {
            digit = int.Parse(binaryNumber[i].ToString());
            decimalNumberAsString.Add((digit * (int)Math.Pow(2, j)).ToString());
            j++;
        }

        decimalNumberAsString.Reverse();

        for (int i = 0; i < decimalNumberAsString.Count; i++)
        {           
            decimalNumber += int.Parse(decimalNumberAsString[i]);
        }
                
        Console.WriteLine("Decimal repesentation {0}",decimalNumber);
    }
}

