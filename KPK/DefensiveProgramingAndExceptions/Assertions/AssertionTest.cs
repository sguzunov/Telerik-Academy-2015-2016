namespace Assertions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AssertionTest
    {
        static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SortingAlgorithm.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SortingAlgorithm.SelectionSort(new int[0]); // Test sorting empty array
            SortingAlgorithm.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, -1000));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 0));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 17));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 10));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 1000));
        }
    }
}
