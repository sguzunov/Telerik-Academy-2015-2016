using System;

class ComparingFloats
{
    static void Main()
    {

        float eps = 0.000001f;
        float a, b;
        Console.WriteLine("Write numbers:");
        Console.WriteLine("a=");
        a = Console.Read();
        Console.WriteLine("b=");
        b = float.Parse(Console.ReadLine());
        bool equal = Math.Abs(a - b) < eps;
        Console.WriteLine(equal);


    }
}

