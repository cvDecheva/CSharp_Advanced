namespace ExtensionsForIEnumerable.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = 0;
            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            dynamic max = collection.First<T>();
            foreach (var item in collection)
            {
                if (max < item)
                {
                    max = (dynamic)item;
                }
            }

            return max;
        }

        public static T Min<T>(this IEnumerable<T> collection)
        {
            dynamic min = collection.First<T>();
            foreach (var item in collection)
            {
                if (min > item)
                {
                    min = (dynamic)item;
                }
            }

            return min;
        }

        public static T Avg<T>(this IEnumerable<T> collection)
        {
            dynamic avg = 0;
            foreach (var item in collection)
            {
                avg += (dynamic)item;
            }

            return avg / collection.Count<T>();
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic product = 1;
            foreach (var item in collection)
            {
                product *= (dynamic)item;
            }

            return product;
        }
    }
}
