using System;
using System.Collections.Generic;

// Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).

class BinaryFloatingPoint
{
    static void Main()
    {
        Console.Write("Enter a numer: ");
        float inputNumber = float.Parse(Console.ReadLine());

        int sign;
        if (inputNumber > 0)
        {
            sign = 0;        
        }
        else
        {
            sign = 1;
            inputNumber = Math.Abs(inputNumber);
        }

        string binaryNumber = ConvertToBinary(inputNumber);

        Console.WriteLine("\nSign: {0}",sign);
        Console.WriteLine("Exponent: {0}",binaryNumber.Substring(0,8));
        Console.WriteLine("Mantisa: {0}\n",binaryNumber.Substring(8));


    }

    static string ConvertToBinary(float inputNumber)
    {
        byte[] b = BitConverter.GetBytes(inputNumber);
        int i = BitConverter.ToInt32(b, 0);
        return Convert.ToString(i, 2);
        
    }

}

