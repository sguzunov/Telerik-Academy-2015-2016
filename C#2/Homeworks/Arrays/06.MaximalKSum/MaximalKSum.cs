using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

    /*   Write a program that reads two integer numbers N and K and an array of N elements from the console.
     Find in the array those K elements that have maximal sum.
     */

class MaximalKSum
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        int sum = 0;
        int maxSum = 0;


        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length +1 -K; i++)
        {
         
            for (int j=0; j < K; j++)
            {
                sum += arr[i + j];                

            }
            if (sum > maxSum)
            {
                maxSum = sum;
                
            }
            sum = 0;
            
        }
        Console.WriteLine();
        Console.WriteLine(maxSum);

                
    }
}

