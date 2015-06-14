using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Write a program that finds the maximal increasing sequence in an array

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        List<int> sequence = new List<int>();
        List<int> maxSequence = new List<int>();


        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if ((arr[i] < arr[i + 1]) && (arr[i + 1] - arr[i] == 1))
            {
                sequence.Add(arr[i]);
                sequence.Add(arr[i]+1);
                if (sequence.Count > maxSequence.Count)
                {
                    maxSequence.Clear();
                    maxSequence.AddRange(sequence);
                }

            }
            else
            {
                sequence.Clear();
            }

        }

        List<int> noDupes = maxSequence.Distinct().ToList();
        Console.WriteLine();
        for (int i = 0; i < noDupes.Count; i++)
        {
            Console.WriteLine(noDupes[i]);
        }



    }
}
