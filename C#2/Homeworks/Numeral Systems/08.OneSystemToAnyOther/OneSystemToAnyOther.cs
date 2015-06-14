using System;
using System.Collections.Generic;

// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string number = Console.ReadLine().ToUpper();
        Console.Write("Enter a numneral system to convert From");
        int baseOne = int.Parse(Console.ReadLine());
        Console.Write("Enter a numneral system to convert To");
        int baseTwo = int.Parse(Console.ReadLine());

        ConvertFromFirstBaseToSecond(baseOne, baseTwo, number);

    }


    static void ConvertFromFirstBaseToSecond(int baseOne, int baseTwo, string number)
    {
        int decimalNumber = ConvertToDecimal(number, baseOne);
      
        string result = string.Empty;
       
        while (decimalNumber > 0)
        {
            int digit = decimalNumber % baseTwo;
            if (digit >= 0 && digit <= 9)
            {
                result = (char)(digit + '0') + result;
            }
            else 
            {
                result = (char)(digit - 10 + 'A') + result; 
            }
            decimalNumber /= baseTwo;
        }
        Console.WriteLine();
        Console.WriteLine(result);
    }


    static int ConvertToDecimal(string number, int baseOne)
    {
        int decimalNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int digit = 0;
            if (number[i] >= '0' && number[i] <= '9')
            {
                digit = number[i] - '0';
            }
            else
            {
                digit = number[i] - 'A' + 10;
            }

            decimalNumber += digit * (int)Math.Pow(baseOne, number.Length - 1 - i);
        }
        return decimalNumber;

    }


}

