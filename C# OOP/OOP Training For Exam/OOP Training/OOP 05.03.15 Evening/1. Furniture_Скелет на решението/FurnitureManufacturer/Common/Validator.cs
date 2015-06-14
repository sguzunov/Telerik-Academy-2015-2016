namespace FurnitureManufacturer.Common
{
    using System;

    public class Validator
    {
        public static void IsValidDecimal(decimal number, string msg)
        {
            if (number <= 0.0m)
            {
                throw new ArgumentOutOfRangeException(msg);
            }
        }

        public static void IsValidString(string str, int countSymbols, string msg)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(msg);
            }
            if (str.Length < countSymbols)
            {
                throw new ArgumentException(msg);
            }
        }

        public static void IsValidRegistrationNumber(string number, string msg)
        {
            if (number.Length != 10)
            {
                throw new ArgumentOutOfRangeException(msg);
            }

            foreach (var ch in number)
            {
                if (char.IsLetter(ch))
                {
                    throw new ArgumentException(msg);
                    return;
                }
            }
        }
    }
}
