using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Enter the number of elements :");
        int n = int.Parse(Console.ReadLine());

        string[] arr = new string[n];
        Console.WriteLine("Enter the elements");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr[{0}] ==> ",i);
            arr[i] = Console.ReadLine();
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i].Length>arr[j].Length)
                {
                    string temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Sorted array");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }


    }
}

