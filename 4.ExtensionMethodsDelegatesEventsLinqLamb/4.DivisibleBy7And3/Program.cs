using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DivisibleBy7And3
{
    class Program
    {
        static void Main()
        {
            int[] intArray = new int[] { 3, 5, 7, 21, 15, 6 };

            var filtered = intArray
                .Where(i => i % 7 == 0 && i % 3 == 0);
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
