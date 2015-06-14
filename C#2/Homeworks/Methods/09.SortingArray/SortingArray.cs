using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

/*
Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
 */

class SortingArray
{
    static void Main()
    {
        Console.Write("Enter the number of element: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        Console.WriteLine("Enter the elements in the array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("numbers[{0}]= ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the position to start the checking: ");
        int position = int.Parse(Console.ReadLine());
        
        Console.WriteLine();
        Console.WriteLine(TheMaximalElement(numbers, position));

        Console.WriteLine();
        Console.WriteLine("Sorted ascending:");
        PrintArray(SortedAscending(numbers));
        Console.WriteLine();
        Console.WriteLine("Sorted descending: ");
        PrintArray(SortedDescending(numbers));



    }

    static void PrintArray(int[] p)
    {
        foreach (int item in p)
        {
            Console.Write("{0} ",item);
        }
    }

    static int[] SortedDescending(int[] numbers)
    {
        int swap = int.MinValue;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i+1; j < numbers.Length; j++)
            {
                if (numbers[i] < numbers[j])
                {
                    swap = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = swap;
                }

            }
        }
        return numbers;
    }


    static int[] SortedAscending(int[] numbers)
    {
        int swap=int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i+1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    swap = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = swap;
                }

            }                      
        }
        return numbers;
    }


    static int TheMaximalElement(int[] numbers, int position)
    {
        int theBestElement = int.MinValue;
        for (int i = position; i < numbers.Length; i++)
        {
            if (numbers[i] > theBestElement)
            {
                theBestElement = numbers[i];
            }
        }
        return theBestElement;
    }





}

