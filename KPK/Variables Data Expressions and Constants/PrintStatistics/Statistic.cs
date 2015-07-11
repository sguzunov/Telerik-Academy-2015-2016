namespace Statistics
{
    using System;

    public static class Statistic
    {
        public static void PrintMaxElement(double[] numbers, int count)
        {
            double maxElement = double.MinValue;

            for (int i = 0; i < count; i++)
            {
                if (maxElement < numbers[i])
                {
                    maxElement = numbers[i];
                }
            }

            Console.WriteLine(maxElement);
        }

        public static void PrintMinElement(double[] numbers, int count)
        {
            double minElement = double.MaxValue;

            for (int i = 0; i < count; i++)
            {
                if (minElement > numbers[i])
                {
                    minElement = numbers[i];
                }
            }

            Console.WriteLine(minElement);
        }

        public static void PrintAverageOfElements(double[] numbers, int count)
        {
            double sumOfElements = 0;

            for (int i = 0; i < count; i++)
            {
                sumOfElements += numbers[i];
            }

            double averageValue = sumOfElements / count;

            Console.WriteLine(averageValue);
        }
    }
}
