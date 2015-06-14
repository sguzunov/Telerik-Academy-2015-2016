using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {   
        Console.WriteLine("Enter a hexadecimal number:");
        string hexaNumber = Console.ReadLine();
        long decNumber = 0;
        long power = 1;
        int number;

        for (int i = hexaNumber.Length-1; i >= 0; i--)
        {
            switch (hexaNumber[i])
            {
                case 'A': number = 10; break;
                case 'B': number = 11; break;
                case 'C': number = 12; break;
                case 'D': number = 13; break;
                case 'E': number = 14; break;
                case 'F': number = 15; break;
                default: number = Convert.ToInt32(hexaNumber[i]) - 48; break;

            }
            decNumber = decNumber+ (number * power);
            power = power * 16;
            
        }
        Console.WriteLine();
        Console.WriteLine(decNumber);

        
    }
}

