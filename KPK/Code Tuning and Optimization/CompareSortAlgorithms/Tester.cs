namespace CompareSortAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    public class Tester
    {
        public static void Main(string[] args)
        {
            var integerNumbers = new List<int>();
            var doubleNumbers = new List<double>();
            var stringValues = new List<string>();

            Random r = new Random();

            for (int i = 0; i < 10000; i++)
            {
                integerNumbers.Add(r.Next(0, 10000));
            }

            for (int i = 0; i < 10000; i++)
            {
                doubleNumbers.Add((double)(r.Next(0, 10000)));
            }

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < 10000; i++)
            {
                stringValues.Add(new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[r.Next(s.Length)])
                          .ToArray()));
            }

            var alg = new SortAlgorithmsPerformance();

            Console.Write("Int with selection sort: ");
            alg.TestPerformnace(Algorithms.Selection, integerNumbers);
            Console.Write("Int with insertion sort: ");
            alg.TestPerformnace(Algorithms.Insertion, integerNumbers);
            Console.Write("Int with quicksort: ");
            alg.TestPerformnace(Algorithms.Quick, integerNumbers);


            Console.WriteLine();
            Console.Write("Double with selection sort: ");
            alg.TestPerformnace(Algorithms.Selection, doubleNumbers);
            Console.Write("Double with insertion sort: ");
            alg.TestPerformnace(Algorithms.Insertion, doubleNumbers);
            Console.Write("Double with quicksort: ");
            alg.TestPerformnace(Algorithms.Quick, doubleNumbers);

            Console.WriteLine();
            Console.Write("String with selection sort: ");
            alg.TestPerformnace(Algorithms.Selection, stringValues);
            Console.Write("Stringwith insertion sort: ");
            alg.TestPerformnace(Algorithms.Insertion, stringValues);
            Console.Write("String with quicksort: ");
            alg.TestPerformnace(Algorithms.Quick, stringValues);
        }
    }
}
