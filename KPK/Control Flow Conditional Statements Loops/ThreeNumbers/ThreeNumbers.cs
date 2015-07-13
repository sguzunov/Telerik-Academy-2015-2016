namespace ThreeNumbers
{
    using System;

    public class ThreeNumbers
    {
        public static void Main()
        {
            int firstNumber = 0, secondNumber = 0, thirdNumber = 0, biggestNumber = 0, smallestNumber = 0;
            decimal average = 0;

            firstNumber = int.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());
            thirdNumber = int.Parse(Console.ReadLine());

            if ((secondNumber <= firstNumber) && (thirdNumber <= firstNumber))
            {
                biggestNumber = firstNumber;
            }
            else if ((firstNumber <= secondNumber) && (thirdNumber <= secondNumber))
            {
                biggestNumber = secondNumber;
            }
            else if ((firstNumber <= thirdNumber) && (secondNumber <= thirdNumber))
            {
                biggestNumber = thirdNumber;
            }

            if ((firstNumber <= secondNumber) && (firstNumber <= thirdNumber))
            {
                smallestNumber = firstNumber;
            }
            else if ((secondNumber <= firstNumber) && (secondNumber <= thirdNumber))
            {
                smallestNumber = secondNumber;
            }
            else if ((thirdNumber <= firstNumber) && (thirdNumber <= secondNumber))
            {
                smallestNumber = thirdNumber;
            }

            average = (firstNumber + secondNumber + thirdNumber) / 3;

            Console.WriteLine(biggestNumber);
            Console.WriteLine(smallestNumber);
            Console.WriteLine("{0:F2}", average);
        }
    }
}
