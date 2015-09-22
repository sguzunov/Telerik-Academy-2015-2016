using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumbers
{
    public class QuickSortStrategy : ISortStrategy
    {
        public List<T> Sort<T>(List<T> collection) where T : IComparable<T>
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            int pivotIndex = this.GetPivot(collection);
            T pivotValue = collection[pivotIndex];

            var less = new List<T>();
            var greater = new List<T>();

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

            less = Sort(less);
            greater = Sort(greater);

            less.Add(pivotValue);
            less.AddRange(greater);
            return less;
        }

        private int GetPivot<T>(IList<T> collection)
            where T : IComparable<T>
        {
            return collection.Count / 2;
        }
    }
}
