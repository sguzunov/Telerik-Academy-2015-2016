using System;


class CheckForAPlayCard
{
    static void Main()
    {

        Console.Write("Enter a sign: ");
        string sign = Console.ReadLine();
        switch (sign)
        {
            case "`2": Console.WriteLine("YES"); break;
            case "3": Console.WriteLine("YES"); break;
            case "4": Console.WriteLine("YES"); break;
            case "5": Console.WriteLine("YES"); break;
            case "6": Console.WriteLine("YES"); break;
            case "7": Console.WriteLine("YES"); break;
            case "8": Console.WriteLine("YES"); break;
            case "9": Console.WriteLine("YES"); break;
            case "10": Console.WriteLine("YES"); break;
            case "J": Console.WriteLine("YES"); break;
            case "Q": Console.WriteLine("YES"); break;
            case "K": Console.WriteLine("YES"); break;
            case "A": Console.WriteLine("YES"); break;
            default: Console.WriteLine("NO"); break;
        
        }


    }
}

