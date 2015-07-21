namespace Methods
{
    using System;

    public class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Triangle's sides must be positive numbers.");
            }

            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

            return area;
        }

        static string GetDigitAsWord(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    throw new ArgumentException("Invalid digit to convert to string.");
            }
        }

        static int FindMaxElement(int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("No elements input.");
            }

            int maxElement = Int32.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (maxElement < elements[i])
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        static double CalculateDistanceBetweenTwoLines(double firstXCoordinate, double firstYCoordinate,
                                                       double secondXCoordinate, double secondYCoordinate)
        {
            double distance = Math.Sqrt((secondXCoordinate - firstXCoordinate) * (secondXCoordinate - firstXCoordinate) +
                (secondYCoordinate - firstYCoordinate) * (secondYCoordinate - firstYCoordinate));

            return distance;
        }

        static bool areHorizontalTwoLines(double firstYCoordinate, double secondYCoordinate)
        {
            bool areHorizontal = firstYCoordinate == secondYCoordinate;

            return areHorizontal;
        }

        static bool areVerticalTwoLines(double firstXCoordinate, double secondXCoordinate)
        {
            bool areVertical = firstXCoordinate == secondXCoordinate;

            return areVertical;
        }

        static void PrintNumberFixedPointed(object number)
        {
            if (number == null)
            {
                throw new FormatException("The number cannot be null.");
            }

            Console.WriteLine("{0:f2}", number);
        }

        static void PrintNumberAsPercent(object number)
        {
            if (number == null)
            {
                throw new FormatException("The number cannot be null.");
            }

            if ((double)number < 0 || (double)number > 1)
            {
                throw new IndexOutOfRangeException("The number must be in range (0,1). Otherwise you will get incorrect result.");
            }

            Console.WriteLine("{0:p0}", number);
        }

        static void PrintNumberRightAlignedEightSymbols(object number)
        {
            if (number == null)
            {
                throw new FormatException("The number cannot be null.");
            }

            Console.WriteLine("{0,8}", number);
        }

        static void Main()
        {
            double triangleArea = CalcTriangleArea(3, 4, 5);
            Console.WriteLine("Triangle area: {0}", triangleArea);

            string digitAsWord = GetDigitAsWord(5);
            Console.WriteLine("Digit as word: {0}", digitAsWord);

            PrintNumberFixedPointed(1.3);
            PrintNumberAsPercent(0.75);
            PrintNumberRightAlignedEightSymbols(2.30);

            bool areVertical, areHorizontal;
            areVertical = areVerticalTwoLines(3, 3);
            areHorizontal = areHorizontalTwoLines(-1, 2.5);
            Console.WriteLine("Are vertical ? {0}", areVertical);
            Console.WriteLine("Are horizontal ? {0}", areHorizontal);

            Student peter = new Student("Peter", "Ivanov");
            peter.AdditionalInformation = "From Sofia, born at 17.03.1992";

            Student stella = new Student("Stella", "Markova");
            stella.AdditionalInformation = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
