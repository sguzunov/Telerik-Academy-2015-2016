using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        uint n = uint.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                Console.Write(i+" ");
            }
            
        }
        Console.WriteLine();


    }
}

