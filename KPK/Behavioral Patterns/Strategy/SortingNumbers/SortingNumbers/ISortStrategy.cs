namespace SortingNumbers
{
    using System;
    using System.Collections.Generic;

    public interface ISortStrategy
    {
        List<T> Sort<T>(List<T> collection) where T : IComparable<T>;
    }
}
