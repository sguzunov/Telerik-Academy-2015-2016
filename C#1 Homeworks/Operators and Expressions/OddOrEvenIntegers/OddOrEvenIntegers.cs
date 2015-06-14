using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int x;
        Console.WriteLine("Type a number : ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine(x%2==0?"Even":"Odd");

    }
}

