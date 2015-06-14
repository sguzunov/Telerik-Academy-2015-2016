using System;
using System.Numerics;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write("Enter a number:");
        long num=long.Parse(Console.ReadLine());
        BigInteger factorial=1,isZero;
        int counter=0;
        
        for (int i = 1; i <= num; i++)
			{
                factorial=factorial*i;			 
			}

        do
        {
            isZero=factorial% 10;
            factorial /= 10;
            if(isZero==0)
            {
                counter++;
            }

        }while(isZero==0);

        Console.WriteLine();
        Console.WriteLine("Zeroes= {0}",counter);
    }
}

