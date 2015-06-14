using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

class PermutationsOfSet
{

    static void Permute(int[] arr, bool[] use, int p)
    {
        if (p == arr.Length)
        {
            foreach (var item in arr)
            {
                Console.Write("{0} ", item + 1);
            }
            Console.WriteLine();
            return;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (!use[i])
            {
                arr[p] = i;
                use[i] = true;
                Permute(arr, use, p + 1);
                use[i] = false;
            }
        }


        
    }


    static void Main()
    {
        Console.WriteLine("Enter the number of elements");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        bool[] use = new bool[n];
        Permute(arr, use, 0);

    }
   
}

