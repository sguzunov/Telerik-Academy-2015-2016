using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

/*
 Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 Print the obtained array on the console.
 */

class AllocateArray
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int n=int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }

        foreach (var item in array)
        {
            Console.WriteLine(item*5);
        }



    }
}

