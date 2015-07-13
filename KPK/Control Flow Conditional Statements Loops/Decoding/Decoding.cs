namespace Decoding
{
    using System;

    public class Decoding
    {
        public static void Main()
        {
            int saltNumber = 0;
            string decodeText = string.Empty;

            saltNumber = int.Parse(Console.ReadLine());
            decodeText = Console.ReadLine();

            double result = 0;
            int charCode = 0;
            for (int i = 0; i < decodeText.Length; i++)
            {
                char currentChar = decodeText[i];
                charCode = (int)currentChar;
                if (currentChar == '@')
                {
                    break;
                }
                else if (currentChar == ' ')
                {
                    continue;
                }
                else if (char.IsLetter(currentChar))
                {
                    result = (charCode * saltNumber) + 1000;
                }
                else if (char.IsNumber(currentChar))
                {
                    result = charCode + saltNumber + 500;
                }
                else
                {
                    result = charCode - saltNumber;
                }

                if (i % 2 == 0)
                {
                    result = result / 100;
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    Console.WriteLine(result * 100);
                }
            }
        }
    }
}
