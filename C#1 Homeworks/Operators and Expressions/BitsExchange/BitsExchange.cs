using System;

class BitsExchange
{
    static void Main()
    {

        uint number;
        Console.WriteLine("Type a number");
        number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Before:{0}\t{1}",number,Convert.ToString(number,2).PadLeft(32,'0'));

        // exchanges 3 with 24
        uint maskThree = 1 << 3;
        uint resultThree = number & maskThree;
        resultThree >>= 3;

        uint maskTwentyFour = 1 << 24;
        uint resultTwentyFour = number & maskTwentyFour;
        resultTwentyFour >>= 24;
        
        if (resultThree == 1)
        {
            number |= maskTwentyFour;
        }

        else
        {
            number &= (~maskTwentyFour);
        }

        if (resultTwentyFour == 1)
        {
            number |= maskThree;
        }

        else
        {
            number &= (~maskThree);
        }

        // exchanges 4 with 25
        uint maskFour = 1 << 4;
        uint resultFour = number & maskFour;
        resultFour >>= 4;

        uint maskTwentyFive = 1 << 25;
        uint resultTwentyFive = number & maskTwentyFive;
        resultTwentyFive >>= 25;

        if (resultFour == 1)
        {
            number |= maskTwentyFive;
        }

        else
        {
            number &= (~maskTwentyFive);
        }

        if (resultTwentyFive == 1)
        {
            number |= maskFour;
        }

        else
        {
            number &= (~maskFour);
        }


        // exchanges 5 with 26
        uint maskFive = 1 << 5;
        uint resultFive = number & maskFive;
        resultFive >>= 5;

        uint maskTwentySix = 1 << 26;
        uint resultTwentySix = number & maskTwentySix;
        resultTwentySix >>= 26;

        if (resultFive == 1)
        {
            number |= maskTwentySix;
        }

        else
        {
            number &= (~maskTwentySix);
        }

        if (resultTwentySix == 1)
        {
            number |= maskFive;
        }

        else
        {
            number &= (~maskFive);
        }
        Console.WriteLine();
        Console.WriteLine("After {0}\t{1}",number,Convert.ToString(number,2).PadLeft(32,'0'));


    }
}

