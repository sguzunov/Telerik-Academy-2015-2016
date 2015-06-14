using System;
using System.Numerics;

/* 
    Write a program that can solve these tasks:
    Reverses the digits of a number
    Calculates the average of a sequence of integers
    Solves a linear equation a * x + b = 0
    Create appropriate methods.
    Provide a simple text-based menu for the user to choose which task to solve.
    Validate the input data:
    The decimal number should be non-negative
    The sequence should not be empty
    a should not be equal to 0
 */ 

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose one of the following options:"+
            "\n1.Reverses the digits of a number" + "\n2.Calculates the average of a sequence of integers"+
            "\n3.Solves a linear equation a * x + b = 0");
        Console.Write("-");
        int option = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (option == 1)
        {
            int number = int.MinValue;
            do
            {
                Console.Write("Enter a number");
                number = int.Parse(Console.ReadLine());
            }
            while (number <= 0);

            ReverseDigits(number);
        }
        else if(option==2)
        {
            int length = int.MinValue;
            do
            {
                Console.Write("Enter a lenght ");
                length = int.Parse(Console.ReadLine());
            }
            while (length <= 0);

            Console.WriteLine("The average of the numbers is {0}", AverageOfSequence(length));
            Console.WriteLine();
        }
        else if (option == 3)
        {
            decimal a, b;

            do
            {
                Console.Write("Enter \"a\" = ");
                a = int.Parse(Console.ReadLine());
            }
            while (a == 0);
            Console.WriteLine("Enter \"b\" = ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            SolveEquation(a, b);

        }
    }

    static void SolveEquation(decimal a, decimal b)
    {
        decimal x = -b / a;
        Console.WriteLine("x={0}",x);
    }

    static decimal AverageOfSequence(int length)
    {
        decimal average = 0;
        int sum = 0;

        int[] arr = new int[length];        
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter a number in the sequence ");
            arr[i] = int.Parse(Console.ReadLine());
            sum = sum + arr[i];
        }
        average = (decimal)sum / length;

        return average;
    }


    static void ReverseDigits(int number)
    {
        string reversed = "";
        int digit=0;

        while (number != 0)
        {
            digit = number % 10;
            reversed += Convert.ToString(digit);
            number /= 10;
        }

        Console.Write("The reversed number is: ");
        foreach (char item in reversed)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }


}

