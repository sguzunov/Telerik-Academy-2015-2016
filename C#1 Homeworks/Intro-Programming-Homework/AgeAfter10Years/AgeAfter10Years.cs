using System;

class AgeAfter10Years
{
    static void Main()
    {
        string a;
        int x;

        Console.Write("Type your age:");
        a = Console.ReadLine();
        Console.Write("Your age is:");
        Console.Write(a);
        x = Convert.ToInt32(a);
        Console.WriteLine();
        Console.Write("After ten years you will be :");
        Console.Write(x + 10);
        Console.WriteLine();


    }
}

