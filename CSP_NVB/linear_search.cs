using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP_NVB
{
    internal class linear_search
    {
        public static void Main(String[] args)
        {

            int[] c = new int[5];
            Console.WriteLine("Enter elements of array");

            for (int i = 0; i<c.Length; i++)
            {
                c[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter element to seach : ");
            int key = Int32.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == key)
                {
                    Console.WriteLine($"Element at index : {i}");
                    found = true;
                    break;

                }
            }

            if (!found)
            {
                Console.WriteLine("Element not found");
            }
        }
        }
    }
