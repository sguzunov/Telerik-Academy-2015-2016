﻿using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Type a number :");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }


    }
}

