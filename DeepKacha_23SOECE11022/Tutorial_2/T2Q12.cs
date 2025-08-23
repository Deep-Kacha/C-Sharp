using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eepKacha_23SOECE11022.Tutorial_2
{
    class T2Q12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];
            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < N; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the element to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int found = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] == target)
                {
                    found = 1;
                    break;
                }
            }

            Console.WriteLine(found);

            Console.ReadLine();
        }
    }
}
