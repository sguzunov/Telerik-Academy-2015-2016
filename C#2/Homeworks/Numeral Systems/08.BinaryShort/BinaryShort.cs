using System;
using System.Collections.Generic;

// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter a decimal number (short): ");
        short decimalNumber = short.Parse(Console.ReadLine());

        ConvertToBinary(decimalNumber);

    }

    static void ConvertToBinary(short decimalNumber)
    {
        char[] binaryNumber = new char[16];
        int pos = 15;
        int i = 0;

        while (i < 16)
        {
            if ((decimalNumber & (1 << i)) != 0)
            {
                binaryNumber[pos] = '1';
            }
            else
            {
                binaryNumber[pos] = '0';
            }
            pos--;
            i++;
        }
        for (int j = 0; j < binaryNumber.Length; j++)
        {
            Console.Write(binaryNumber[j]);
        }
        Console.WriteLine();
    }
}

