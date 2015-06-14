using System;
using System.Collections.Generic;
using System.Threading;
using System.Numerics;

// Write a program to calculate n! for each n in the range [1..100].

class NFactorial
{
    static void Main()
    {
          
        ArrayNFactorial(100);

    }

    static void ArrayNFactorial(int number)
    {

        for (int i = 1; i <= number; i++)
        {
            BigInteger factoria = 1;
            for (int j = 1; j < i+1; j++)
            {
                factoria *= j;
            }
            Console.WriteLine("Element {0} ==> {1}",i,factoria);
        }

    }
   

}

