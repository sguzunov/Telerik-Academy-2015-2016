using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements:");
        int n = int.Parse(Console.ReadLine());
        int[] arr=new int[n];

        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < arr.Length; i++)
			{
			    arr[i]=int.Parse(Console.ReadLine());
			}

        Array.Sort(arr);

        int first = 0;
        int last = n - 1;
        int middle = (first + last) / 2;

        Console.Write("Enter the number you wnat to find:");
        int number = int.Parse(Console.ReadLine());

        while (first <= last)
        {
            if (arr[middle] < number)
            {
                first = middle + 1;
            }
            else if (arr[middle] == number)
            {
                Console.WriteLine("The number {0} is found at position {1}.",number,middle);
                break;
            }
            else 
            {
                last = middle - 1;
                
            }
            middle = (first + last) / 2;

        }               
                

    }
}

