using System;

class FibonacciNumbers
{                                       // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        int number1=0;
        int number2=1;
        int sum;
        Console.WriteLine("Fibonacci sequence ");
        Console.Write("{0}, {1}, ",number1,number2);
        for (int i = 0; i < (n-2); i++)
        {
            sum = number1 + number2;
            number1 = number2;
            number2 = sum;
            Console.Write("{0}, ",number2);        
        
        
        }

        

    }
}

