namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtentions
    {
        public static T Sum<T>(this IEnumerable<T> enumeration)
            where T : IConvertible,IComparable
        {
            dynamic sum = 0;

            foreach (var item in enumeration)
            {
                sum +=item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> enumeration)
            where T : IConvertible, IComparable
        {
            dynamic product = 1;

            foreach (var item in enumeration)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> enumeration)
            where T : IConvertible, IComparable
        {
            T min = enumeration.First();

            foreach (var item in enumeration)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }                
            }

            return min;            
        }

        public static T Max<T>(this IEnumerable<T> enumeration)
            where T : IConvertible, IComparable
        {
            T max = enumeration.First();

            foreach (var item in enumeration)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> enumeration)
          where T : IConvertible, IComparable
        {
            dynamic avegare = 0;
            dynamic sum = 0;

            foreach (var item in enumeration)
            {
                sum += item;
            }

            avegare = sum / enumeration.Count();

            return avegare;            
        }
    }
}
