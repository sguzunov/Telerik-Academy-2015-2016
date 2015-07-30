namespace Assertions
{
    using System;
    using System.Diagnostics;

    public static class SortingAlgorithm
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array canot be null.");
            Debug.Assert(arr.Length != 0, "Array cannot be empty.");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            Debug.Assert(Utils.AreSorted(arr), "Elements are not sorted.");
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(startIndex >= 0, "Start index cannot be smaller than 0.");
            Debug.Assert(startIndex <= arr.Length - 1, string.Format("Start index cannot be bigger than {0}.", arr.Length - 1));
            Debug.Assert(endIndex >= 0, "End index cannot be smaller than 0.");
            Debug.Assert(endIndex <= arr.Length - 1, string.Format("End index cannot be bigger than {0}.", arr.Length - 1));

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
