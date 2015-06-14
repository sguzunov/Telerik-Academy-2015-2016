using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        int pos = 3;
        uint x;
        int mask = 1 << pos;
        Console.WriteLine("Insert a number");
        x = uint.Parse(Console.ReadLine());
        uint xAndMask=x&(uint)mask;
        uint bitAtPositionThree = xAndMask >> pos;
        Console.WriteLine("It's #3: {0}",bitAtPositionThree);


    }
}

