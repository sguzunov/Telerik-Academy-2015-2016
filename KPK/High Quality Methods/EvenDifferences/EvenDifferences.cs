namespace EvenDifferences
{
    using System;
    using System.Collections.Generic;

    public class EvenDifferences
    {
        public static const int EVEN_JUMP = 1;

        public static void Main()
        {
            string input = Console.ReadLine();

            string[] inputAsArray = input.Split(' ');
            int[] numbers = ConvertStringsToIntegerNumbers(inputAsArray);
            List<int> absoluteDifferences = GetAbsoluteDifferences(numbers);
            int sum = SumEvenAbsoluteDifferences(absoluteDifferences);

            Console.WriteLine(sum);
        }

        private static int SumEvenAbsoluteDifferences(List<int> absoluteDifferences)
        {
            int sum = 0;
            for (int i = 0; i < absoluteDifferences.Count; i++)
            {
                if (absoluteDifferences[i] % 2 == 0)
                {
                    sum += absoluteDifferences[i];
                }
            }

            return sum;
        }

        private static int[] ConvertStringsToIntegerNumbers(string[] inputAsArray)
        {
            if (inputAsArray == null || inputAsArray.Length == 0)
            {
                throw new ArgumentException("No arguments passed.");
            }

            int[] result = new int[inputAsArray.Length];
            for (int i = 0; i < inputAsArray.Length; i++)
            {
                result[i] = int.Parse(inputAsArray[i]);
            }

            return result;
        }

        private static List<int> GetAbsoluteDifferences(int[] numbers)
        {
            List<int> result = new List<int>();
            for (int i = 1; i < numbers.Length; i++)
            {
                int difference = Math.Abs(numbers[i] - numbers[i - 1]);
                result.Add(difference);

                if (difference % 2 == 0)
                {
                    i += EVEN_JUMP;
                }
            }

            return result;
        }
    }
}
