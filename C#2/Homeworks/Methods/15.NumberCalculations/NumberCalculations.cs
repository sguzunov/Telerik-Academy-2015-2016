using System;
using System.Collections.Generic;

// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("The min is: {0}", Min(1, 2, 3, 4, 5));
        Console.WriteLine("The max is: {0}", Max(2.9, 2.3, 13.3, 4, 5));
        Console.WriteLine("The average is: {0}", Average(1, 2, 3, 4, 5));
        Console.WriteLine("The sum is: {0}", Sum(1, 2, 3, 4, 5));
        Console.WriteLine("The product is: {0}", Product(1, 2, 3, 4, 5));
    }

    static T Min<T>(params T[] numbers)
    {
        dynamic min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;

    }

    static T Max<T>(params T[] numbers)
    {
        dynamic max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    static T Average<T>(params T[] numbers)
    {
        dynamic count = numbers.Length;
        dynamic sum = 0;
        dynamic average = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        average = sum / count;
        return average;

    }

    static T Sum<T>(params T[] numbers)
    {
        dynamic sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    static T Product<T>(params T[] numbers)
    {
        dynamic product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}

