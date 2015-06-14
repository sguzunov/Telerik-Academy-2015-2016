using System;
using System.Collections.Generic;
using System.Threading;

// You are given a sequence of positive integer values written into a string, separated by spaces.
//  Write a function that reads these values from given string and calculates their sum.

class Program  
{
    static void Main()
    {
        Console.Write("Enter a sequence of positive integer values:");
        string numbers = Console.ReadLine();

        Console.WriteLine("The sum is: {0}",Sum(numbers));
    

    }

    static int Sum(string numbers)
    {                                   
        int sum = 0;
        int currentSum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (char.IsDigit(numbers[i]))
            {
                currentSum *= 10;
                currentSum += numbers[i] - '0';
                if (i == numbers.Length - 1)
                {
                    sum += currentSum;
                }
                
            }
            else
            {
                
                sum += currentSum;
                currentSum = 0;               
            }

        }
                
            return sum;       

    }


}

