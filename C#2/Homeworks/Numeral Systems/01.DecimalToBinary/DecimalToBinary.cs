using System;
using System.Linq;
using System.Collections.Generic;

// Write a program to convert decimal numbers to their binary representation.

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number:");
        int decimalNumber = int.Parse(Console.ReadLine());
        var binaryNumber = new List<string>();

        int digit = 0;
        while (decimalNumber != 0)
        {
            digit = decimalNumber % 2;
            binaryNumber.Add(Convert.ToString(digit));
            decimalNumber /= 2;
        }
        binaryNumber.Reverse();
        for (int i = 0; i < binaryNumber.Count; i++)
        {
            Console.Write(binaryNumber[i]);
        }
        Console.WriteLine();
    }
}

