namespace Assertions
{
    using System;
    using System.Diagnostics;

    public static class SearchingAlgorithm
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            var searchedValue = BinarySearch(arr, value, 0, arr.Length - 1);

            Debug.Assert(searchedValue != -1, "Value not found.");

            return searchedValue;
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array cannot be null");
            Debug.Assert(arr.Length >= 0, "Array cannot be empty");
            Debug.Assert(startIndex >= 0, "Start index cannot be smaller than 0.");
            Debug.Assert(startIndex <= arr.Length - 1, string.Format("Start index cannot be bigger than {0}.", arr.Length - 1));
            Debug.Assert(endIndex >= 0, "End index cannot be smaller than 0.");
            Debug.Assert(endIndex <= arr.Length - 1, string.Format("End index cannot be bigger than {0}.", arr.Length - 1));

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
