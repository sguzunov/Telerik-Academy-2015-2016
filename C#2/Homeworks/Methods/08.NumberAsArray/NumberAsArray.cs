using System;
using System.Collections.Generic;
using System.Threading;
using System.Numerics;

/*
Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
 */

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        BigInteger firstInput = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        BigInteger secondInput = BigInteger.Parse(Console.ReadLine());

        BigInteger[] firstReversed = ReverseANumber(firstInput);// reversing the first number
        BigInteger[] secondReversed = ReverseANumber(secondInput);// reversing the second number
        Console.WriteLine();        
        BigInteger[] sum = AddsArrays(firstReversed, secondReversed);// sum of the two numbers(as arrays)

        Console.Write("The sum is: ");
        for (int i = 0; i < sum.Length; i++)
        {
            Console.Write(sum[i]);
        }
        Console.WriteLine("  in reversed order.");

        Console.Write("The sum is: ");
         for (int i = sum.Length-1; i >=0; i--)
        {
            Console.Write(sum[i]);
        }
         Console.WriteLine("  in non reversed order.");
                
    }

    static BigInteger[] AddsArrays(BigInteger[] firstReversed, BigInteger[] secondReversed)
    {
        int longLength = Math.Max(firstReversed.Length, secondReversed.Length);
        int shortLength = Math.Min(firstReversed.Length, secondReversed.Length);
        BigInteger rest = 0;
        BigInteger sumOfDigits = 0;
        BigInteger restore = 0;
        BigInteger temp = 0;

        BigInteger[] result = new BigInteger[longLength+1];
        for (int i = 0; i < shortLength ; i++)
        {
            sumOfDigits = firstReversed[i] + secondReversed[i];
            if (i != shortLength - 1)
            {                
                if (sumOfDigits > 9)
                {
                    rest = sumOfDigits % 10;
                    result[i] = rest;
                    sumOfDigits /= 10;
                    firstReversed[i + 1] += sumOfDigits;

                }
                else if (sumOfDigits >= 0 && sumOfDigits <= 9)
                {
                    result[i] = sumOfDigits;
                }
            }
            else if(i==shortLength-1)
            {
                if (sumOfDigits > 9)
                {
                    rest = sumOfDigits % 10;
                    result[i] = rest;
                    sumOfDigits /= 10;                    
                    if (firstReversed.Length > secondReversed.Length)
                    {
                        firstReversed[i + 1] += sumOfDigits;
                    }
                    if (firstReversed.Length < secondReversed.Length)
                    {
                        secondReversed[i + 1] += sumOfDigits;
                    }

                }
                else if (sumOfDigits >= 0 && sumOfDigits <= 9)
                {
                    

                }
            }

        }
        for (int j = shortLength; j < longLength; j++)
        {
            
            if (firstReversed.Length > secondReversed.Length)
            {
                if (j != longLength - 1)
                {
                    temp = firstReversed[j];
                    result[j] = temp % 10;
                    temp /= 10;
                    firstReversed[j + 1] = temp;
                }
                else 
                {
                    temp = firstReversed[j];
                    result[j] = temp % 10;
                    temp /= 10;
                    result[j + 1] = temp;
                }

                /*
                result[j] = firstReversed[j];                       
                rest = temp % 10;
                result[j] = rest;
                temp /= 10;
                firstReversed[j + 1] += temp;
               */
            }
            if (firstReversed.Length < secondReversed.Length)
            {

                if (j != longLength - 1)
                {
                    temp = secondReversed[j];
                    result[j] = temp % 10;
                    temp /= 10;
                    secondReversed[j + 1] = temp;
                }
                else
                {
                    temp = secondReversed[j];
                    result[j] = temp % 10;
                    temp /= 10;
                    result[j + 1] = temp;
                }

                /*
                result[j] = firstReversed[j];
                temp = secondReversed[j];
                rest = temp % 10;
                result[j] = rest;
                temp /= 10;
                secondReversed[j + 1] += temp;
                 */
            }

        }

        return result;
        
    }

    static BigInteger[] ReverseANumber(BigInteger number)
    {
        string numberAsString=Convert.ToString(number);
        BigInteger[] reversed = new BigInteger[numberAsString.Length];

        int digit = 0;
        int i = 0;
        while (number != 0)
        {
            digit = (int)number % 10;
            reversed[i] = digit;
            number /= 10;
            i++;
        }

        return reversed;
    }
   

}

