using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

//Write a program that finds the sequence of maximal sum in given array.

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        int sum = arr[0];
        int maxSum = arr[0];
        List<int> myList = new List<int>();
        int begin = 0;
        int end = 0;
        int temp = 0;


        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < arr.Length; i++)
        {
            sum += arr[i];

            if (sum < arr[i])
            {
                sum = arr[i];
                temp = i;
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                begin = temp;
                end = i;
            }
                
        }
        Console.WriteLine();

        for (int i = begin; i <= end; i++)
        {
            Console.Write("{0} ",arr[i]);
        }


    }
}
// 2, 3, -6, -1, 2, -1, 6, 4, -8, 8	 ||  2, -1, 6, 4