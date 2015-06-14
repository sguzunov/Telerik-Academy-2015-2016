using System;

class QuadraticEquation
{
    static void Main()
    {
        double a, b, c,d,root1,root2,rootOneAndTwo;
        string noRoots = "no real roots";
        Console.WriteLine("Input coefficients");
        Console.Write("a=");
        a = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        Console.Write("b=");
        b = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        Console.Write("c=");
        c = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));

        d = (b * b) - (4 * a * c);

        if (d < 0)
        {
            Console.WriteLine(new string('-', 33));
            Console.WriteLine("|{0,5}|{1,5}|{2,5}|{3,13}|", a, b, c,noRoots);
            Console.WriteLine(new string('-', 33));
        }


        if (d == 0)
        {
            Console.WriteLine(new string('-', 27));
            Console.WriteLine("|{0,5}|{1,5}|{2,5}|{3,7:F2}|", a, b, c, -b/2*a);
            Console.WriteLine(new string('-', 27));
        }


        if (d > 0)
        {
            root1 = (-b + Math.Sqrt(d) / 2 * a);
            root2 = (-b - Math.Sqrt(d) / 2 * a);

            Console.WriteLine(new string('-', 36));
            Console.WriteLine("|{0,5}|{1,5}|{2,5}|x1={3:F2} x2={4,4:F2} |", a, b, c, root1,root2);
            Console.WriteLine(new string('-', 36));
        }




       











    }
}

