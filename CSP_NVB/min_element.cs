using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP_NVB
{
    internal class min_element
    {
        public static void Main(String[] args)
        {
            int[] c = new int[5];
            Console.WriteLine("Enter elements of array:");

            for (int i = 0; i < c.Length; i++)
            {
                c[i] = Int32.Parse(Console.ReadLine());
            }

            int min = c[0];
            int minIndex = 0;

            for (int i = 1; i < c.Length; i++)
            {
                if (c[i] < min)
                {
                    min = c[i];
                    minIndex = i;
                }
            }

            Console.WriteLine($"Minimum element is {min} at index {minIndex}");
        }
    }
}
