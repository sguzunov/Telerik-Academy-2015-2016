using System;
using System.Collections.Generic;
using System.Threading;

// Write a method that reverses the digits of given decimal number.

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number to reverse: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();
        ReverseANumber(number);
        Console.WriteLine();
        
    }

    static void ReverseANumber(int number)
    {
        string reversedNumber = "";
        int digit = int.MinValue;

        while (number > 0)
        {
            digit = number % 10;
            reversedNumber += Convert.ToString(digit);
            number /= 10;
        }
        Console.WriteLine(reversedNumber);        

    }
}

