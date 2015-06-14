using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter a number :");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();

    }
}

