using System;
using System.Collections.Generic;

// Write a program to convert binary numbers to hexadecimal numbers (directly).

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();

        var hexa = new List<string>()
        {
            "0000", "0001", "0010", "0011", 
            "0100", "0101", "0110", "0111",
            "1000", "1001", "1010", "1011",
            "1100", "1101", "1110", "1111"
        };

        if (binaryNumber.Length % 4 > 0)
        {
            binaryNumber = new string('0', 4 - (binaryNumber.Length % 4)) + binaryNumber;
        }

        string hexaNumber = string.Empty;
        string substring = string.Empty;
        int index = 0;
        for (int i = 0; i < binaryNumber.Length; i+=4)
        {
            substring = binaryNumber.Substring(i, 4);
            index = hexa.IndexOf(substring);
            if (index >= 0 && index <= 9)
            {
                hexaNumber = hexaNumber + Convert.ToString(index);
                index = 0;
            }
            else if (index > 9 && index <= 15)            
            {
                hexaNumber = hexaNumber + Convert.ToString(((char)(index + 55)));
                index = 0;

            }

        }

        Console.WriteLine();
        Console.WriteLine(hexaNumber);
    }
}

