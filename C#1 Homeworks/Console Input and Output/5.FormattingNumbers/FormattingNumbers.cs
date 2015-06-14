using System;

class FormattingNumbers
{
    static void Main()
    {   
        int a;
        double b, c;
        do{            
            Console.Write("(0 <= a <= 500) a=");
            a = int.Parse(Console.ReadLine());
        
          }while(!((a>=0)&&(a<=500)));

        Console.Write("b=");
        b = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        Console.Write("c=");
        c = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));

        Console.WriteLine();

        Console.WriteLine("{0,-10}|{1,-10}|{2,-10}|{3,-43}|","a","b","c","result");
        Console.WriteLine("{0,-10}|{1,-10}|{2,-10}|{3,-10:X}|{4,-10}|{5,10:F2}|{6,-10:F2}|",a,b,c,a,Convert.ToString(a,2).PadLeft(10,'0'),b,c);























    }
}

