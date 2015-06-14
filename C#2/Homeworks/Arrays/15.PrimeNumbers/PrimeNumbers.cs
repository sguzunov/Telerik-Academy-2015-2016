using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

class PrimeNumbers
{
    static void Main()
    {
        
        bool[] prime = new bool[10000000];

        for (int i = 2; i < prime.Length; i++)
        {
            prime[i] = true;
        }

        for (int i = 2; i < Math.Sqrt(prime.Length); i++)
        {
            if (prime[i] == true)
            {
                for (int j = i*i; j < prime.Length; j+=i)
                {
                    prime[j] = false;
                }
            }

        }
        Console.WriteLine();
        for (int i = 2; i < prime.Length; i++)
        {
            if (prime[i] == true)
            {
                Console.WriteLine("The number {0} is {1}",i,prime[i]);
            }
        }

    }
}

