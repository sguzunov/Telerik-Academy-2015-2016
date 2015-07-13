namespace RefactorLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RefactorLoop
    {
        static void Main(string[] args)
        {
            const int EXPECTED_VALUE = 11;

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            bool isFoundSearched = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(numbers[i]);
                    if (numbers[i] == EXPECTED_VALUE)
                    {
                        isFoundSearched = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            if (isFoundSearched)
            {
                Console.WriteLine("Value is found!");
            }
        }
    }
}
