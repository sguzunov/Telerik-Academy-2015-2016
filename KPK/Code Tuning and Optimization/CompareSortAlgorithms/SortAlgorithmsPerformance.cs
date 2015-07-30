namespace CompareSortAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    public class SortAlgorithmsPerformance
    {
        Stopwatch watch = new Stopwatch();

        public void TestPerformnace<T>(Algorithms algorithm, List<T> collection)
            where T : IComparable<T>
        {
            if (Algorithms.Selection == algorithm)
            {
                watch.Start();
                // Test selection sort
                for (int i = 0; i < collection.Count - 1; i++)
                {
                    for (int j = i + 1; j < collection.Count; j++)
                    {
                        if (collection[i].CompareTo(collection[j]) >= 0)
                        {
                            T oldValue = collection[i];
                            collection[i] = collection[j];
                            collection[j] = oldValue;
                        }
                    }
                }

                watch.Stop();
                Console.WriteLine(watch.Elapsed);
                watch.Reset();
            }

            if (Algorithms.Insertion == algorithm)
            {
                watch.Start();
                // Test insertion sort
                for (int i = 1; i <= collection.Count - 1; i++)
                {
                    T currentValue = collection[i];
                    int j = i;
                    while (j > 0 && (collection[j - 1].CompareTo(currentValue) >= 0))
                    {
                        collection[j] = collection[j - 1];
                        j--;
                    }

                    collection[j] = currentValue;
                }

                watch.Stop();
                Console.WriteLine(watch.Elapsed);
                watch.Reset();
            }

            // Test quick sort
            if (Algorithms.Quick == algorithm)
            {
                watch.Start();
                List<T> result = QuickSort(collection);
                watch.Stop();
                Console.WriteLine(watch.Elapsed);
                watch.Reset();

             //   Console.WriteLine(string.Join(", ", result));
            }
        }

        private List<T> QuickSort<T>(List<T> collection)
            where T : IComparable<T>
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            int pivotIndex = this.GetPivot(collection);
            T pivotValue = collection[pivotIndex];

            List<T> less = new List<T>();
            List<T> greater = new List<T>();

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].CompareTo(pivotValue) < 0)
                {
                    less.Add(collection[i]);
                }
                else if (pivotIndex != i)
                {
                    greater.Add(collection[i]);
                }
            }

            less = QuickSort(less);
            greater = QuickSort(greater);

            less.Add(pivotValue);
            less.AddRange(greater);
            return less;
        }

        private int GetPivot<T>(List<T> collection)
            where T : IComparable<T>
        {
            return collection.Count / 2;
        }
    }
}
