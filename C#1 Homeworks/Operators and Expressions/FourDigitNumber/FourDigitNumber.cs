using System;

class FourDigitNumber
{
    static void Main()
    {
        int number;
        string str1Number,str2Number="";
        int sum;
        Console.Write("Enter a four-digit number: ");
        while (!int.TryParse(Console.ReadLine(), out number) && number < 1000 && number > 9999)
        {
            Console.WriteLine("Enter a four-digit number!");
        }

        str1Number = number.ToString();

        int result = 0;

            for (int i = 0; i < strNumber.Length; i++)
            {
                result += strNumber[i] - 48;
            }

            Console.WriteLine("The sum of digits is: {0}", result);
        }




        for (int i = str1Number.Length - 1; i >= 0; i--)
        {
            str2Number += str1Number[i];
        }
        Console.WriteLine(str2Number);

        Console.WriteLine("First digit in front position: {0}{1}{2}{3}",str1Number[3],str1Number[0],str1Number[1],str1Number[2]);
        Console.WriteLine("The second and the third digits are exchanged: {0}{1}{2}{3}", str1Number[0], str1Number[2], str1Number[1], str1Number[3]);







        


    }
}

