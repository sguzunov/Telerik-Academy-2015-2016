namespace Assertions
{
    using System;

    public static class Utils
    {
        public static bool AreSorted<T>(T[] elements) where T : IComparable<T>
        {
            if (elements.Length > 1)
            {
                for (int i = 1; i < elements.Length; i++)
                {
                    if (elements[i].CompareTo(elements[i -1]) < 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
