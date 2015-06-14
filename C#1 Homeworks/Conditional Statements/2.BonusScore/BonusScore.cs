using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score:");
        int score = int.Parse(Console.ReadLine());
        if ((score >= 1) && (score <= 3))
        {
            Console.WriteLine("result: {0}",score*10);
        }

        if ((score >= 4) && (score <= 6))
        {
            Console.WriteLine("result: {0}", score * 100);
        }

        if ((score >= 7) && (score <= 9))
        {
            Console.WriteLine("result: {0}", score * 1000);
        }

        if ((score == 7) || (score > 9))
        {
            Console.WriteLine("Invalid score!!!");
        }   


            

    }
}

