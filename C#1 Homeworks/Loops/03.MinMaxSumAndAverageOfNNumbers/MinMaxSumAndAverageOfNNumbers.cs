using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int min = arr[0];
        int max = arr[0];
        double sum = 0;
        int counter = 0;
    
        Console.WriteLine("Enter {0} numbers:",n);
        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            arr[i] = input;
        }

        for (int i = 1; i < n; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
            if (max < arr[i])
            {
                max = arr[i];
            }

            sum += arr[i];
            counter++;
        }

        Console.WriteLine();

        Console.WriteLine("min={0}", min);
        Console.WriteLine("max={0}", max);
        Console.WriteLine("sum={0}",sum);
        Console.WriteLine("avg={0:F2}", sum/counter);
       






    }
}

