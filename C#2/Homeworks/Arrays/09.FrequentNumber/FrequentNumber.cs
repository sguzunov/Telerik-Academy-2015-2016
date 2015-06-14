using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Write a program that finds the most frequent number in an array.

class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the count of elements:");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
        int counter = 0;
        int currentCounter = 0;
        int number = 0;
        
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] != number)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currentCounter++;
                    }
                    
                }
                if (currentCounter > counter)
                {
                    counter = currentCounter;
                    number = arr[i];
                }
                currentCounter = 1;
            }

        }

        Console.WriteLine("{0} ({1} items)",number,counter);

    }

}
