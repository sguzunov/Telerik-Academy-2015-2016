namespace SortingNumbers
{
    using System;
    using System.Collections.Generic;

    public class Sorter
    {
        public List<T> Sort<T>(List<T> elements, ISortStrategy strategy)
            where T : IComparable<T>
        {
            return strategy.Sort(elements);
        }
    }
}
