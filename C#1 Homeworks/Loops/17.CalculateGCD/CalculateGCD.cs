using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b=");
        int b = int.Parse(Console.ReadLine());

         if (a == 0 )
         {
             Console.WriteLine("Result: {0}", b);
         }
        else if(b==0)
         {
             Console.WriteLine("Result: {0}", a);
         }
        

         else if (a != 0 && b != 0)
        {
            if (a > b)
            {
                Console.WriteLine("Result: {0}", a % b);
            }
            else
            {
                Console.WriteLine("Result: {0}", b % a);
                
            }
        }

       

    }
}

