namespace IEnumerableExtensions
{
    using System;

    public class IEnumerableExtensionsMethods
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(array.Min());
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Sum());
            Console.WriteLine(array.Average());
            Console.WriteLine(array.Product());

        }
    }

    /*
      Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
     */ 

}
