namespace CalculationProblem
{
    using System;

    public class CalculationProblem
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] inputAsArray = input.Split(' ');

            double[] inputConvertedToDecimalBase = ConvertLetterNumbersToDecimalNumbers(inputAsArray);

            if (inputConvertedToDecimalBase.Length == 1)
            {
                Console.WriteLine(input + " = " + inputConvertedToDecimalBase[0]);
            }
            else
            {
                double sumOfDecimalBased = SumDecimalNumbers(inputConvertedToDecimalBase);
                string sum = ConvertDecimalBaseSystemToTwentyThreeBaseSystem((int)sumOfDecimalBased);
                Console.WriteLine("{0} = {1}", sum, sumOfDecimalBased);
            }
        }

        private static double SumDecimalNumbers(double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("No numbers passed.");
            }

            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private static double[] ConvertLetterNumbersToDecimalNumbers(string[] inputToConvert)
        {
            if (inputToConvert == null || inputToConvert.Length == 0)
            {
                throw new ArgumentException("No arguments passed.");
            }

            double[] result = new double[inputToConvert.Length];
            for (int i = 0; i < inputToConvert.Length; i++)
            {
                result[i] = ConvertTwentyThreeBaseSystemToDecimalBaseSystem(inputToConvert[i]);
            }

            return result;
        }

        private static string ConvertDecimalBaseSystemToTwentyThreeBaseSystem(int decimalNumber)
        {
            string convertedValue = string.Empty;
            while (decimalNumber != 0)
            {
                int reduce = decimalNumber % 23;
                decimalNumber /= 23;
                convertedValue = (char)(reduce + 'a') + convertedValue;
            }

            return convertedValue;
        }

        private static double ConvertTwentyThreeBaseSystemToDecimalBaseSystem(string valueToConvert)
        {
            double convertedValue = 0;
            for (int i = 0; i < valueToConvert.Length; i++)
            {
                char currentChar = valueToConvert[i];
                double charNumericValue = currentChar - 'a';
                double pow = valueToConvert.Length - i - 1;
                convertedValue += charNumericValue * Math.Pow(23, pow);
            }

            return convertedValue;
        }
    }
}
