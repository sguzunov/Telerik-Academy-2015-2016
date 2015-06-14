using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int number, position,bitValue;
        Console.WriteLine("Type a number");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Type a position");
        position = int.Parse(Console.ReadLine());
        Console.WriteLine("Type 0 or 1");
        bitValue = int.Parse(Console.ReadLine());

        if (bitValue == 0)
        {
            int maskZero = ~(1 << position);
            int numberAndMaskZero = number & maskZero;
            int bitZero = numberAndMaskZero;
            Console.WriteLine("Result:{0}", bitZero);


        }
        else if (bitValue == 1)

        {
            int maskOne = 1 << position;
            int numberAndMaskOne = number | maskOne;
            int bitOne = numberAndMaskOne;
            Console.WriteLine("Result:{0}",bitOne);

        }



    }
}

