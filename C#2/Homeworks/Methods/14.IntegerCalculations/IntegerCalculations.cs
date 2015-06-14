using System;

// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("The min is: {0}", Min(1, 2, 3, 4, 5));
        Console.WriteLine("The max is: {0}", Max(1, 2, 3, 4, 5));
        Console.WriteLine("The average is: {0}", Average(1, 2, 3, 4, 5));
        Console.WriteLine("The sum is: {0}", Sum(1, 2, 3, 4, 5));
        Console.WriteLine("The product is: {0}", Product(1, 2, 3, 4, 5));
    }

    static decimal Min(params decimal[] numbers)
    {
        decimal min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;

    }

    static decimal Max(params decimal[] numbers)
    {
        decimal max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    static decimal Average(params decimal[] numbers)
    {
        int count = numbers.Length;
        decimal sum = 0;
        decimal average = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        average = sum / count;
        return average;

    }

    static decimal Sum(params decimal[] numbers)
    {
        decimal sum = 0;        
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    static decimal Product(params decimal[] numbers)
    {
        decimal product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}

