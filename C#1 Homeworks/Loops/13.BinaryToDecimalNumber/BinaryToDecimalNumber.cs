using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string s = Console.ReadLine();
        long result=0;
        int strn = s.Length;
        for (int i = 0; i < strn; i++)
        {
            if (s[strn - i - 1] == '0') continue;
            result += (long)Math.Pow(2, i);
            
        }
        Console.WriteLine();
        Console.WriteLine(result);
    }
}

