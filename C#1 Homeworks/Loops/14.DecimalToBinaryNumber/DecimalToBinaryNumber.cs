using System;

class DecimalToBinaryNumber
{
    static void Main()
    {

        Console.Write("Enter a decimal number: ");
        long number = long.Parse(Console.ReadLine());

        string result = string.Empty;
        long remainder = 0;

        while (number > 0)
        {
            remainder = number % 2;
            number = number / 2;
            result = Convert.ToString(remainder) + result;
            
        }
        Console.WriteLine();
        Console.WriteLine("The result is: {0}",result);



    }
}

