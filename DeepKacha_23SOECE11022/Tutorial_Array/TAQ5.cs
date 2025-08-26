using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepKacha_23SOECE11022
{
    class TAQ5
    {
        static void Main()
        {
            int[] arr = { 1, 2, 2, 3, 3, 3, 4 };
            var duplicates = arr.GroupBy(x => x)
                                .Where(g => g.Count() > 1)
                                .Select(g => new { Value = g.Key, Count = g.Count() })
                                .ToList();

            Console.WriteLine("Duplicate elements:");
            foreach (var item in duplicates)
                Console.WriteLine($"{item.Value} appears {item.Count} times");
        }
    }
}
