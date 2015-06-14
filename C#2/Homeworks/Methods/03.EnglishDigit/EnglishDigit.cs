using System;
using System.Collections.Generic;
using System.Threading;

// Write a method that returns the last digit of given integer as an English word.


class EnglishDigit
{
    static void Main()
    {
        Console.Write("Enter a number ");
        int number = int.Parse(Console.ReadLine());

        string nameOfDigit = TheName(number);
        Console.WriteLine(nameOfDigit);

    }

    static string TheName(int number)
    {
        int digit = number % 10;
        string[] allDigits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
        string name = allDigits[digit];
        return name;

    }

    
}

