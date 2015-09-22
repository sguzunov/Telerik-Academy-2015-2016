using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 4, 2, 8, 45, 9, 0, 1 };
            var words = new List<string> { "Diana", "Anelia", "Pesho", "Gosho" };

            var selectionStrategy = new SelectionSortStrategy();
            var quickStrategy = new QuickSortStrategy();

            var sorter = new Sorter();
            var numberResult = sorter.Sort(numbers, selectionStrategy);
            var wordsResult = sorter.Sort(words, quickStrategy);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("---------");

            for (int i = 0; i < wordsResult.Count; i++)
            {
                Console.WriteLine(wordsResult[i]);
            }
        }
    }
}
