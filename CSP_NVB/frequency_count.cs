using System;
using System.Collections.Generic;

namespace CSP_NVB
{
    internal class frequency_count
    {
        public static void Main(string[] args)
        {
            int[] c = new int[10];
            Console.WriteLine("Enter 10 elements of the array:");

            for (int i = 0; i < c.Length; i++)
            {
                c[i] = Int32.Parse(Console.ReadLine());
            }

            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int num in c)
            {
                if (freq.ContainsKey(num))
                {
                    freq[num]++;
                }
                else
                {
                    freq[num] = 1;
                }
            }

            Console.WriteLine("\nFrequency of each element:");
            foreach (var pair in freq)
            {
                Console.WriteLine($"Element {pair.Key} occurs {pair.Value} time(s)");
            }
        }
    }
}
