using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        int number, position;
        Console.WriteLine("Type a number and a position:");
        number = int.Parse(Console.ReadLine());
        position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine("At position {0} we have bit: {1}",position,bit);

    }
}

