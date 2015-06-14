namespace DivisibleBySevenAndThree
{
    using System;

    class Divisible
    {
        static void Main()
        {
            int[] arr = { 21, 9, 7, 3, 49, 63 };

            var result = arr.NumbersDivisableByLinq();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        //  Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda                 expressions. Rewrite the same with LINQ.

    }
}
