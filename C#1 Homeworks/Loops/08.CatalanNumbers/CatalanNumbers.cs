using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        
        int n;
        BigInteger factorialDoubleN = 1;
        BigInteger factorialN = 1;
        BigInteger factorialNPlusOne = 1;
        
        do
        {
            Console.WriteLine("Enter n (0 <= n <= 100)");
            n = int.Parse(Console.ReadLine());
        }
        while (!((0 <= n) && (n <= 100)));

        for (int i = 1; i <= 2*n; i++)
        {
            factorialDoubleN = factorialDoubleN * i;

            if (i <= n)
            {
                factorialN = factorialN * i;
            }

        }

        for (int i = 1; i <= (n+1); i++)
        {
            factorialNPlusOne = factorialNPlusOne * i;
        }

        Console.WriteLine();
        Console.WriteLine("The result is: {0}",factorialDoubleN/(factorialNPlusOne*factorialN));
       

    }
}

