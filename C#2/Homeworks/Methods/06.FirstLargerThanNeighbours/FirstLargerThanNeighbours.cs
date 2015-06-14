using System;
using System.Threading;

//  Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//  Use the method from the previous exercise.


class FirstLargerThanNeighbours
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
              

       Console.WriteLine();
       int position=FirstLargeNumber(numbers);

       if (position > 0)
       {
           Console.WriteLine("The element is on posotion {0}", position);
       }
       else
       {
           Console.WriteLine(position);          
       }

    }

    static int FirstLargeNumber(int[] numbers)
    {
        int position = 0;

        for (int i = 1; i < numbers.Length-1; i++)
        {
            if ((numbers[i] > numbers[i - 1]) && (numbers[i] > numbers[i + 1]))
            {
                position = i;
                break;
            }          
        }

        if (position != 0)
        {
            return position;
        }
        else
        {
            return -1;
        }

    }
}

