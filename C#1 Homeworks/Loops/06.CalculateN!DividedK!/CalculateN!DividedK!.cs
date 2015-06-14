using System;

class CalculateNFactorialDividedKFactorial
{
    static void Main()
    {  
        int n,k;
        int factorialN = 1;
        int factorialK = 1;

        do
        {
        Console.WriteLine("Enter n (1<n<100)");
        n=int.Parse(Console.ReadLine());
        }
        while(!((1<n)&&(n<100)));

        do
        {
        Console.WriteLine("Enter k (1<k<{0})",n);
        k=int.Parse(Console.ReadLine());
        }
        while(!((1<k)&&(k<n)));

        for (int i = 1; i <= n; i++)
        {
            factorialN = factorialN * i;

            if (i <= k)
            {
                factorialK = factorialK * i;
            }
            
        }
        Console.WriteLine("The result is:{0}",factorialN/factorialK);

    }
}

