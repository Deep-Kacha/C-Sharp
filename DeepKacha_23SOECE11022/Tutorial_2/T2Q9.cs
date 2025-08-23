using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eepKacha_23SOECE11022.Tutorial_2
{
    class T2Q9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int size = 2 * N + 2;
            int[] arr = new int[size];

            Console.WriteLine("Enter {0} elements:", size);
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            FindTwoUniqueNumbers(arr);

            Console.ReadLine();
        }

        static void FindTwoUniqueNumbers(int[] arr)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            // Count frequencies
            foreach (int num in arr)
            {
                if (frequency.ContainsKey(num))
                    frequency[num]++;
                else
                    frequency[num] = 1;
            }

            Console.WriteLine("The two unique numbers are:");
            foreach (var pair in frequency)
            {
                if (pair.Value == 1)
                {
                    Console.WriteLine(pair.Key);
                }
            }
        }
    }
}
