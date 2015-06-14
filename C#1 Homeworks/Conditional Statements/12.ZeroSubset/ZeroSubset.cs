using System;

class IsSomeSubsetZeroSecondSolution
{
    static void Main()
    {
        int one, two, three, four, five;
        bool isOne = int.TryParse(Console.ReadLine(), out one);
        bool isTwo = int.TryParse(Console.ReadLine(), out two);
        bool isThree = int.TryParse(Console.ReadLine(), out three);
        bool isFour = int.TryParse(Console.ReadLine(), out four);
        bool isFive = int.TryParse(Console.ReadLine(), out five);
        int counter = 0;
        if (isOne && isTwo && isThree && isFour && isFive)
        {
            int sum = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int p = 0; p < 2; p++)
                        {
                            for (int q = 0; q < 2; q++)
                            {
                                if ((i != 0) || (k != 0) || (j != 0) || (p != 0) || (q != 0))
                                {
                                    sum = one * i + two * k + three * j + four * p + five * q;
                                    if (sum == 0)
                                    {
                                        Console.WriteLine("{0}",sum);
                                        
                                    }
                                }
                                
                            }
                        }   
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("b0Om! Try again!");
        }
    }

}