using System;

class NullValuesArithmetic
{
    static void Main()
    {   
        int? a = null;
        double? b=null;
        Console.WriteLine("Nullable values:\nint a={0};\ndouble b={1};",a,b);
        a = a + 2;
        b = b + 3.15;
        Console.WriteLine("Nullable values + number:\nint a={0};\ndouble b={1};",a,b);
        Console.WriteLine();        

    }
}

