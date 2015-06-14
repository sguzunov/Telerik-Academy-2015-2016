namespace DivisibleBySevenAndThree
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Extentions
    {
        public static IEnumerable<int> NumbersDivisableByLinq(this IEnumerable<int> numbers)
        {
            var result =
                from number in numbers
                where (number % 7 == 0 && number % 3 == 0)
                select number;

            return result;
        }

        public static IEnumerable<int> NumbersDivisableByLambda(this IEnumerable<int> numbers)
        {
            var result = numbers.Where(x => x % 7 == 0 && x % 3 == 0);

            return result;
        }
    }
}
