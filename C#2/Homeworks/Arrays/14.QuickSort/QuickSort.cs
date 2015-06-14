using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Write a program that sorts an array of strings using the Quick sort algorithm.



// I have no idead what is wrong with this code.I used pseudo code from wiki.

class QuickSort
{


    static void Quicksort(string[] arr, int low, int high)
    {
        if (low >= high)
        {
            return;
        }

            int pivotIndex = low + (high + 1 - low) / 2;
            int p = Partition(arr, low, high,pivotIndex);
            Quicksort(arr, low, p - 1);
            Quicksort(arr, p + 1, high);                

    }


    static int Partition(string[] arr, int low, int high, int pivotIndex)
    {        
        string pivotValue = arr[pivotIndex];

        string temp = arr[pivotIndex];
        arr[pivotIndex] = arr[high];
        arr[high] = temp;

        int storeIndex = low;

        for (int i = low; i < high; i++)
        {
            if (string.Compare(arr[i],pivotValue)<=0)
            {
                string temp1 = arr[i];
                arr[i] = arr[storeIndex];
                arr[storeIndex] = temp1;
                storeIndex ++;            
            }
        }
        string temp2 = arr[storeIndex];
        arr[storeIndex] = arr[high];
        arr[high] = temp2;

        return storeIndex;

    }

    

    static void Main()
    {
        Console.WriteLine("Enter the number of elements:");
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];
       
        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Console.ReadLine();
        }

        Quicksort(arr, 0, arr.Length - 1);

        Console.WriteLine();
        Console.WriteLine("Sorted elements:");
        foreach (string i in arr)
        {
            Console.WriteLine(i);
        }
        
    }
        
}

