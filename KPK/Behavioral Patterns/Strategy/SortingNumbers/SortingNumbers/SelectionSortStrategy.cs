namespace SortingNumbers
{
    using System;
    using System.Collections.Generic;

    public class SelectionSortStrategy : ISortStrategy
    {
        public List<T> Sort<T>(List<T> elements)
            where T : IComparable<T>
        {
            for (int i = 0; i < elements.Count - 1; i++)
            {
                for (int j = i + 1; j < elements.Count; j++)
                {
                    if (elements[j].CompareTo(elements[i]) < 0)
                    {
                        var oldValue = elements[j];
                        elements[j] = elements[i];
                        elements[i] = oldValue;
                    }
                }
            }

            return elements;
        }
    }
}
