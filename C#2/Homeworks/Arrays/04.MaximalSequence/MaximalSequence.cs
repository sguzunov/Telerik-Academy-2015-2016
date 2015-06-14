using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Write a program that finds the maximal sequence of equal elements in an array.

class MaximalSequence
{
    static void Main()
    {   
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int sequence = 1;
        int maxSequence = 1;
        int element = 0;


        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            
        }

        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                sequence++;
                if (sequence > maxSequence)
                {
                    maxSequence = sequence;
                    element = arr[i];
                }
            }
            else
            {
                sequence = 1;
            }
            
        }

        Console.WriteLine();
        for (int i = 0; i < maxSequence; i++)
        {
            Console.WriteLine(element);            
        }
       
              
    }
}

