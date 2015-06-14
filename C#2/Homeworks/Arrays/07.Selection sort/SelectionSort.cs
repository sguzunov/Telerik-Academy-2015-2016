﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

    /*      Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
            Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest,
            move it at the second position, etc.
    */ 

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Enter the count of elements:");
        int N = int.Parse(Console.ReadLine());        
        int[] arr = new int[N];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }                
            }
        }
        Console.WriteLine();
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }


    }
}

