using System;


class ThirdDigitIs7
{
    static void Main()
    {
        int x,third;
        bool result;
        x = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        if (x >= 700)
        {
            third = (x / 100) % 10;
            result = third == 7 ? true : false;
            Console.WriteLine(result); 
        }
        else Console.WriteLine("False");

    }
}

