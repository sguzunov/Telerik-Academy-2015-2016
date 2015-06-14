using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is workings correctly.


class AppearanceCount
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("numbers[{0}]= ",i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the number you want to check: ");
        int numberToCheck = int.Parse(Console.ReadLine());

        Console.WriteLine();
        CountingNumber(numberToCheck, numbers);




    }

    static void CountingNumber(int numberToCheck, int[] numbers)
    {
        int counter = 0;
        foreach (int item in numbers)
        {
            if (item == numberToCheck)
            {
                counter++;
            }

        }

        if (counter > 0)
        {
            Console.WriteLine("The count is {0}",counter);
        }
        else if (counter == 0)
        {
            Console.WriteLine("The number \"{0}\" does not exists!",numberToCheck);
        }

    }

}

