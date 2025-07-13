using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP_NVB
{
    internal class bubble_sort
    {
        public static void Main(String[] args)
        {
            int[] c = new int[5];
            Console.WriteLine("Enter elements of array:");

            for (int i = 0; i < c.Length; i++)
            {
                c[i] = Int32.Parse(Console.ReadLine());
            }

            // Bubble Sort
            for (int pass = 0; pass < c.Length - 1; pass++)
            {
                for (int i = 0; i < c.Length - 1 - pass; i++)
                {
                    if (c[i] > c[i + 1])
                    {
                        // Swap c[i] and c[i + 1]
                        int temp = c[i];
                        c[i] = c[i + 1];
                        c[i + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array in ascending order:");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
