using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        
        Console.WriteLine("Enter a decimal number:");
        long decNumber = long.Parse(Console.ReadLine());
        string hexaNumber="";

        if (decNumber == 0)
        {
            hexaNumber = "0";
        }
        else
        {
            
            while (decNumber > 0)
            {
                long remainder = decNumber % 16;
                decNumber = decNumber / 16;

                switch (remainder)
                {
                    case 10: hexaNumber = "A" + hexaNumber; break;
                    case 11: hexaNumber = "B" + hexaNumber; break;
                    case 12: hexaNumber = "C" + hexaNumber; break;
                    case 13: hexaNumber = "D" + hexaNumber; break;
                    case 14: hexaNumber = "E" + hexaNumber; break;
                    case 15: hexaNumber = "F" + hexaNumber; break;
                    default: hexaNumber = remainder + hexaNumber; break;
                }
            }

        }
        Console.WriteLine();
        Console.WriteLine(hexaNumber);
         

    }
}

