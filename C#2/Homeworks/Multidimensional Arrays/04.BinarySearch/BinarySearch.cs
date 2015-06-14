using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

/*
       Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() 
       finds the largest number in the array which is ≤ K.
*/

class BinarySearch  
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter an integer K : ");
        int K = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
        Console.WriteLine("Enter the elements");
        for (int i = 0; i < arr.GetLength(0); i++)
        {            
                Console.Write("arr[{0}]",i);
                arr[i]=int.Parse(Console.ReadLine());                        
        }

        Array.Sort(arr);

        while (Array.BinarySearch(arr, K) < 0)
        {
            K--;
        }

        Console.WriteLine();
        Console.WriteLine("The largest number is: {0}",K);

    }
}

