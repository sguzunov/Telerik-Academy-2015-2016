using System;
using System.Linq;
using System.Threading;

// Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter the number of element: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        Console.WriteLine("Enter the elements in the array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("numbers[{0}]= ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the position of the element: ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine();
        LargeNumber(position, numbers,n);


    }

    static void LargeNumber(int position, int[] numbers,int n)
    {
        if ((position >= 0) && (position <= (n - 1)))
        {
            if ((numbers[position] > numbers[position - 1]) && (numbers[position] > numbers[position + 1]))
            {
                Console.WriteLine("The number at position is larger than its neighbours");
            }
            else
            {
                Console.WriteLine("The number at position is NOT larger than its neighbours");
            }

        }
        else
        {
            Console.WriteLine("Such a number does not exists!");

        }

    }
}

