using System;
using System.Collections.Generic;

// Write a program to convert hexadecimal numbers to binary numbers (directly).

class HexadecimalToBinary
{
    static void Main()
    {
        string[] binaryNumbers ={"0000","0001","0010","0011","0100","0101","0110","0111",
                                    "1000","1001","1010","1011","1100","1101","1110","1111"};

        Console.Write("Enter a hexa number: ");
        string input = Console.ReadLine();
        string result=string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            int digit = 0;
            if (input[i] >= '0' && input[i] <= '9')
            {
                digit = input[i] - '0';
                result = result + binaryNumbers[digit];
            }
            else if (input[i] >= 'A' && input[i] <= 'F')
            {
                digit = input[i] - 'A';
                result = result + binaryNumbers[digit];
 
            }
                
        }

        Console.WriteLine(result);

    }
}

