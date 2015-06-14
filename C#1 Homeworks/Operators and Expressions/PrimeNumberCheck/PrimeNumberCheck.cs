using System;

class PrimeNumberCheck
{
    static void Main()
    {

        int number;
        bool prime=true;
        Console.WriteLine("Insert a positive number <=100 :");
        number = int.Parse(Console.ReadLine());
        while (!((number > 0) && (number <= 100)))
        {
            Console.WriteLine("Insert a positive number <=100 :");
            number = int.Parse(Console.ReadLine());

        }

        if (number < 2)
        {
            prime = false;
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) prime = false;
            }
        }

        Console.WriteLine(prime); 

       

        
        





    }
}

