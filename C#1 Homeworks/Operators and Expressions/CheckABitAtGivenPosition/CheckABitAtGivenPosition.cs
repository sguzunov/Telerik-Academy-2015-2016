using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        int number, position;       
        Console.WriteLine("Type a number");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Type a position");
        position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine(bit==1?true:false);

    }
}

