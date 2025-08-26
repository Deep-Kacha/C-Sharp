using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepKacha_23SOECE11022
{
    class TAQ2
    {
        static void Main()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 integers:");
            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Array.Sort(arr);
            Console.WriteLine("Sorted array:");
            foreach (int item in arr)
                Console.WriteLine(item);
        }
    }
}
