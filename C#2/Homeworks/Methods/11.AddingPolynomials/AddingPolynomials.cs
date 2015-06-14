using System;
using System.Collections.Generic;
using System.Threading;

// Write a method that adds two polynomials.
// Represent them as arrays of their coefficients.

class AddingPolynomials
{
    static void Main()
    {

        decimal[] firstArray = { 3, -2, 4 };
        decimal[] secondArray = { -5, 0, 4, 10, -2 };
        decimal[] result=new decimal[Math.Max(firstArray.Length,secondArray.Length)];

        Console.Write("First polynom   ");
        PrintArray(firstArray);
        Console.Write("Second polynom   ");
        PrintArray(secondArray);
        Console.Write("The sum   ");
        PrintArray(SumOfPolinomials(firstArray, secondArray, result));

    }

    static decimal[] SumOfPolinomials(decimal[] firstArray, decimal[] secondArray, decimal[] result)
    {
        int longArrayLenght = int.MinValue;
        int shortArrayLenght = int.MinValue;

        if (firstArray.Length < secondArray.Length)
        {
            shortArrayLenght = firstArray.Length;
            longArrayLenght = secondArray.Length;
        }
        else
        {
            shortArrayLenght = secondArray.Length;
            longArrayLenght = firstArray.Length;
        }

        result = new decimal[longArrayLenght];

        for (int i = 0; i < shortArrayLenght; i++)
        {
            result[i] = firstArray[i] + secondArray[i];
        }

        for (int i = shortArrayLenght; i < longArrayLenght; i++)
        {
            result[i] = (firstArray.Length > secondArray.Length ? firstArray[i] : secondArray[i]);

        }

        return result;
    }


    static void PrintArray(decimal[] polynom)
    {
        for (int i = polynom.Length-1; i >= 0; i--)
        {
            if (polynom[i] != 0 && i != 0)
            {
                if (polynom[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} + ", i, polynom[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polynom[i]);
                }

            }
            else if (i == 0)
            {
                Console.WriteLine("{0}", polynom[i]);
            }
            
        }

    }


}

