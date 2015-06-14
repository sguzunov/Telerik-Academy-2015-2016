using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Write a program that compares two char arrays lexicographically (letter by letter).

class CompareCharArrays
{
    static void Main()
    {   
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());
        char[] firstArray = new char[n];
        char[] secondArray = new char[n];

        Console.WriteLine("Enter the elements of the first array:");
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the elements of the second array:");
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("The elements on position {0} are equal!",i);
            }
            else 
            {
                Console.WriteLine("The elements on position {0} are NOT equal!",i);
            }
        }
        
    }
}

