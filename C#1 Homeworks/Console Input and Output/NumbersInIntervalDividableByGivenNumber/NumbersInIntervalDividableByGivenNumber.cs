using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {   
        int br=0;
        Console.WriteLine("Enter the numbers:");
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int difference = Math.Abs(start - end);
        for (; start <= end; start++)
        {
            if (start % 5 == 0)
            {
                br++;
            }
        }
        Console.WriteLine(br);
    }
}

