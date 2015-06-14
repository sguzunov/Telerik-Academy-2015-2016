using System;


class CalculatingASum
{
    static void Main()
    {
        Console.WriteLine("Enter numbers:");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int fac = 1;
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            fac = fac * i;
            sum = sum + (fac / Math.Pow(x, i));
            
        }
        Console.WriteLine("The sum is:{0:f5}",sum);

    }
}

