using System;

/* 
    Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
    If an invalid number or non-number text is entered, the method should throw an exception.
    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/

class EnterNumbers
{
    static int ReadNumber(int start, int end,int previousNumber)
    {
        int number=0;
        
        try
        {
            number = int.Parse(Console.ReadLine());
            if ((number < start) || (number > end) || (number < previousNumber))
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (ArgumentOutOfRangeException re)
        {
            Console.Error.WriteLine("The number was out of the range!" + " " + re.Message);
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine("The number was not in a correct format!" + " " + fe.Message);
        }

        return number;
    }
    
    static void Main()
    {
        int start, end;
        int previousNumber = 0;
        int number = 0;

        Console.Write("Enter first border: ");
        start = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("Enter second border (the number must be bigger than the first one): ");
            end = int.Parse(Console.ReadLine());
        }
        while (end < start);

        Console.WriteLine();
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter a number:");
            number = ReadNumber(start, end, previousNumber);
            previousNumber = number;
        }

    }
}