using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.

class SubsetWithSumS

{
    static void Main()
    {
        Console.WriteLine("Enter the sum");
        int s = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the number of elements:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int sum = arr[0];


        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());

        }

        bool flag = false;


        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    flag = true;
                    Console.WriteLine("yes"); break;                    
                }

            }
            sum = 0;
            if (flag == true)
            {
                break;
            }

        }



    }
}

