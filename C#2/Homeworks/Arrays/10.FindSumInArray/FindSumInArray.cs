using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Write a program that finds in given array of integers a sequence of given sum S (if present).

class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter the sum");
        int s=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of elements:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int sum = arr[0];
        

        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    Console.WriteLine("The sum is found in :");
                    for (int k = i; k <= j; k++)
                    {
                        Console.WriteLine(arr[k]);
                    }

                }

            }
            sum = 0;
            
        }





    }
}

