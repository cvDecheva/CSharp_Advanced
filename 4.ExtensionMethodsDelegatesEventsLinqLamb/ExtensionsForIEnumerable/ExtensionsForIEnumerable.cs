namespace ExtensionsForIEnumerable
{
    using System;
    using System.Collections.Generic;
    using global::ExtensionsForIEnumerable.Extensions;

    public class ExtensionsForIEnumerable
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            IEnumerable<int> numbers = list;
            Console.WriteLine(numbers.Avg());
            Console.WriteLine(numbers.Product());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min<int>());
        }
    }
}
