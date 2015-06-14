using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("N=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("min=");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("max=");
        int max = int.Parse(Console.ReadLine());
        Random r = new Random();
        int number;

        for (int i=0; i< n; i++)
        {
            number = r.Next(min,max);
            Console.Write("{0} ",number);

        }




    }
}

