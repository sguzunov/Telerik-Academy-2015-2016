using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Write a program that reads two integer arrays from the console and compares them element by element

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter the number of elements of the arrays: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayFirst = new int[n];
        int[] arraySecond = new int[n];

        Console.WriteLine("Enter the elements of the 1st array: ");
        for (int i = 0; i < arrayFirst.Length; i++)
        {
            arrayFirst[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the elements of the 2nd array: ");
        for (int i = 0; i < arraySecond.Length; i++)
        {
            arraySecond[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (arrayFirst[i] == arraySecond[i])
            {
                Console.WriteLine("On position {0} the elements are equal ({1}={2})",i,arrayFirst[i],arraySecond[i]);
            }

            else if (arrayFirst[i] > arraySecond[i])
            {
                Console.WriteLine("On position {0} the element of the first array is bigger than the element of the secons array ({1}>{2})",
                    i, arrayFirst[i], arraySecond[i]);
            }

            else if (arrayFirst[i] < arraySecond[i])
            {
                Console.WriteLine("On position {0} the element of the second array is bigger than the element of the first array ({1}>{2})",
                    i, arraySecond[i], arrayFirst[i]);
            }            
            
        }
        Console.WriteLine();


    }
}

