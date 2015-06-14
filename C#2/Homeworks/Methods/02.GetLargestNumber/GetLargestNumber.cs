using System;
using System.Collections.Generic;
using System.Threading;

//  Write a method GetMax() with two parameters that returns the larger of two integers.
//  Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().


class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int c = int.Parse(Console.ReadLine());

        int firstBig = GetMax(a, b);
        int theBest = GetMax(firstBig, c);
        Console.WriteLine();
        Console.WriteLine("The largest of them is {0}",theBest);

    }

    static int GetMax(int first, int second)
    {
        if (first > second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }

}

