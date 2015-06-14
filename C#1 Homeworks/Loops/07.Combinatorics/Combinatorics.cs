using System;

class Combinatorics
{
    static void Main()
    {
        int n, k;
        int factorialN = 1;
        int factorialK = 1;
        int factDifference = 1;
        int difference;

        do
        {
            Console.WriteLine("Enter n (1<n<100)");
            n = int.Parse(Console.ReadLine());
        }
        while (!((1 < n) && (n < 100)));

        do
        {
            Console.WriteLine("Enter k (1<k<{0})", n);
            k = int.Parse(Console.ReadLine());
        }
        while (!((1 < k) && (k < n)));

        difference = n - k;

        for (int i = 1; i <= n; i++)
        {
            factorialN = factorialN * i;

            if (i <= k)
            {
                factorialK = factorialK * i;
            }

        }

        for (int i = 1; i <= difference; i++)
        {
            factDifference = factDifference * i;
        }

        Console.WriteLine("The result is:{0}",factorialN/(factorialK*factDifference));


    }
}

