namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;

    public class ConsoleApplication
    {
        public static void Main()
        {
            const string END_OF_INPUT = "END";
            const int START_POSITION_LESS_THAN_TEN = 0;
            const int START_POSITION_MORE_THAN_TEN = 10;

            int number = 0;
            string input = string.Empty;
            List<int> numbers = new List<int>();

            while (true)
            {
                input = Console.ReadLine();
                if (input == END_OF_INPUT)
                {
                    break;
                }

                number = int.Parse(input);
                numbers.Add(number);
            }

            int productForFirstTenNumbers = 1;
            int productForLeftNumbers = 1;
            if (numbers.Count <= 10)
            {
                productForFirstTenNumbers = CalculateProduct(numbers, START_POSITION_LESS_THAN_TEN, numbers.Count);
                Console.WriteLine(productForFirstTenNumbers);
            }
            else
            {
                productForFirstTenNumbers = CalculateProduct(numbers, START_POSITION_LESS_THAN_TEN, 10);
                productForLeftNumbers = CalculateProduct(numbers, START_POSITION_MORE_THAN_TEN, numbers.Count);

                Console.WriteLine(productForFirstTenNumbers);
                Console.WriteLine(productForLeftNumbers);
            }
        }

        private static int CalculateProduct(List<int> numbers, int startPosition, int endPosition)
        {
            int product = 1;

            for (int i = startPosition; i < endPosition; i++)
            {
                if (i % 2 != 0)
                {
                    product *= GetProductOFDigits(numbers[i]);
                }
            }

            return product;
        }

        private static int GetProductOFDigits(int number)
        {
            int product = 1;
            while (number != 0)
            {
                int lastDigit = number % 10;
                number /= 10;
                if (lastDigit == 0)
                {
                    continue;
                }

                product *= lastDigit;
            }

            return product;
        }
    }
}
