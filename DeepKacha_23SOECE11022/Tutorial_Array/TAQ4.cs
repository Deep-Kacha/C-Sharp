using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepKacha_23SOECE11022
{
    class TAQ4
    {
        static void Main()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[arr1.Length];
            Array.Copy(arr1, arr2, arr1.Length);

            Console.WriteLine("Copied array:");
            foreach (int item in arr2)
                Console.WriteLine(item);
        }
    }
}
