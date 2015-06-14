using System;

class SumOfNNumbers
{
    static void Main()
    {   
        
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the numbers to calculate:");
        decimal number,sum=0;
        for (int i = 0; i < n; i++)
        {
            number = decimal.Parse(Console.ReadLine());
            sum += number;

        }
        Console.WriteLine("The sum is: {0}",sum);



    }
}

